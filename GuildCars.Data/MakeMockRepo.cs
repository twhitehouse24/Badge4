using System;
using System.Collections.Generic;
using GuildCars.Data.Interfaces;
using GuildCars.Models.Tables;

namespace GuildCars.Data.Factories
{
    public class MakeMockRepo : IMakeRepo
    {
        public static List<Make> _makes = new List<Make>();

        static MakeMockRepo()
        {
            _makes = new List<Make>
            {
                new Make
                {
                    MakeId = 1,
                    MakeName = "Ford",
                    DateAdded = DateTime.Now,
                    UpdatedBy = "twhitehouse"
                },
                new Make
                {
                    MakeId = 2,
                    MakeName = "Chevrolet",
                    DateAdded = DateTime.Now,
                    UpdatedBy = "twhitehouse"
                },
                new Make
                {
                    MakeId = 3,
                    MakeName = "Toyota",
                    DateAdded = DateTime.Now,
                    UpdatedBy = "twhitehouse"
                },
            };
        }

        public List<Mods> GetFilteredModels(string id)
        {
            throw new NotImplementedException();
        }

        public List<Make> GetMakes()
        {
            return _makes;

        }

        public void Insert(Make make)
        {
            int nextId = _makes.Count;
            make.MakeId = nextId;
            make.DateAdded = DateTime.Now;

            _makes.Add(make);
        }
    }
}