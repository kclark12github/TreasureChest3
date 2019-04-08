namespace TC3Model.DataModel.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Model;
    using System.Data.Entity.SqlServer;
    using System.Linq;
    using ReusableGenericRepository;

    internal sealed class Configuration : DbMigrationsConfiguration<TC3Model.DataModel.TCContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("System.Data.SqlClient", new CustomSqlServerMigrationSqlGenerator());
        }

        internal class CustomSqlServerMigrationSqlGenerator : SqlServerMigrationSqlGenerator
        {
            protected override void Generate(AddColumnOperation addColumnOperation)
            {
                SetAnnotatedColumn(addColumnOperation.Column);
                base.Generate(addColumnOperation);
                SetColumnDescription(addColumnOperation.Table, addColumnOperation.Column);
            }
            protected override void Generate(CreateTableOperation createTableOperation)
            {
                foreach (var columnModel in createTableOperation.Columns)
                    SetAnnotatedColumn(columnModel);
                base.Generate(createTableOperation);
                SetTableDescription(createTableOperation);
                foreach (var columnModel in createTableOperation.Columns)
                    SetColumnDescription(createTableOperation.Name, columnModel);
                foreach (var columnModel in createTableOperation.Columns)
                    AddConstraint(createTableOperation.Name, columnModel);
            }
            private void AddConstraint(string tableName, ColumnModel column)
            {
                if (column.Annotations.TryGetValue("MinLength", out AnnotationValues values))
                {
                    using (var writer = Writer())
                    {
                        string schema = Utilities.GetSchema(tableName);
                        string table = Utilities.GetTableName(tableName);
                        writer.WriteLine("ALTER TABLE [{0}].[{1}] ADD CONSTRAINT " +
                        "[CHK_{0}_{1}_{2}_MinLength] CHECK (DATALENGTH([{2}])>={3})",
                        schema, table, column.Name, values.NewValue);
                        Statement(writer);
                    }
                }
            }
            private void SetAnnotatedColumn(ColumnModel column)
            {
                if (column.Annotations.TryGetValue("SqlDefaultValue", out AnnotationValues values))
                {
                    column.DefaultValueSql = (string)values.NewValue;
                }
            }
            private void SetColumnDescription(string tableName, ColumnModel column)
            {
                if (column.Annotations.TryGetValue("ColumnDescription", out AnnotationValues values))
                {
                    using (var writer = Writer())
                    {
                        string description = (string)values.NewValue;
                        writer.WriteLine("sp_addextendedproperty @name = N'MS_Description'," +
                            "@value=N'{0}'," +
                            "@level0type=N'SCHEMA',@level0name=N'{1}'," +
                            "@level1type=N'TABLE',@level1name=N'{2}'," +
                            "@level2type=N'COLUMN',@level2name=N'{3}'",
                            description.ToString().Replace("'", "''"), 
                            Utilities.GetSchema(tableName),
                            Utilities.GetTableName(tableName), 
                            column.Name);
                        Statement(writer);
                    }
                }
            }
            private void SetTableDescription(CreateTableOperation createTableOperation)
            {
                if (createTableOperation.Annotations.TryGetValue("TableDescription", out var description))
                {
                    using (var writer = Writer())
                    {
                        string tableName = createTableOperation.Name;
                        writer.WriteLine("sp_addextendedproperty @name = N'MS_Description'," +
                            "@value=N'{0}'," +
                            "@level0type=N'SCHEMA',@level0name=N'{1}'," +
                            "@level1type=N'TABLE',@level1name=N'{2}'",
                            ((string)description).Replace("'","''"),
                            Utilities.GetSchema(tableName),
                            Utilities.GetTableName(tableName));
                        Statement(writer);
                    }
                }
            }
            //public void AddColumnsDescriptions(DbContext mydbContext)
            //{
            //    // Fetch all the DbContext class public properties which contains your attributes
            //    var dbContextProperies = typeof(DbContext).GetProperties().Select(pi => pi.Name).ToList();

            //    // Loop each DbSets of type T
            //    foreach (var item in typeof(MyDbContext).GetProperties()
            //        .Where(p => dbContextProperies.IndexOf(p.Name) < 0)
            //        .Select(p => p))
            //    {
            //        if (!item.PropertyType.GetGenericArguments().Any())
            //        {
            //            continue;
            //        }

            //        // Fetch the type of "T"
            //        var entityModelType = item.PropertyType.GetGenericArguments()[0];
            //        var descriptionInfos = from prop in entityModelType.GetProperties()
            //                               where prop.GetCustomAttributes(typeof(DescriptionAttribute), true).Any()
            //                               select new { ColumnName = prop.Name, Attributes = prop.CustomAttributes };

            //        foreach (var descriptionInfo in descriptionInfos)
            //        {
            //            // Sql to create the description column and adding 
            //            var addDiscriptionColumnSql =
            //                @"sp_addextendedproperty  @name = N'MS_Description', @value = '"
            //                + descriptionInfo.Attributes.First().ConstructorArguments.First()
            //                + @"', @level0type = N'Schema', @level0name = dbo,  @level1type = N'Table',  @level1name = "
            //                + entityModelType.Name + "s" + ", @level2type = N'Column', @level2name ="
            //                + descriptionInfo.ColumnName;

            //            var sqlCommandResult = mydbContext.Database.ExecuteSqlCommand(addDiscriptionColumnSql);
            //        }
            //    }
            //}
        }
        protected override void Seed(TC3Model.DataModel.TCContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
