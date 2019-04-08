using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TC3Model.DataModel;
using TC3Model.DataModel.Classes;

namespace TreasureChest3.WPF
{
    public class DecalManager 
    {
        StashRepository<Decal> _repo;
        public DecalManager()
        {
            _repo = new StashRepository<Decal>();
        }
        //public ObservableCollection<Decal> GetDecals()
        public List<Decal> GetDecalList()
        {
            List<Decal> decalList = new List<Decal>();
            foreach (var item in _repo.All())
                decalList.Add(item);
            return decalList;
        }
        public List<Decal> GetDecals()
        {
            return (List<Decal>)_repo.AllInclude();
        }
    }
}
