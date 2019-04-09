using System;
using System.Collections.Generic;
using System.Linq;
using TC3Core.Domain.Classes.Stash;

namespace TC3Core.Services
{
    public class MemoryDecalData : IDecalData
    {
        List<Decal> _decals;
        public MemoryDecalData()
        {
            _decals = new List<Decal> {
                //TODO: Populate with meaningful data
                new Decal {ID = Guid.NewGuid(),Cataloged = null,DateInventoried = null,DatePurchased = null,DateVerified = null,Location = null,Notes = string.Empty,Price = null,Value = null,WishList = null},
                new Decal {ID = Guid.NewGuid(), Cataloged = null,DateInventoried = null,DatePurchased = null,DateVerified = null,Location = null,Notes = string.Empty,Price = null,Value = null,WishList = null},
                new Decal {ID = Guid.NewGuid(), Cataloged = null,DateInventoried = null,DatePurchased = null,DateVerified = null,Location = null,Notes = string.Empty,Price = null,Value = null,WishList = null}
            };
        }
        public Decal Add(Decal Decal)
        {
            Decal.ID = Guid.NewGuid();
            _decals.Add(Decal);
            return Decal;
        }
        public Decal Get(Guid id)
        {
            return _decals.FirstOrDefault(r => r.ID == id);
        }
        public IEnumerable<Decal> GetAll()
        {
            return _decals.OrderBy(r => r.Name);
        }
        public Decal Update(Decal decal)
        {
            //TODO: Implement Memory incarnation of Update
            throw new NotImplementedException();
        }
    }
}
