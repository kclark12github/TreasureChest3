﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using TC3Core.Domain.Annotations;

namespace TC3Core.Domain.Classes.Stash
{
    [TableDescription("Inventory of Finishing Products (i.e. Paint, Brushes, etc.).")]
    public partial class FinishingProduct : HobbyBase
    {
        #region "Locals"
        private double? mCount = null;
        #endregion

        [ColumnDescription("Count of this item.")]
        public double? Count
        {
            get => mCount;
            set { SetProperty(ref mCount, value); }
        }
    }
}
