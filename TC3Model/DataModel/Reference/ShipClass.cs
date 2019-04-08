namespace TC3Model.DataModel.Classes
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using TC3Model.Annotations;

    [TableDescription("United States Navy Ship Classes.")]
    [Table("ShipClass")]
    public partial class ShipClass : ShipClassBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShipClass()
        {
            Ships = new HashSet<Ship>();
        }

        [ColumnDescription("Year this Class was designed.")]
        public int? Year { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ship> Ships { get; set; }
    }
}
