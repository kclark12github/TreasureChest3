using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.SqlServer.Migrations.Internal;
using System.Collections.Generic;
using System.Linq;

namespace TC3Core.Data.CustomMigrationOperations
{
    public class ExtendedSqlServerMigrationsAnnotationProvider : SqlServerMigrationsAnnotationProvider
    {
        public ExtendedSqlServerMigrationsAnnotationProvider(MigrationsAnnotationProviderDependencies dependencies) : base(dependencies) { }
        public override IEnumerable<IAnnotation> For(IProperty property)
        {
            var baseAnnotations = base.For(property);
            var customAnnotations = property.GetAnnotations()
                .Where(a => a.Name == "ColumnDescription" ||
                            a.Name == "MinLength" ||
                            a.Name == "SqlDefaultValue");
            return baseAnnotations.Concat(customAnnotations);
        }
        public override IEnumerable<IAnnotation> For(IEntityType entityType)
        {
            var baseAnnotations = base.For(entityType);
            var customAnnotations = entityType.GetAnnotations().Where(a => a.Name == "TableDescription");
            return baseAnnotations.Concat(customAnnotations);
        }
    }
}
