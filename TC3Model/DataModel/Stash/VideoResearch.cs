namespace TC3Model.DataModel.Classes
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("VideoResearch")]
    public partial class VideoResearch : StashBase
    {
        [StringLength(72)]
        public string AlphaSort { get; set; }

        [StringLength(72)]
        public string Distributor { get; set; }

        [StringLength(32)]
        public string Format { get; set; }

        public DateTime? ReleaseDate { get; set; }

        [StringLength(32)]
        public string Subject { get; set; }

        [StringLength(72)]
        public string Title { get; set; }
    }
}
