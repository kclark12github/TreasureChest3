using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.SqlServer.Migrations.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace TC3Core.Data.CustomMigrationOperations
{
    public class ExtendedSqlServerMigrationsAnnotationProvider : SqlServerMigrationsAnnotationProvider
    {
        public ExtendedSqlServerMigrationsAnnotationProvider(MigrationsAnnotationProviderDependencies dependencies) : base(dependencies)
        {
            Console.WriteLine("ExtendedSqlServerMigrationsAnnotationProvider()");
            Debugger.Launch();
        }
        public override IEnumerable<IAnnotation> For(IIndex index)
        {
            Console.WriteLine($"\t\tFor({index})");
            var baseAnnotations = base.For(index);
            var customAnnotations = index.GetAnnotations().Where(a => a.Name == "SqlServer:IncludeIndex");
            Console.WriteLine($"\t\t\t{customAnnotations}");
            return customAnnotations == null ? baseAnnotations : baseAnnotations.Concat(customAnnotations);
        }
        public override IEnumerable<IAnnotation> For(IProperty property)
        {
            Console.WriteLine($"\t\tFor({property})");
            var baseAnnotations = base.For(property);
            var customAnnotations = property.GetAnnotations()
                .Where(a => a.Name == "ColumnDescription" ||
                            a.Name == "MinLength" ||
                            a.Name == "SqlDefaultValue");
            Console.WriteLine($"\t\t\t{customAnnotations}");
            return customAnnotations == null ? baseAnnotations : baseAnnotations.Concat(customAnnotations);
        }
        public override IEnumerable<IAnnotation> For(IEntityType entityType)
        {
            Console.WriteLine($"\tFor({entityType})");
            var baseAnnotations = base.For(entityType);
            var customAnnotations = entityType.GetAnnotations().Where(a => a.Name == "TableDescription");
            Console.WriteLine($"\t\t{customAnnotations}");
            return customAnnotations == null ? baseAnnotations : baseAnnotations.Concat(customAnnotations);
        }
    }
}
