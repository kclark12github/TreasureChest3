namespace TCDomain.DataModel.Classes
{
    using SharedKernel.Data.Annotations;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TCDomain.DataModel.Interfaces;

    [TableDescription("Collection of Collectables, ranging from baseball cards, to Hot Wheels to Keepsake Ornaments.")]
    public partial class Collectable : StashBase
    {
        [ColumnDescription("Condition of the item (i.e. Packaged, Opened, etc.).")]
        [StringLength(80)]
        public string Condition { get; set; }

        [ColumnDescription("Manufacturer of the item.")]
        [StringLength(80)]
        public string Manufacturer { get; set; }

        [ColumnDescription("Name of the item.")]
        [StringLength(132)]
        public string Name { get; set; }

        [ColumnDescription("Is the item out-of-production?")]
        public bool OutOfProduction { get; set; }

        [ColumnDescription("Reference number/code identifying the item.")]
        [StringLength(32)]
        public string Reference { get; set; }

        [ColumnDescription("Series of the item.")]
        [StringLength(80)]
        public string Series { get; set; }

        [ColumnDescription("Type of collectable (i.e. baseball card, board game, Hot Wheel, etc.).")]
        [StringLength(80)]
        public string Type { get; set; }
    }
}
