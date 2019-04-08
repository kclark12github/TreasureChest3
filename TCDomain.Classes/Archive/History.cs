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

        public DateTime DateChanged { get; set; }

        [Required]
        [StringLength(32)]
        public string TableName { get; set; }

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
