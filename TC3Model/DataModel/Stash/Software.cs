namespace TC3Model.DataModel.Classes
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TC3Model.Annotations;
    using TC3Model.Interfaces;

    [TableDescription("Library of Software, ranging from floppy discs, to CD/DVD to electronic media.")]
    [Table("Software")]
    public partial class Software : StashBase
    {
        [ColumnDescription("Sort string.")]
        [Required]
        [StringLength(132)]
        //[Index("IX_SoftwareByAlphaSort", 1, IsUnique = true)]
        public string AlphaSort { get; set; }

        [ColumnDescription("License key (if applicable).")]
        [StringLength(80)]
        public string CDkey { get; set; }

        [ColumnDescription("Date the software was originally released (if known).")]
        [SqlDefaultValue(DefaultValue = "getdate()")]
        public DateTime? DateReleased { get; set; }

        [ColumnDescription("Company who developed the Software.")]
        [StringLength(80)]
        public string Developer { get; set; }

        [ColumnDescription("International Standard Book Number (if known).")]
        [StringLength(24)]
        public string ISBN { get; set; }

        [ColumnDescription("Distribution Media (i.e. CD, DVD, Digital Download, etc.).")]
        [StringLength(80)]
        [SqlDefaultValue(DefaultValue = "'Unspecified'")]
        [MinLength(1)]
        public string MediaFormat { get; set; }

        [ColumnDescription("Operating System (O/S) or hardware Platform.")]
        [StringLength(32)]
        public string Platform { get; set; }

        [ColumnDescription("Company who published the Software.")]
        [StringLength(80)]
        public string Publisher { get; set; }

        [ColumnDescription("Software Title.")]
        [StringLength(80)]
        public string Title { get; set; }

        [ColumnDescription("Type of Software (i.e. Game, Development IDE, etc.).")]
        [StringLength(32)]
        public string Type { get; set; }

        [ColumnDescription("Software version number (if known).")]
        [StringLength(32)]
        public string Version { get; set; }
    }
}
