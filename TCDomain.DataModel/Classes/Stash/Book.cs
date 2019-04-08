namespace TCDomain.DataModel.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using SharedKernel.Data.Annotations;
    using TCDomain.DataModel.Interfaces;

    [TableDescription("Library of Books, Magazines, and electronic media.")]
    public partial class Book : StashBase
    {
        private string mAlphaSort = string.Empty;
        private string mAuthor = string.Empty;
        private string mMediaFormat = string.Empty;
        private string mISBN = string.Empty;
        private string mMisc = string.Empty;
        private string mSubject = string.Empty;
        private string mTitle = string.Empty;

        [ColumnDescription("Sort string.")]
        [StringLength(80)]
        [Required]
        [MinLength(1)]
        public string AlphaSort 
        {
            get { return this.mAlphaSort; }
            set { if (value != this.mAlphaSort) { this.mAlphaSort = value; NotifyPropertyChanged(); }; }
        }

        [ColumnDescription("Author of the publication.")]
        [StringLength(80)]
        [Required]
        [MinLength(1)]
        public string Author
        {
            get { return this.mAuthor; }
            set { if (value != this.mAuthor) { this.mAuthor = value; NotifyPropertyChanged(); }; }
        }

        [ColumnDescription("Media/Format of the publication (i.e. Hardcover, Paperback, etc).")]
        [StringLength(80)]
        [SqlDefaultValue(DefaultValue = "'Unspecified'")]
        [MinLength(1)]
        public string MediaFormat
        {
            get { return this.mMediaFormat; }
            set { if (value != this.mMediaFormat) { this.mMediaFormat = value; NotifyPropertyChanged(); }; }
        }

        [ColumnDescription("International Standard Book Number.")]
        [StringLength(24)]
        public string ISBN
        {
            get { return this.mISBN; }
            set { if (value != this.mISBN) { this.mISBN = value; NotifyPropertyChanged(); }; }
        }

        [ColumnDescription("Miscellaneous information.")]
        [StringLength(32)]
        public string Misc
        {
            get { return this.mMisc; }
            set { if (value != this.mMisc) { this.mMisc = value; NotifyPropertyChanged(); }; }
        }

        [ColumnDescription("Subject of the publication.")]
        [StringLength(80)]
        [Required]
        [MinLength(1)]
        public string Subject
        {
            get { return this.mSubject; }
            set { if (value != this.mSubject) { this.mSubject = value; NotifyPropertyChanged(); }; }
        }

        [ColumnDescription("Title of the publication.")]
        [StringLength(132)]
        [Required]
        [MinLength(1)]
        public string Title
        {
            get { return this.mTitle; }
            set { if (value != this.mTitle) { this.mTitle = value; NotifyPropertyChanged(); }; }
        }
    }
}
