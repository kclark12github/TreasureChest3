namespace TCDomain.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TCDomain.Classes.Interfaces;

    [Table("Blue Angels History")]
    public partial class Blue_Angels_History : IModificationHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(80)]
        public string Dates { get; set; }

        [Column("Aircraft Type")]
        [StringLength(80)]
        public string Aircraft_Type { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        [Column("Decal Sets")]
        public string Decal_Sets { get; set; }

        public string Kits { get; set; }

        public string Notes { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
    }
}
