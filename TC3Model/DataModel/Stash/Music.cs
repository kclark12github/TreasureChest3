namespace TC3Model.DataModel.Classes
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TC3Model.Annotations;
    using TC3Model.Interfaces;

    [TableDescription("Library of Music, including physical and electronic media.")]
    [Table("Music")]
    public partial class Music : StashBase
    {
        [ColumnDescription("Artist of the album.")]
        [StringLength(80)]
        public string Artist { get; set; }

        [ColumnDescription("Sort string.")]
        [StringLength(80)]
        public string AlphaSort { get; set; }

        [ColumnDescription("Media/Format of this album (i.e. LP, CD, MP3, etc.).")]
        [StringLength(80)]
        [SqlDefaultValue(DefaultValue = "'Unspecified'")]
        [MinLength(1)]
        public string MediaFormat { get; set; }

        [ColumnDescription("Album title.")]
        [StringLength(80)]
        public string Title { get; set; }

        [ColumnDescription("Genre of this title.")]
        [StringLength(80)]
        public string Type { get; set; }

        [ColumnDescription("Year this album was originally released.")]
        public int? Year { get; set; }
    }
}
