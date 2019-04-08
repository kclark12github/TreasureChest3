namespace TCDomain.DataModel.Classes
{
    using SharedKernel.Data.Annotations;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TCDomain.DataModel.Interfaces;

    [TableDescription("Collection of Rockets.")]
    public partial class Rocket : StashBase
    {
        [ColumnDescription("Designation of the Rocket (i.e. Saturn-V, etc.).")]
        [StringLength(32)]
        public string Designation { get; set; }

        [ColumnDescription("Manufacturer of the Rocket.")]
        [StringLength(80)]
        public string Manufacturer { get; set; }

        [ColumnDescription("Name of the Rocket.")]
        [StringLength(72)]
        public string Name { get; set; }

        [ColumnDescription("Nationality of the Rocket.")]
        [StringLength(32)]
        public string Nation { get; set; }

        [ColumnDescription("Vendor where the Rocket was purchased (or priced).")]
        [StringLength(80)]
        public string ProductCatalog { get; set; }

        [ColumnDescription("Reference number/code identifying the Rocket.")]
        [StringLength(32)]
        public string Reference { get; set; }

        [ColumnDescription("Scale of Rocket.")]
        [StringLength(12)]
        public string Scale { get; set; }

        [ColumnDescription("Type of Rocket.")]
        [StringLength(32)]
        public string Type { get; set; }
    }
}
