using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TCDomain.DataModel.Classes;

namespace TCWebService.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITCService" in both code and config file together.
    [ServiceContract]
    public interface ITCService
    {
        [OperationContract]
        Decal GetDecal(int id);
        [OperationContract]
        void DoWork();
    }
}
