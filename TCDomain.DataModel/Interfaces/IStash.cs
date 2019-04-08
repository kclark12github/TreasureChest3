using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCDomain.DataModel.Classes;

namespace TCDomain.DataModel.Interfaces
{
    public interface IStash
    {
        bool? Cataloged { get; set; }
        DateTime? DateInventoried { get; set; }
        DateTime? DatePurchased { get; set; }
        DateTime? DateVerified { get; set; }
        List<Image> Images { get; set; }
        Location Location { get; set; }
        string Notes { get; set; }
        decimal? Price { get; set; }
        decimal? Value { get; set; }
        bool? WishList { get; set; }
    }
}
