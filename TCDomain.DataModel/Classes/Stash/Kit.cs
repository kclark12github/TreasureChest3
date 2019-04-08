namespace TCDomain.DataModel.Classes
{
    using SharedKernel.Data.Annotations;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TCDomain.DataModel.Interfaces;

    [TableDescription("Collection of Model Kits.")]
    public partial class Kit : StashBase
    {
        [ColumnDescription("Condition of the Model Kit (i.e. Built, Opened, etc.).")]
        [StringLength(132)]
        public string Condition { get; set; }

        [ColumnDescription("Specific Decal included with or used by this Model Kit.")]
        public virtual Decal Decal { get; set; }

        [ColumnDescription("Designation of the Model Kit (i.e. F-14A, BB-63, etc.).")]
        [StringLength(132)]
        public string Designation { get; set; }

        [ColumnDescription("Specific Detail Set included with or used by this Model Kit.")]
        public virtual DetailSet DetailSet { get; set; }

        [ColumnDescription("Era the prototype of the Model Kit served (i.e. WWII, Vietnam, etc.).")]
        [StringLength(80)]
        public string Era { get; set; }

        [ColumnDescription("Manufacturer of the Model Kit.")]
        [StringLength(132)]
        public string Manufacturer { get; set; }

        [ColumnDescription("Name of the Model Kit.")]
        [StringLength(256)]
        public string Name { get; set; }

        [ColumnDescription("Nationality of the Model Kit.")]
        [StringLength(132)]
        public string Nation { get; set; }

        [ColumnDescription("Is the item out-of-production?")]
        public bool OutOfProduction { get; set; }

        [ColumnDescription("Vendor where the Model Kit was purchased (or priced).")]
        [StringLength(132)]
        public string ProductCatalog { get; set; }

        [ColumnDescription("Reference number/code identifying the Model Kit.")]
        [StringLength(132)]
        public string Reference { get; set; }

        [ColumnDescription("Scale of Model Kit.")]
        [StringLength(12)]
        public string Scale { get; set; }

        [ColumnDescription("Service the prototype of the Model Kit served (i.e. USN, USMC, USAAF, etc.).")]
        [StringLength(132)]
        public string Service { get; set; }

        [ColumnDescription("Type of Model Kit (i.e. Aircraft, Ship, etc.).")]
        [StringLength(132)]
        public string Type { get; set; }
    }
}
