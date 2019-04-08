using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using TC3Core.Domain.Annotations;
using TC3Core.Domain.Interfaces;

namespace TC3Core.Domain.Classes.Stash
{
    [TableDescription("TV Episode Library")]
    public partial class Episode : VideoBase
    {
        #region "Locals"
        private string mNumber = string.Empty;
        private string mSeries = string.Empty;
        #endregion

        [ColumnDescription("Name of this TV Series.")]
        [StringLength(80)]
        public string Series
        {
            get => mSeries;
            set { SetProperty(ref mSeries, value); }
        }

        [ColumnDescription("Episode number.")]
        [StringLength(32)]
        public string Number
        {
            get => mNumber;
            set { SetProperty(ref mNumber, value); }
        }
    }
}
