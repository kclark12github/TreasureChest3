namespace TCDomain.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TCDomain.Classes.Interfaces;

    public partial class Kit : IModificationHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(132)]
        public string Manufacturer { get; set; }

        [StringLength(132)]
        public string Type { get; set; }

        [StringLength(132)]
        public string Designation { get; set; }

        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(12)]
        public string Scale { get; set; }

        [StringLength(132)]
        public string ProductCatalog { get; set; }

        [StringLength(132)]
        public string Reference { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [StringLength(132)]
        public string Nation { get; set; }

        public DateTime? DateInventoried { get; set; }

        [StringLength(132)]
        public string Condition { get; set; }

        [StringLength(132)]
        public string Location { get; set; }

        public bool OutOfProduction { get; set; }

        public DateTime? DateVerified { get; set; }

        public bool WishList { get; set; }

        [StringLength(132)]
        public string Service { get; set; }

        [StringLength(80)]
        public string Era { get; set; }

        public DateTime? DatePurchased { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        [Column(TypeName = "image")]
        public byte[] OtherImage { get; set; }

        [Column(TypeName = "money")]
        public decimal? Value { get; set; }

        public string Notes { get; set; }

        public int? DecalID { get; set; }

        public bool HasDecals { get; set; }

        public int? DetailSetID { get; set; }

        public bool HasDetailSet { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
    }
}
