namespace TCDomain.DataModel.Classes
{
    using SharedKernel.Data;
    using SharedKernel.Data.Annotations;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TCDomain.DataModel.Interfaces;

    [TableDescription("History of changes applied by the application.")]
    [Table("History")]
    public partial class History : EntityBase
    {
        [ColumnDescription("Column changed.")]
        [Index("IX_HistoryByRecord", 4, IsUnique = true)]
        [Index("IX_HistoryByDate", 4, IsUnique = true)]
        [StringLength(32)]
        public string Column { get; set; }

        [ColumnDescription("Date of this change.")]
        [Index("IX_HistoryByRecord", 3, IsUnique = true)]
        [Index("IX_HistoryByDate", 1, IsUnique = true)]
        public DateTime DateChanged { get; set; }

        [ColumnDescription("Original (changed from) value.")]
        public string OriginalValue { get; set; }

        [ColumnDescription("Record changed.")]
        [Index("IX_HistoryByRecord", 2, IsUnique = true)]
        [Index("IX_HistoryByDate", 3, IsUnique = true)]
        public int RecordID { get; set; }

        [ColumnDescription("Table changed.")]
        [Index("IX_HistoryByRecord", 1, IsUnique = true)]
        [Index("IX_HistoryByDate", 2, IsUnique = true)]
        [Required]
        [StringLength(32)]
        public string TableName { get; set; }

        [ColumnDescription("New (changed to) value.")]
        public string Value { get; set; }

        [ColumnDescription("User ID affecting this change.")]
        [StringLength(32)]
        public string Who { get; set; }
    }
}
