namespace TC3Model.DataModel.Classes
{
    using System.ComponentModel.DataAnnotations;
    using TC3Model.Annotations;

    [TableDescription("Collection of Tools.")]
    public partial class Tool : StashBase
    {
        [ColumnDescription("Manufacturer of the Tool.")]
        [StringLength(80)]
        public string Manufacturer { get; set; }

        [ColumnDescription("Name of the Tool.")]
        [StringLength(132)]
        public string Name { get; set; }

        [ColumnDescription("Vendor where the Tool was purchased (or priced).")]
        [StringLength(80)]
        public string ProductCatalog { get; set; }

        [ColumnDescription("Reference number/code identifying the Tool.")]
        [StringLength(32)]
        public string Reference { get; set; }
    }
}
