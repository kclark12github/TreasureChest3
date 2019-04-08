namespace TCDomain.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TCDomain.Classes.Interfaces;

    [Table("Software")]
    public partial class Software : IModificationHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(80)]
        public string Title { get; set; }

        [StringLength(32)]
        public string Version { get; set; }

        [Column(TypeName = "money")]
        public decimal? Value { get; set; }

        [StringLength(24)]
        public string ISBN { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [StringLength(80)]
        public string Publisher { get; set; }

        [StringLength(32)]
        public string Type { get; set; }

        [StringLength(32)]
        public string Platform { get; set; }

        [StringLength(80)]
        public string Media { get; set; }

        [StringLength(80)]
        public string Location { get; set; }

        [StringLength(80)]
        public string CDkey { get; set; }

        public bool Cataloged { get; set; }

        public DateTime? DateInventoried { get; set; }

        public bool WishList { get; set; }

        public DateTime? DatePurchased { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        [StringLength(80)]
        public string Developer { get; set; }

        public DateTime? DateReleased { get; set; }

        public DateTime? DateVerified { get; set; }

        [Required]
        [StringLength(132)]
        public string AlphaSort { get; set; }

        [Column(TypeName = "image")]
        public byte[] OtherImage { get; set; }

        public string Notes { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
    }
}
