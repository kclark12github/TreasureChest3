namespace TCDomain.DataModel.Classes
{
    using SharedKernel.Data;
    using SharedKernel.Data.Annotations;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TCDomain.DataModel.Interfaces;

    [Table("BlueAngelsHistory")]
    public partial class BlueAngelsHistory : EntityBase
    {
        public BlueAngelsHistory()
        {
            Images = new HashSet<Image>();
        }

        [ColumnDescription("Dates this aircraft served with the Blue Angels.")]
        [StringLength(80)]
        public string ServiceDates { get; set; }

        [ColumnDescription("Aircraft Type serving with the Blue Angels.")]
        [StringLength(80)]
        public string AircraftType { get; set; }

        //[ColumnDescription("Image(s) representing the appearance of this aircraft.")]
        [NotMapped]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Image> Images { get; set; }

        //TODO: Revisit these linkages...
        public string Decals { get; set; }
        public string DecalSets { get; set; }
        public string Kits { get; set; }

        [ColumnDescription("Miscellaneous Notes.")]
        public string Notes { get; set; }
    }
}
