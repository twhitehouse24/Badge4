using GuildCars.Data.Interfaces;
using GuildCars.Data.ADO;
using System;


namespace GuildCars.Data.Factories
{
    public class ExtColorsRepoFactory
    {

        public static IExtColorsRepo GetRepo()
        {
            switch (Settings.GetRepositoryType())
            {
                case "QA":
                    return new ExtColorsMockRepo();
                case "PROD":
                    return new ExtColorsRepoADO();
                default:
                    throw new Exception("Not a valid Repo type");
            }
        }
    }
}