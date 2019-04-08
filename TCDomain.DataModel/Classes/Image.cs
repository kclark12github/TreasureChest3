namespace TCDomain.DataModel.Classes
{
    using SharedKernel.Data;
    using SharedKernel.Data.Annotations;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    [TableDescription("Collection of Images both independent and those representing items tracked in the database.")]
    public partial class Image : EntityBase
    {
        [DataMember]
        [ColumnDescription("Image Name.")]
        [StringLength(80)]
        public string Name { get; set; }

        [DataMember]
        [ColumnDescription("Actual Image binary.")]
        [Column("Image", TypeName = "image")]
        public byte[] ImageContent { get; set; }

        [DataMember]
        [ColumnDescription("File system object from which this Image was imported.")]
        [StringLength(80)]
        public string FileName { get; set; }

        [DataMember]
        [ColumnDescription("Internel web site providing this Image (if applicable).")]
        [StringLength(132)]
        public string URL { get; set; }

        [DataMember]
        [ColumnDescription("Height in pixels of this Image.")]
        public int? Height { get; set; }

        [DataMember]
        [ColumnDescription("Width in pixels of this Image.")]
        public int? Width { get; set; }

        [DataMember]
        [ColumnDescription("Category of this Image.")]
        [StringLength(80)]
        public string Category { get; set; }

        [DataMember]
        [ColumnDescription("Sort string.")]
        [StringLength(132)]
        public string AlphaSort { get; set; }

        [DataMember]
        [ColumnDescription("Table of the record related to this image.")]
        [Index("IX_ImageByRecord", 1)]
        [StringLength(32)]
        public string TableName { get; set; }

        [DataMember]
        [ColumnDescription("Record ID of the record related to this image.")]
        [Index("IX_ImageByRecord", 2)]
        public int? RecordID { get; set; }

        [DataMember]
        [ColumnDescription("Does this image represent the thumbnail of another, main image?")]
        public bool Thumbnail { get; set; }

        [DataMember]
        [ColumnDescription("Thumbnail Image of this main image.")]
        public Image ThumbnailImage { get; set; }

        [DataMember]
        [ColumnDescription("Image Caption.")]
        public string Caption { get; set; }

        [DataMember]
        [ColumnDescription("Miscellaneous Notes.")]
        public string Notes { get; set; }
    }
}
