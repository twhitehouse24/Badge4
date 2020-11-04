using GuildCars.Data.ADO;
using GuildCars.Data.Interfaces;
using System;

namespace GuildCars.Data.Factories
{
    public class BodyStyleFactory
    {
        public static IBodyStylesMockRepo GetRepo()
        {
            switch (Settings.GetRepositoryType())
            {
                case "QA":
                    return new BodyStyleMockRepo();
                case "PROD":
                    return new BodyStylesRepoADO();
                default:
                    throw new Exception("Not a valid Repo type");
            }
        }
    }
}