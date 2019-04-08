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

    [TableDescription("United States Navy Ship Classification Types.")]
    public partial class ShipClassificationType : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShipClassificationType()
        {
            ShipClasses = new HashSet<ShipClass>();
            Ships = new HashSet<Ship>();
        }

        [ColumnDescription("Classification Type Description (i.e. Aircraft Carrier, Battleship, Destroyer, etc.).")]
        [StringLength(80)]
        public string Description { get; set; }

        [ColumnDescription("List of Ship Classes representing this particular Classification.")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipClass> ShipClasses { get; set; }

        [ColumnDescription("List of Ships for representing this particular Classification.")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ship> Ships { get; set; }

        [ColumnDescription("Classification Type Code (i.e. CV, BB, DD, etc.).")]
        [StringLength(32)]
        public string TypeCode { get; set; }
    }
}
