namespace TC3Model.DataModel.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;
    using TC3Model.Annotations;
    using TC3Model.Interfaces;

    [DataContract]
    public abstract partial class ReferenceBase : DataEntityBase, IReference
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReferenceBase()
        {
            ReferenceImages = new List<ReferenceImage>();
        }

        [DataMember]
        [ColumnDescription("Image(s) representing the appearance of the item.")]
        [NotMapped]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<ReferenceImage> ReferenceImages { get; set; }
    }
}
