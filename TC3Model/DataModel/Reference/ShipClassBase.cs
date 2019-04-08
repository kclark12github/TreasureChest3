namespace TC3Model.DataModel.Classes
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TC3Model.Annotations;

    public abstract class ShipClassBase : ReferenceBase
    {
        public ShipClassBase()
        {
            Images = new HashSet<Image>();
        }

        [ColumnDescription("Aircraft typically deployed with this Ship/Class.")]
        public string Aircraft { get; set; }

        [ColumnDescription("Anti-Submarine-Warfare (ASW) weapon capability of this Ship/Class.")]
        public string ASWWeapons { get; set; }

        [ColumnDescription("Beam (width) of this Ship/Class.")]
        public string Beam { get; set; }

        [ColumnDescription("Boilers typically outfitted for this Ship/Class.")]
        public string Boilers { get; set; }

        //[ColumnDescription("Classification of this Ship / Class.")]
        //public virtual ShipClassType ShipClassType { get; set; }

        [ColumnDescription("General Description of this Ship/Class.")]
        public string Description { get; set; }

        [ColumnDescription("Displacement of this Ship/Class.")]
        public string Displacement { get; set; }

        [ColumnDescription("Draft of this Ship/Class.")]
        public string Draft { get; set; }

        [ColumnDescription("Electronic Warfare (EW) capability of this Ship/Class.")]
        public string EW { get; set; }

        [ColumnDescription("FireControl capability of this Ship/Class.")]
        public string FireControl { get; set; }

        [ColumnDescription("Gun armament of this Ship/Class.")]
        public string Guns { get; set; }

        //[ColumnDescription("Example Image(s) of this Ship/Class.")]
        [NotMapped]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Image> Images { get; set; }

        [ColumnDescription("Length of this Ship/Class.")]
        public string Length { get; set; }

        [ColumnDescription("Crew compliment of this Ship/Class.")]
        public string Manning { get; set; }

        [ColumnDescription("Missile armament of this Ship/Class.")]
        public string Missiles { get; set; }

        [ColumnDescription("Name of this Ship/Class.")]
        [StringLength(80)]
        public string Name { get; set; }

        [ColumnDescription("Miscellaneous Notes.")]
        public string Notes { get; set; }

        [ColumnDescription("Propulsion system of this Ship/Class.")]
        public string Propulsion { get; set; }

        [ColumnDescription("RADAR capability of this Ship/Class.")]
        public string Radars { get; set; }

        [ColumnDescription("Speed of this Ship/Class.")]
        [StringLength(132)]
        public string Speed { get; set; }

        [ColumnDescription("SONAR capability of this Ship/Class.")]
        public string Sonars { get; set; }
    }
}
