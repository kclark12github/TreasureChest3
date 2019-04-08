namespace TC3Model.DataModel.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;
    using TC3Model.Annotations;
    using TC3Model.Interfaces;

    [DataContract]
    public abstract partial class StashBase : DataEntityBase, IStash
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StashBase()
        {
            StashImages = new List<StashImage>();
        }

        private bool? mCataloged = null;
        private DateTime? mDateInventoried = null;
        private DateTime? mDatePurchased = null;
        private DateTime? mDateVerified = null;
        private int? mLocationID = null;
        private Location mLocation = null;
        private string mNotes = string.Empty;
        private decimal? mPrice = null;
        private decimal? mValue = null;
        private bool? mWishList = null;

        [DataMember]
        [ColumnDescription("Has this item been cataloged? (as opposed to representing something not actually owned)")]
        public bool? Cataloged
        {
            get { return this.mCataloged; }
            set { if (value != this.mCataloged) { this.mCataloged = value; NotifyPropertyChanged(); }; }
        }

        [DataMember]
        [ColumnDescription("Date the item was last inventoried (location confirmed).")]
        [SqlDefaultValue(DefaultValue = "getdate()")]
        public DateTime? DateInventoried
        {
            get { return this.mDateInventoried; }
            set { if (value != this.mDateInventoried) { this.mDateInventoried = value; NotifyPropertyChanged(); }; }
        }

        [DataMember]
        [ColumnDescription("Date the item was purchased (null means unknown).")]
        [SqlDefaultValue(DefaultValue = "getdate()")]
        public DateTime? DatePurchased
        {
            get { return this.mDatePurchased; }
            set { if (value != this.mDatePurchased) { this.mDatePurchased = value; NotifyPropertyChanged(); }; }
        }

        [DataMember]
        [ColumnDescription("Date the value of the item was confirmed/updated (null means unknown).")]
        [SqlDefaultValue(DefaultValue = "getdate()")]
        public DateTime? DateVerified
        {
            get { return this.mDateVerified; }
            set { if (value != this.mDateVerified) { this.mDateVerified = value; NotifyPropertyChanged(); }; }
        }

        //[DataMember]
        //[ColumnDescription("Image(s) representing the appearance of the item.")]
        //[NotMapped]
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual List<Image> Images { get; set; }

        [DataMember]
        [ColumnDescription("Last known location of the item.")]
        [Required]
        public virtual Location Location
        {
            get { return this.mLocation; }
            set { if (!value.Equals(this.mLocation)) { this.mLocation = value; NotifyPropertyChanged(); }; }
        }

        [DataMember]
        [ColumnDescription("Last known location (ID) of the item.")]
        [Required]
        public virtual int? LocationID
        {
            get { return this.mLocationID; }
            set { if (!value.Equals(this.mLocationID)) { this.mLocationID = value; NotifyPropertyChanged(); }; }
        }

        [DataMember]
        [ColumnDescription("Miscellaneous notes regarding the item.")]
        public string Notes
        {
            get { return this.mNotes; }
            set { if (value != this.mNotes) { this.mNotes = value; NotifyPropertyChanged(); }; }
        }

        [DataMember]
        [ColumnDescription("Purchase price of the item.")]
        [Column(TypeName = "money")]
        public decimal? Price
        {
            get { return this.mPrice; }
            set { if (value != this.mPrice) { this.mPrice = value; NotifyPropertyChanged(); }; }
        }

        [DataMember]
        [ColumnDescription("Current value of the item.")]
        [Column(TypeName = "money")]
        public decimal? Value
        {
            get { return this.mValue; }
            set { if (value != this.mValue) { this.mValue = value; NotifyPropertyChanged(); }; }
        }

        [DataMember]
        [ColumnDescription("Is this a WishList item?")]
        public bool? WishList
        {
            get { return this.mWishList; }
            set { if (value != this.mWishList) { this.mWishList = value; NotifyPropertyChanged(); }; }
        }

        [DataMember]
        [ColumnDescription("Image(s) representing the appearance of the item.")]
        [NotMapped]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<StashImage> StashImages { get; set; }
    }
}
