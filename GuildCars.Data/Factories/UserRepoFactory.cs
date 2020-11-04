using GuildCars.Data.ADO;
using GuildCars.Data.Interfaces;
using System;

namespace GuildCars.Data.Factories
{
    public class UserRepoFactory
    {
        public static IUserRepo GetRepo()
        {
            switch (Settings.GetRepositoryType())
            {
                case "QA":
                    return new UsersMockRepo();
                case "PROD":
                    return new UsersRepo();
                default:
                    throw new Exception("Not a valid Repo type");
            }
        }


    }
}