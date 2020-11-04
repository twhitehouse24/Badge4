using System;
using System.Collections.Generic;
using GuildCars.Data.Interfaces;
using GuildCars.Models.Tables;

namespace GuildCars.Data.Factories
{
    public class ModelMockRepo : IModelRepo
    {
        public static List<Mods> _models = new List<Mods>();

        static ModelMockRepo()
        {
            _models = new List<Mods>
            {
                new Mods
                {
                    ModelId = 1,
                    ModelName = "Escort",
                    MakeName = "Ford",
                    DateAdded = DateTime.Now,
                    UpdatedBy = "twhitehouse"
                },
                new Mods
                {
                    ModelId = 2,
                    ModelName = "Camry",
                    MakeName = "Toyota",
                    DateAdded = DateTime.Now,
                    UpdatedBy = "twhitehouse"
                },
                new Mods
                {
                    ModelId = 3,
                    ModelName = "Corolloa",
                    MakeName = "Toyota",
                    DateAdded = DateTime.Now,
                    UpdatedBy = "twhitehouse"
                },
                new Mods
                {
                    ModelId = 4,
                    ModelName = "Expedition",
                    MakeName = "Ford",
                    DateAdded = DateTime.Now,
                    UpdatedBy = "twhitehouse"
                },
            };
        }

        public List<Mods> GetFilteredModels(string id)
        {
            throw new NotImplementedException();
        }

        public List<Mods> GetModels()
        {
            return _models;
        }

        public void Insert(Mods mods)
        {
            int nextId = _models.Count;
            mods.ModelId = nextId;
            mods.DateAdded = DateTime.Now;

            _models.Add(mods);
        }
    }
}


