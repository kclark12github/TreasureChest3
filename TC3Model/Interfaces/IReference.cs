using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TC3Model.DataModel.Classes;

namespace TC3Model.Interfaces
{
    public interface IReference
    {
        List<ReferenceImage> ReferenceImages { get; set; }
    }
}
