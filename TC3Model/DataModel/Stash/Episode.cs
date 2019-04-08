namespace TC3Model.DataModel.Classes
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TC3Model.Annotations;
    using TC3Model.Interfaces;

    [TableDescription("TV Episode Library")]
    public partial class Episode : StashBase
    {
        [ColumnDescription("Distributor of this title.")]
        [StringLength(80)]
        public string Distributor { get; set; }

        [ColumnDescription("Media/Format of this title (i.e. VHS, DVD, Blu-Ray, MP4, etc.).")]
        [StringLength(80)]
        [SqlDefaultValue(DefaultValue = "'Unspecified'")]
        [MinLength(1)]
        public string MediaFormat { get; set; }

        [ColumnDescription("Episode number.")]
        [StringLength(32)]
        public string Number { get; set; }

        [ColumnDescription("Date the title was originally released (if known).")]
        [SqlDefaultValue(DefaultValue = "getdate()")]
        public DateTime? DateReleased { get; set; }

        [ColumnDescription("Name of this TV Series.")]
        [StringLength(80)]
        public string Series { get; set; }

        [ColumnDescription("Was this episode/set purchased as opposed to recorded or ripped from the library? (TODO: Move into MediaFormat)")]
        public bool? StoreBought { get; set; }

        [ColumnDescription("Subject of this title (i.e. Comedy, Drama, etc.).")]
        [StringLength(80)]
        public string Subject { get; set; }

        [ColumnDescription("Was this episode/set taped? (TODO: Move into MediaFormat)")]
        public bool? Taped { get; set; }

        [ColumnDescription("Title of this episode/set.")]
        [StringLength(80)]
        public string Title { get; set; }

        [ColumnDescription("Has this episode/set been ripped to digital format? (TODO: Move into MediaFormat)")]
        public bool? WMV { get; set; }
    }
}
