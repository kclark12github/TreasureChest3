using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Data.Services.Providers;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TCDomain.DataModel;
using TCDomain.DataModel.Classes;

namespace TCWebService.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TCService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TCService.svc or TCService.svc.cs at the Solution Explorer and start debugging.
    public class TCService : EntityFrameworkDataService<TCContext>, ITCService
    {

        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
            // Examples:
            config.SetEntitySetAccessRule("Decals", EntitySetRights.All);
            config.UseVerboseErrors = true;
            //config.SetServiceOperationAccessRule("*", ServiceOperationRights.All);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
        }
        public Decal GetDecal(int id)
        {
            StashRepository<Decal> repo = new StashRepository<Decal>();
            //return (Decal)repo.FindByKeyWithImages(id);
            return (Decal)repo.FindByKey(id);
        }
        public void DoWork()
        {
        }
    }
}
