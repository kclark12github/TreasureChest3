using System.Collections.Generic;
using TC3Core.Domain.Classes;

namespace TC3Core.Domain.Interfaces
{
    public interface IImageEntity : IDataEntity
    {
        List<Image> Images { get; set; }
    }
}
