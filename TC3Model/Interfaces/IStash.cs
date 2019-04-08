using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TC3Model.DataModel.Classes;

namespace TC3Model.Interfaces
{
    public interface IStash
    {
        bool? Cataloged { get; set; }
        DateTime? DateInventoried { get; set; }
        DateTime? DatePurchased { get; set; }
        DateTime? DateVerified { get; set; }
        //List<Image> Images { get; set; }
        Location Location { get; set; }
        int? LocationID { get; set; }
        string Notes { get; set; }
        decimal? Price { get; set; }
        decimal? Value { get; set; }
        bool? WishList { get; set; }
        List<StashImage> StashImages { get; set; }
    }
}
