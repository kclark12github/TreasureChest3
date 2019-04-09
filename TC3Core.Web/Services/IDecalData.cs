using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TC3Core.Domain.Classes.Stash;

namespace TC3Core.Services
{
    public interface IDecalData
    {
        IEnumerable<Decal> GetAll();
        Decal Get(Guid id);
        Decal Add(Decal decal);
        Decal Update(Decal decal);
    }
}
