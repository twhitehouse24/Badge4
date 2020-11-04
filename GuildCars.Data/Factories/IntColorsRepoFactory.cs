using GuildCars.Data.Interfaces;
using GuildCars.Data.ADO;
using System;

namespace GuildCars.Data.Factories
{
    public class IntColorsRepoFactory
    {
        public static IIntColorsRepo GetRepo()
        {
            switch (Settings.GetRepositoryType())
            {
                case "QA":
                    return new IntColorsMockRepo();
                case "PROD":
                    return new IntColorsRepoADO();
                default:
                    throw new Exception("Not a valid Repo type");
            }
        }

    }
}
