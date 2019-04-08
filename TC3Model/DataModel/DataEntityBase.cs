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
using TC3Model.Annotations;
using TC3Model.DataModel.Classes;
using TC3Model.Interfaces;

namespace TC3Model.DataModel
{
    [DataContract]
    public partial class DataEntityBase : EntityBase, IDataEntity
    {
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
    }
}
