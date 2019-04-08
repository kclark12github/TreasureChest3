namespace TC3Model.DataModel.Classes
{
    using System.ComponentModel.DataAnnotations;
    using TC3Model.Annotations;

    [TableDescription("Hobby supply company address book.")]
    public partial class Company : ReferenceBase
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
