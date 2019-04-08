namespace TCDomain.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TCDomain.Classes.Interfaces;

    [Table("Query")]
    public partial class Query : IModificationHistory
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(250)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string Description { get; set; }

        [Key]
        [Column("Query", Order = 2)]
        [StringLength(4000)]
        public string Query1 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Access { get; set; }

        [ConcurrencyCheck, Timestamp]
        public Byte[] RowID { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
    }
}
