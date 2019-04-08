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

    [TableDescription("United States Navy Ships.")]
    public partial class Ship : ShipClassBase
    {
        [ColumnDescription("Command to which this Ship is currently assigned.")]
        [StringLength(80)]
        public string Command { get; set; }

        [ColumnDescription("Date this Ship was [last] commissioned.")]
        public DateTime? DateCommissioned { get; set; }

        [ColumnDescription("History of this Ship.")]
        public string History { get; set; }

        [ColumnDescription("Designation of this Ship (i.e. Classification Type Code + Number).")]
        [StringLength(12)]
        public string HullNumber { get; set; }

        [ColumnDescription("Current Home Port of this Ship.")]
        [StringLength(80)]
        public string HomePort { get; set; }

        [ColumnDescription("Public Internet Web Site of this Ship.")]
        [StringLength(132)]
        public string InternetURL { get; set; }

        [ColumnDescription("Ken's Local intranet web site of this Ship.")]
        [StringLength(132)]
        public string LocalURL { get; set; }

        [ColumnDescription("Designation number of this Ship (for sorting).")]
        public double? Number { get; set; }

        [ColumnDescription("Current Status of this Ship.")]
        [StringLength(80)]
        public string Status { get; set; }

        [ColumnDescription("Current Zip Code for snail-mail to the crew of this Ship.")]
        [StringLength(18)]
        public string ZipCode { get; set; }
    }
}
