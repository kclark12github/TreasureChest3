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

    [TableDescription("Hobby supply company address book.")]
    public partial class Company : EntityBase
    {
        [ColumnDescription("Account number for ordering from this company.")]
        [StringLength(32)]
        public string Account { get; set; }

        [ColumnDescription("Company mailing address.")]
        public string Address { get; set; }

        [ColumnDescription("Company code.")]
        [StringLength(32)]
        public string Code { get; set; }

        [ColumnDescription("Full Company Name.")]
        [StringLength(72)]
        public string Name { get; set; }

        [ColumnDescription("Company phone number.")]
        [StringLength(14)]
        public string Phone { get; set; }

        [ColumnDescription("Type of hobby products supplied by this company.")]
        [StringLength(32)]
        public string ProductType { get; set; }

        [ColumnDescription("Company Short Name.")]
        [StringLength(32)]
        public string ShortName { get; set; }

        [ColumnDescription("Company web site.")]
        public string WebSite { get; set; }
    }
}
