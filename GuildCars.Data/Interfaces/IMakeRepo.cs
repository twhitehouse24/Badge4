using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildCars.Data.Interfaces
{
    public interface IMakeRepo
    {
        List<Make> GetMakes();
        void Insert(Make make);
        

    }
}