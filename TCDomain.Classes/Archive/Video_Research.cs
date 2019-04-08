namespace TCDomain.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TCDomain.Classes.Interfaces;

    [Table("Video Research")]
    public partial class Video_Research : IModificationHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(72)]
        public string Title { get; set; }

        [StringLength(72)]
        public string Distributor { get; set; }

        [StringLength(32)]
        public string Subject { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [StringLength(72)]
        public string AlphaSort { get; set; }

        public DateTime? DateInventoried { get; set; }

        public bool WishList { get; set; }

        [StringLength(80)]
        public string Location { get; set; }

        public DateTime? DatePurchased { get; set; }

        public DateTime? ReleaseDate { get; set; }

        [StringLength(32)]
        public string Format { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        [Column(TypeName = "image")]
        public byte[] OtherImage { get; set; }

        [Column(TypeName = "money")]
        public decimal? Value { get; set; }

        public DateTime? DateVerified { get; set; }

        public bool WMV { get; set; }

        public string Notes { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
    }
}
