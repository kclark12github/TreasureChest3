namespace TC3Model.DataModel.Classes
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using TC3Model.Annotations;

    [DataContract]
    [TableDescription("Collection of Decals.")]
    public partial class Decal : StashBase
    {
        [DataMember]
        [ColumnDescription("Designation of the corresponding Model Kit (i.e. F-14A, BB-63, etc.) used to display possible applications of the particular Decal.")]
        [StringLength(132)]
        public string Designation { get; set; }

        [DataMember]
        [ColumnDescription("Set of Model Kits to which this Decal may be applied.")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kit> Kits { get; set; }

        [DataMember]
        [ColumnDescription("Manufacturer of the Decal.")]
        [StringLength(132)]
        public string Manufacturer { get; set; }

        [DataMember]
        [ColumnDescription("Name of the Decal.")]
        [StringLength(256)]
        public string Name { get; set; }

        [DataMember]
        [ColumnDescription("Nationality of the Decal.")]
        [StringLength(132)]
        public string Nation { get; set; }

        [DataMember]
        [ColumnDescription("Vendor where the Decal was purchased (or priced).")]
        [StringLength(132)]
        public string ProductCatalog { get; set; }

        [DataMember]
        [ColumnDescription("Reference number/code identifying the Decal.")]
        [StringLength(132)]
        public string Reference { get; set; }

        [DataMember]
        [ColumnDescription("Scale of Decal.")]
        [StringLength(12)]
        public string Scale { get; set; }

        [DataMember]
        [ColumnDescription("Type of Decal (i.e. Aircraft, Ship, etc.).")]
        [StringLength(132)]
        public string Type { get; set; }
    }
}
