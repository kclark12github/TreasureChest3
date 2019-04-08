namespace TCDomain.DataModel.Classes
{
    using SharedKernel.Data.Annotations;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TCDomain.DataModel.Interfaces;

    [TableDescription("Inventory of Finishing Products (i.e. Paint, Brushes, etc.).")]
    public partial class FinishingProduct : StashBase
    {
        [ColumnDescription("Count of this item.")]
        public double? Count { get; set; }

        [ColumnDescription("Manufacturer of the item.")]
        [StringLength(80)]
        public string Manufacturer { get; set; }

        [ColumnDescription("Name of the item.")]
        [StringLength(72)]
        public string Name { get; set; }

        [ColumnDescription("Vendor where the item was purchased (or priced).")]
        [StringLength(80)]
        public string ProductCatalog { get; set; }

        [ColumnDescription("Reference number/code identifying the item.")]
        [StringLength(32)]
        public string Reference { get; set; }

        [ColumnDescription("Type of the item (i.e. Paint, Brush, Sanding Stick, etc.).")]
        [StringLength(32)]
        public string Type { get; set; }
    }
}
