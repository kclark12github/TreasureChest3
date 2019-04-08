using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using TC3Core.Domain.Annotations;

namespace TC3Core.Domain.Classes.Stash
{
    [TableDescription("Collection of Rockets.")]
    public partial class Rocket : KitBase
    {
    }
}
