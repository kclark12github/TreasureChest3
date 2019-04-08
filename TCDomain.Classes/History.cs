namespace TCDomain.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("History")]
    public partial class History
    {
        public int ID { get; set; }

        [ConcurrencyCheck, Timestamp]
        public Byte[] RowID { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime DateChanged { get; set; }

        [Key]
        [Column(Order = 0)]
        [Required]
        [StringLength(32)]
        public string TableName { get; set; }

        [Key]
        [Column(Order = 1)]
        public int RecordID { get; set; }

        [StringLength(32)]
        public string Column { get; set; }

        [StringLength(3950)]
        public string OriginalValue { get; set; }

        [StringLength(3950)]
        public string Value { get; set; }

        [StringLength(32)]
        public string Who { get; set; }
    }
}
