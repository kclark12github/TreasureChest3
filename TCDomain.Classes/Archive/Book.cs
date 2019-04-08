namespace TCDomain.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TCDomain.Classes.Interfaces;

    public partial class Book : IModificationHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(80)]
        public string Author { get; set; }

        [StringLength(132)]
        public string Title { get; set; }

        [StringLength(24)]
        public string ISBN { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [StringLength(80)]
        public string Alphasort { get; set; }

        [StringLength(80)]
        public string Subject { get; set; }

        [StringLength(32)]
        public string Misc { get; set; }

        public bool? Cataloged { get; set; }

        public DateTime? DateInventoried { get; set; }

        public bool WishList { get; set; }

        [StringLength(80)]
        public string Location { get; set; }

        public DateTime? DatePurchased { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        [Column(TypeName = "image")]
        public byte[] OtherImage { get; set; }

        [Column(TypeName = "money")]
        public decimal? Value { get; set; }

        public DateTime? DateVerified { get; set; }

        public string Notes { get; set; }

        [StringLength(80)]
        public string Format { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
    }
}
