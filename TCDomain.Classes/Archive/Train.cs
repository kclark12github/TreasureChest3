namespace TCDomain.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TCDomain.Classes.Interfaces;

    public partial class Train : IModificationHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(32)]
        public string Type { get; set; }

        [StringLength(72)]
        public string Line { get; set; }

        [StringLength(12)]
        public string Scale { get; set; }

        [StringLength(80)]
        public string Manufacturer { get; set; }

        [StringLength(80)]
        public string ProductCatalog { get; set; }

        [StringLength(32)]
        public string Reference { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public DateTime? DateInventoried { get; set; }

        public bool WishList { get; set; }

        [StringLength(80)]
        public string Location { get; set; }

        public DateTime? DatePurchased { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        [Column(TypeName = "money")]
        public decimal? Value { get; set; }

        public DateTime? DateVerified { get; set; }

        public string Notes { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
    }
}
