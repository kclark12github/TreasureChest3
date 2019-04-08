namespace TC3Model.DataModel.Classes
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TC3Model.Annotations;
    using TC3Model.Interfaces;

    [TableDescription("Collection of Detail Sets.")]
    public partial class DetailSet : StashBase
    {
        [ColumnDescription("Designation of the corresponding model kit (i.e. F-14A, BB-63, etc.) used to display possible applications of the particular Detail Set.")]
        [StringLength(132)]
        public string Designation { get; set; }

        [ColumnDescription("Set of model kits to which this Detail Set may be applied.")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kit> Kits { get; set; }

        [ColumnDescription("Manufacturer of the Detail Set.")]
        [StringLength(132)]
        public string Manufacturer { get; set; }

        [ColumnDescription("Name of the Detail Set.")]
        [StringLength(256)]
        public string Name { get; set; }

        [ColumnDescription("Nationality of the Detail Set.")]
        [StringLength(132)]
        public string Nation { get; set; }

        [ColumnDescription("Vendor where the Detail Set was purchased (or priced).")]
        [StringLength(132)]
        public string ProductCatalog { get; set; }

        [ColumnDescription("Reference number/code identifying the Detail Set.")]
        [StringLength(132)]
        public string Reference { get; set; }

        [ColumnDescription("Scale of Detail Set.")]
        [StringLength(12)]
        public string Scale { get; set; }

        [ColumnDescription("Type of Detail Set (i.e. Aircraft, Ship, etc.).")]
        [StringLength(132)]
        public string Type { get; set; }
    }
}
