namespace TC3Model.DataModel.Classes
{
    using System.ComponentModel.DataAnnotations;
    using TC3Model.Annotations;

    [TableDescription("Location of cataloged items.")]
    public partial class Location : DataEntityBase
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
