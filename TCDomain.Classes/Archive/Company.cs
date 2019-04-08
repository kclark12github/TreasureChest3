namespace TCDomain.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TCDomain.Classes.Interfaces;

    public partial class Company : IModificationHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(72)]
        public string Name { get; set; }

        [StringLength(32)]
        public string ShortName { get; set; }

        [StringLength(32)]
        public string Code { get; set; }

        [StringLength(32)]
        public string Account { get; set; }

        [StringLength(32)]
        public string ProductType { get; set; }

        [StringLength(14)]
        public string Phone { get; set; }

        public string Address { get; set; }

        public string WebSite { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
    }
}
