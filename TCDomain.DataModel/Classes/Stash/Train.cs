namespace TCDomain.DataModel.Classes
{
    using SharedKernel.Data.Annotations;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TCDomain.DataModel.Interfaces;

    [TableDescription("Collection of Trains/Locomotives/Rolling Stock.")]
    public partial class Train : StashBase
    {
        [ColumnDescription("Railroad line of this particular item")]
        [StringLength(72)]
        public string Line { get; set; }

        [ColumnDescription("Manufacturer of the item.")]
        [StringLength(80)]
        public string Manufacturer { get; set; }

        [ColumnDescription("Name of this particular item")]
        [StringLength(132)]
        public string Name { get; set; }

        [ColumnDescription("Vendor where the item was purchased (or priced).")]
        [StringLength(80)]
        public string ProductCatalog { get; set; }

        [ColumnDescription("Reference number/code identifying the item.")]
        [StringLength(32)]
        public string Reference { get; set; }

        [ColumnDescription("Reference number/code identifying the item.")]
        [StringLength(12)]
        public string Scale { get; set; }

        [ColumnDescription("Type of the item (i.e. Trains, Locomotives, Rolling Stock, etc.).")]
        [StringLength(32)]
        public string Type { get; set; }

    }
}
