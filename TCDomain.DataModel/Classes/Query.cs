namespace TCDomain.DataModel.Classes
{
    using SharedKernel.Data;
    using SharedKernel.Data.Annotations;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TCDomain.DataModel.Interfaces;

    [TableDescription("Canned queries which can be run within the application.")]
    [Table("Query")]
    public partial class Query : EntityBase
    {
        [ColumnDescription("Query Name.")]
        [StringLength(250)]
        public string Name { get; set; }

        [ColumnDescription("Query Description.")]
        [StringLength(250)]
        public string Description { get; set; }

        [ColumnDescription("Query body.")]
        public string QueryText { get; set; }

        [ColumnDescription("Query Access.")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Access { get; set; }
    }
}
