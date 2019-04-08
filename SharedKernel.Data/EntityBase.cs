using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using SharedKernel.Data.Annotations;
using SharedKernel.Interfaces;

namespace SharedKernel.Data
{
    [DataContract]
    public partial class EntityBase : IEntity, INotifyPropertyChanged
    {
        #region "INotifyPropertyChanged Event(s)"
        public event PropertyChangedEventHandler PropertyChanged;
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (!string.IsNullOrEmpty(propertyName) && PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        #region "Properties"
        private int mID = 0;
        private int? mOID = null;
        private DateTime mDateModified = DateTime.MinValue;
        private bool mIsDirty = false;

        [DataMember]
        [ColumnDescription("Unique system-generated identifier.")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID
        {
            get { return this.mID; }
            set { if (value != this.mID) { this.mID = value; NotifyPropertyChanged(); }; }
        }

        [DataMember]
        [ColumnDescription("Pre-conversion unique system-generated identifier.")]
        public int? OID
        {
            get { return this.mOID; }
            set { if (value != this.mOID) { this.mOID = value; NotifyPropertyChanged(); }; }
        }

        [DataMember]
        [ColumnDescription("System-managed concurrency control field.")]
        [ConcurrencyCheck]
        [Timestamp]
        public Byte[] RowID { get; set; }

        [DataMember]
        [ColumnDescription("Date the item was added to the database.")]
        [SqlDefaultValue(DefaultValue = "getdate()")]
        public DateTime DateCreated { get; set; }

        [DataMember]
        [ColumnDescription("Date the item was last modified.")]
        [SqlDefaultValue(DefaultValue = "getdate()")]
        public DateTime DateModified
        {
            get { return this.mDateModified; }
            set { if (value != this.mDateModified) { this.mDateModified = value; NotifyPropertyChanged(); }; }
        }

        [DataMember]
        [NotMapped]
        public bool IsDirty
        {
            get { return this.mIsDirty; }
            set { if (value != this.mIsDirty) { this.mIsDirty = value; NotifyPropertyChanged(); }; }
        }
        #endregion
    }
}
