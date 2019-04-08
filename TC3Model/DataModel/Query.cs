namespace TC3Model.DataModel
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TC3Model.Annotations;

    [TableDescription("Canned queries which can be run within the application.")]
    [Table("Query")]
    public partial class Query : DataEntityBase
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
