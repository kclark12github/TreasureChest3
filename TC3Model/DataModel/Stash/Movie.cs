namespace TC3Model.DataModel.Classes
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TC3Model.Annotations;
    using TC3Model.Interfaces;

    [TableDescription("Movie Library")]
    public partial class Movie : StashBase
    {
        [ColumnDescription("Sort string.")]
        [StringLength(80)]
        public string AlphaSort { get; set; }

        [ColumnDescription("Distributor of this title.")]
        [StringLength(80)]
        public string Distributor { get; set; }

        [ColumnDescription("Media/Format of this title (i.e. VHS, DVD, Blu-Ray, MP4, etc.).")]
        [StringLength(80)]
        [SqlDefaultValue(DefaultValue = "'Unspecified'")]
        [MinLength(1)]
        public string MediaFormat { get; set; }

        [ColumnDescription("Date the title was originally released (if known).")]
        [SqlDefaultValue(DefaultValue = "getdate()")]
        public DateTime? DateReleased { get; set; }

        [ColumnDescription("Was this title purchased as opposed to recorded or ripped from the library? (TODO: Move into MediaFormat)")]
        public bool? StoreBought { get; set; }

        [ColumnDescription("Subject of this title (i.e. Comedy, Drama, etc.).")]
        [StringLength(80)]
        public string Subject { get; set; }

        [ColumnDescription("Title of this Movie.")]
        [StringLength(80)]
        public string Title { get; set; }

        [ColumnDescription("Has this title been ripped to digital format? (TODO: Move into MediaFormat)")]
        public bool? WMV { get; set; }
    }
}
