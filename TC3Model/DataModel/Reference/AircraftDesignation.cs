namespace TC3Model.DataModel.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TC3Model.Annotations;

    [TableDescription("Aircraft Designations")]
    [Table("AircraftDesignations")]
    public partial class AircraftDesignation : ReferenceBase
    {
        public AircraftDesignation()
        {
            Images = new HashSet<Image>();
        }

        [ColumnDescription("Official Designation of this aircraft.")]
        [StringLength(32)]
        public string Designation { get; set; }

        //[ColumnDescription("Example Image(s) of this aircraft.")]
        [NotMapped]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Image> Images { get; set; }

        [ColumnDescription("Manufacturer of this aircraft.")]
        [StringLength(72)]
        public string Manufacturer { get; set; }

        [ColumnDescription("Official Name of this aircraft.")]
        [StringLength(72)]
        public string Name { get; set; }

        [ColumnDescription("Unofficial Nicknames of this aircraft.")]
        [StringLength(80)]
        public string Nicknames { get; set; }

        [ColumnDescription("Miscellaneous Notes.")]
        public string Notes { get; set; }

        [ColumnDescription("Designation number of this aircraft (for sorting).")]
        public double? Number { get; set; }

        [ColumnDescription("Date this aircraft entered service.")]
        public DateTime? ServiceDate { get; set; }

        [ColumnDescription("Type of this aircraft (i.e. Fighter, Bomber, etc.).")]
        [StringLength(32)]
        public string Type { get; set; }

        [ColumnDescription("Version of this aircraft.")]
        [StringLength(32)]
        public string Version { get; set; }
    }
}
