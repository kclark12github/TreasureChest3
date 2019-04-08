using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using TC3Core.Domain.Annotations;

namespace TC3Core.Domain.Classes.Stash
{
    [TableDescription("Collection of Detail Sets.")]
    public partial class DetailSet : KitBase
    {
        [ColumnDescription("Set of model kits to which this Detail Set may be applied.")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kit> Kits { get; set; }
    }
}
