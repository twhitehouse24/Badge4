using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildCars.Data.Interfaces
{
    public interface IModelRepo
    {
        List<Mods> GetModels();
        void Insert(Mods mods);
        List<Mods> GetFilteredModels(string id);
    }
}
