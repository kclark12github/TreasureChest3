﻿using System;
using TC3Core.Domain.Classes;

namespace TC3Core.Domain.Interfaces
{
    public interface IStash : IImageEntity
    {
        bool? Cataloged { get; set; }
        DateTime? DateInventoried { get; set; }
        DateTime? DatePurchased { get; set; }
        DateTime? DateVerified { get; set; }
        Location Location { get; set; }
        Guid? LocationID { get; set; }
        string Notes { get; set; }
        decimal? Price { get; set; }
        decimal? Value { get; set; }
        bool? WishList { get; set; }
    }
}
