namespace TCDomain.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TCDomain.Classes.Interfaces;

    [Table("Aircraft Designations")]
    public partial class Aircraft_Designation : IModificationHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(32)]
        public string Designation { get; set; }

        [StringLength(72)]
        public string Name { get; set; }

        [StringLength(80)]
        public string Nicknames { get; set; }

        [StringLength(72)]
        public string Manufacturer { get; set; }

        [Column("Service Date")]
        public DateTime? Service_Date { get; set; }

        [StringLength(32)]
        public string Type { get; set; }

        public double? Number { get; set; }

        [StringLength(32)]
        public string Version { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        public string Notes { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
    }
}
