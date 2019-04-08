namespace TCDomain.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TCDomain.Classes.Interfaces;

    public partial class Ship : IModificationHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? ClassificationID { get; set; }

        [StringLength(32)]
        public string Classification { get; set; }

        public double? Number { get; set; }

        [StringLength(12)]
        public string HullNumber { get; set; }

        [StringLength(72)]
        public string Name { get; set; }

        public int? ClassID { get; set; }

        [StringLength(80)]
        public string Command { get; set; }

        public DateTime? Commissioned { get; set; }

        [StringLength(132)]
        public string URL_Internet { get; set; }

        [StringLength(132)]
        public string URL_Local { get; set; }

        [StringLength(80)]
        public string HomePort { get; set; }

        [Column("Zip Code")]
        [StringLength(18)]
        public string Zip_Code { get; set; }

        [StringLength(32)]
        public string Speed { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        [StringLength(80)]
        public string Status { get; set; }

        public string Aircraft { get; set; }

        [Column("ASW Weapons")]
        public string ASW_Weapons { get; set; }

        public string Beam { get; set; }

        public string Boilers { get; set; }

        public string Displacement { get; set; }

        public string Draft { get; set; }

        public string EW { get; set; }

        [Column("Fire Control")]
        public string Fire_Control { get; set; }

        public string Guns { get; set; }

        public string History { get; set; }

        public string Length { get; set; }

        public string Manning { get; set; }

        public string Missiles { get; set; }

        [Column("More History")]
        public string More_History { get; set; }

        public string Notes { get; set; }

        public string Propulsion { get; set; }

        public string Radars { get; set; }

        public string Sonars { get; set; }

        public virtual Class Class { get; set; }

        public virtual Classification Classification1 { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
    }
}
