using GuildCars.Data.ADO;
using GuildCars.Data.Interfaces;
using System;

namespace GuildCars.Data.Factories
{
    public class MakeRepoFactory
    {
        public static IMakeRepo GetRepo()
        {
            switch (Settings.GetRepositoryType())
            {
                case "QA":
                    return new MakeMockRepo();
                case "PROD":
                    return new MakeRepoADO();
                default:
                    throw new Exception("Not a valid Repo type");
            }
    }

}
}