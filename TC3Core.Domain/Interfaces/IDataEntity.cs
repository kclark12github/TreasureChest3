using System;

namespace TC3Core.Domain.Interfaces
{
    public interface IDataEntity : IEntity
    {
        int? OID { get; }
        DateTime DateCreated { get; set; }
        DateTime DateModified { get; set; }
    }
}
