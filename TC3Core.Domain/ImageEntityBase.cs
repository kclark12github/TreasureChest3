using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using TC3Core.Domain.Annotations;
using TC3Core.Domain.Classes;
using TC3Core.Domain.Interfaces;

namespace TC3Core.Domain
{
    [DataContract]
    public abstract partial class ImageEntityBase : DataEntityBase, IImageEntity
    {
        #region "Locals"
        private List<Image> mImages = new List<Image>();
        #endregion

        [DataMember]
        [ColumnDescription("Image(s) representing the appearance of the item.")]
        [NotMapped]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Image> Images
        {
            get => mImages;
            set { SetProperty(ref mImages, value); }
        }
    }
}
