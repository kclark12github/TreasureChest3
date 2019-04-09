using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TC3Core.Data;
using TC3Core.Domain.Classes.Stash;

namespace TC3Core.Services
{
    public class SqlDecalData : IDecalData
    {
        //private List<Decal>_decals;
        private TC3DbContext _context;
        public SqlDecalData(TC3DbContext context)
        {
            _context = context;
        }
        public Decal Add(Decal decal)
        {
            _context.Decals.Add(decal);
            _context.SaveChanges();
            return decal;
        }
        public Decal Get(Guid id)
        {
            return _context.Decals.FirstOrDefault(r => r.ID == id);
        }
        public IEnumerable<Decal> GetAll()
        {
            //return _context.Decals.OrderBy(r => r.AlphaSort);
            return _context.Decals;
        }
        public Decal Update(Decal decal)
        {
            _context.Attach(decal).State = EntityState.Modified;
            _context.SaveChanges();
            return decal;
        }
    }
}
