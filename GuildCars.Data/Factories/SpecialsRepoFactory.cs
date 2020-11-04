using GuildCars.Data.ADO;
using GuildCars.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildCars.Data.Factories
{
    public class SpecialsRepoFactory
    {
        public static ISpecialsRepo GetRepo()
        {
            switch (Settings.GetRepositoryType())
            {
                case "QA":
                    return new SpecialsMockRepo();
                case "PROD":
                    return new SpecialsRepoADO();
                default:
                    throw new Exception("Not a valid Repo type");
            }
        }
    }
}



