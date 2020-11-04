﻿using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildCars.Data.Interfaces
{
    public interface ISpecialsRepo
    {
        List<Specials> GetSpecials();
        void AddSpecial(Specials special);
        void DeleteSpecial(string id);
    }
}
