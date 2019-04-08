using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.Data.Annotations
{
    public static class CustomConventions
    {
        public static void Add(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add(new AttributeToColumnAnnotationConvention<ColumnDescriptionAttribute, string>("ColumnDescription", (p, attributes) => attributes.Single().Value));
            modelBuilder.Conventions.Add(new AttributeToTableAnnotationConvention<TableDescriptionAttribute, string>("TableDescription", (p, attributes) => attributes.Single().Value));
            modelBuilder.Conventions.Add(new AttributeToColumnAnnotationConvention<SqlDefaultValueAttribute, string>("SqlDefaultValue", (p, attributes) => attributes.Single().DefaultValue));
            modelBuilder.Conventions.Add(new AttributeToColumnAnnotationConvention<MinLengthAttribute, int>("MinLength", (p, attributes) => attributes.Single().Length));
        }
    }
}
