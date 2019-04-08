using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC3Model.Interfaces
{
    public interface IDataEntity
    {
        int ID { get; set; }
        int? OID { get; set; }
        Byte[] RowID { get; set; }
        DateTime DateCreated { get; set; }
        DateTime DateModified { get; set; }
        bool IsDirty { get; set; }
    }
}
