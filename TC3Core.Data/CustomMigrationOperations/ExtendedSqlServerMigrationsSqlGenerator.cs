using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Diagnostics;

namespace TC3Core.Data.CustomMigrationOperations
{
    public class ExtendedSqlServerMigrationsSqlGenerator : SqlServerMigrationsSqlGenerator
    {
        protected virtual string StatementTerminator => ";";
        public ExtendedSqlServerMigrationsSqlGenerator(MigrationsSqlGeneratorDependencies dependencies, IMigrationsAnnotationProvider migrationsAnnotations) : base(dependencies, migrationsAnnotations)
        {
            Console.WriteLine("ExtendedSqlServerMigrationsSqlGenerator()");
            Debugger.Launch();
        }
        protected override void Generate(AddColumnOperation operation, IModel model, MigrationCommandListBuilder builder)
        {
            Console.WriteLine("\tHandling Generate(AddColumnOperation)");
            SetDefaultValue(operation);
            base.Generate(operation, model, builder);
            SetColumnDescription(operation, builder);
        }
        protected override void Generate(CreateTableOperation operation, IModel model, MigrationCommandListBuilder builder)
        {
            Console.WriteLine("\tHandling Generate(CreateTableOperation)");
            foreach (var addColumnOperation in operation.Columns)
                SetDefaultValue(addColumnOperation);
            base.Generate(operation, model, builder);
            SetTableDescription(operation, builder);
            foreach (var addColumnOperation in operation.Columns) {
                SetColumnDescription(addColumnOperation, builder);
                AddConstraint(addColumnOperation, builder);
            }
        }
        protected override void Generate(CreateIndexOperation operation, IModel model, MigrationCommandListBuilder builder, bool terminate)
        {
            Console.WriteLine("\tHandling Generate(CreateIndexOperation)");
            base.Generate(operation, model, builder, false);
            var includeIndexAnnotation = operation.FindAnnotation("SqlServer:IncludeIndex");
            if (includeIndexAnnotation != null)
                builder.Append($" INCLUDE({includeIndexAnnotation.Value})");
            if (terminate)
            {
                builder.AppendLine(StatementTerminator);
                EndStatement(builder);
            }
        }
        private void AddConstraint(AddColumnOperation operation, MigrationCommandListBuilder builder)
        {
            Console.WriteLine("\tHandling [MinLength]");
            var annotation = operation.FindAnnotation("MinLength");
            if (annotation != null)
            {
                string schemaName = Utilities.GetSchema(operation.Table);
                string tableName = Utilities.GetTableName(operation.Table);
                string columnName = operation.Name;
                string minValue = ((string)annotation.Value).Replace("'", "''");
                string sql = $"Alter Table [{schemaName}].[{tableName}] Add Constraint " +
                        $"[Chk_{schemaName}_{tableName}_{columnName}_MinLength] " +
                        $"Check (DataLength([{columnName}])>={minValue})";
                builder.Append(sql);
            }
        }
        private void SetDefaultValue(AddColumnOperation operation)
        {
            Console.WriteLine("\tHandling [SqlDefaultValue]");
            var annotation = operation.FindAnnotation("SqlDefaultValue");
            if (annotation != null)
            {
                operation.DefaultValueSql = (string)annotation.Value;
            }
        }
        private void SetColumnDescription(AddColumnOperation operation, MigrationCommandListBuilder builder)
        {
            Console.WriteLine("\tHandling [ColumnDescription]");
            var annotation = operation.FindAnnotation("ColumnDescription");
            if (annotation != null)
            {
                string schemaName = Utilities.GetSchema(operation.Table);
                string tableName = Utilities.GetTableName(operation.Table);
                string columnName = operation.Name;
                string description = ((string)annotation.Value).Replace("'", "''");
                string sql = $"sp_AddExtendedProperty @name = N'MS_Description'," +
                        $"@value=N'{description}'," +
                        $"@level0type=N'SCHEMA',@level0name=N'{schemaName}'," +
                        $"@level1type=N'TABLE',@level1name=N'{tableName}'," +
                        $"@level2type=N'COLUMN',@level2name=N'{columnName}'";
                builder.Append(sql);
            }
        }
        private void SetTableDescription(CreateTableOperation operation, MigrationCommandListBuilder builder)
        {
            Console.WriteLine("\tHandling [TableDescription]");
            var annotation = operation.FindAnnotation("TableDescription");
            if (annotation != null)
            {
                string schemaName = Utilities.GetSchema(operation.Name);
                string tableName = Utilities.GetTableName(operation.Name);
                string description = ((string)annotation.Value).Replace("'", "''");
                string sql = $"sp_AddExtendedProperty @name = N'MS_Description'," +
                    $"@value=N'{description}'," +
                    $"@level0type=N'SCHEMA',@level0name=N'{schemaName}'," +
                    $"@level1type=N'TABLE',@level1name=N'{tableName}'";
                builder.Append(sql);
            }
        }
    }
}
