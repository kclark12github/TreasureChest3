using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TC3Model;

namespace TC3ViewModel
{
    public class ViewModelBase : EntityBase
    {
        public ViewModelBase()
        {
            IsCanceled = false;
        }
        public bool IsCanceled { get; set; }
    }
}
