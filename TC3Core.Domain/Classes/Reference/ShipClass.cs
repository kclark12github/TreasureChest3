﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TC3Core.Domain.Annotations;
namespace TC3Core.Domain.Classes.Reference
{
    [TableDescription("United States Navy Ship Classes.")]
    [Table("ShipClass")]
    public partial class ShipClass : ShipClassBase
    {
        #region "Locals"
        private int? mYear = null;
        #endregion

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShipClass()
        {
            Ships = new HashSet<Ship>();
        }

        [ColumnDescription("Year this Class was designed.")]
        public int? Year
        {
            get => mYear;
            set { SetProperty(ref mYear, value); }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ship> Ships { get; set; }
    }
}
