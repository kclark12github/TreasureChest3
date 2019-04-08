namespace TCDomain.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TCDomain.Classes.Interfaces;

    [Table("Music")]
    public partial class Music : IModificationHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(80)]
        public string Artist { get; set; }

        [StringLength(80)]
        public string Title { get; set; }

        [StringLength(80)]
        public string Type { get; set; }

        public int? Year { get; set; }

        public bool MP3 { get; set; }

        public bool CD { get; set; }

        public bool LP { get; set; }

        public bool CS { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [StringLength(80)]
        public string AlphaSort { get; set; }

        public bool Inventoried { get; set; }

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

        [StringLength(80)]
        public string Media { get; set; }

        public string Notes { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
    }
}
