namespace TCDomain.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TCDomain.Classes.Interfaces;

    public partial class Image : IModificationHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        [Column("Image", TypeName = "image")]
        public byte[] Image1 { get; set; }

        [StringLength(80)]
        public string FileName { get; set; }

        [StringLength(132)]
        public string URL { get; set; }

        public int? Height { get; set; }

        public int? Width { get; set; }

        [StringLength(80)]
        public string Category { get; set; }

        [StringLength(132)]
        public string Sort { get; set; }

        [StringLength(32)]
        public string TableName { get; set; }

        public int? TableID { get; set; }

        public bool Thumbnail { get; set; }

        public int? ThumbnailImageID { get; set; }

        public string Caption { get; set; }

        public string Notes { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
    }
}
