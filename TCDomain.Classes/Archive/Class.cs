namespace TCDomain.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TCDomain.Classes.Interfaces;

    [Table("Class")]
    public partial class Class : IModificationHistory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Class()
        {
            Ships = new HashSet<Ship>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        public int? ClassificationID { get; set; }

        [StringLength(32)]
        public string Classification { get; set; }

        public int? Year { get; set; }

        public int? DefaultImage { get; set; }

        [StringLength(132)]
        public string Speed { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        public string Aircraft { get; set; }

        [Column("ASW Weapons")]
        public string ASW_Weapons { get; set; }

        public string Beam { get; set; }

        public string Boilers { get; set; }

        public string Description { get; set; }

        public string Displacement { get; set; }

        public string Draft { get; set; }

        public string EW { get; set; }

        [Column("Fire Control")]
        public string Fire_Control { get; set; }

        public string Guns { get; set; }

        public string Length { get; set; }

        public string Manning { get; set; }

        public string Missiles { get; set; }

        public string Notes { get; set; }

        public string Propulsion { get; set; }

        public string Radars { get; set; }

        public string Sonars { get; set; }

        public virtual Classification Classification1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ship> Ships { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
    }
}
