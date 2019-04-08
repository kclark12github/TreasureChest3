namespace TCDomain.DataModel.Classes
{
    using SharedKernel.Data;
    using SharedKernel.Data.Annotations;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [TableDescription("Location of catalogued items.")]
    public partial class Location : EntityBase
    {
        [ColumnDescription("Description of box/container (if applicable).")]
        [StringLength(1024)]
        public string Description { get; set; }

        [ColumnDescription("Name of location.")]
        [StringLength(1024)]
        public string Name { get; set; }

        [ColumnDescription("Physical location of the box/container represented by this Location.")]
        [StringLength(1024)]
        public string PhysicalLocation { get; set; }
    }
}
