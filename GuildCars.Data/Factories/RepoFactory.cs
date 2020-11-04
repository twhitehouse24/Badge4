using GuildCars.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace GuildCars.Data
{
    public class RepoFactory
    {

        public static ICarRepository GetRepo()
        {
            switch (Settings.GetRepositoryType())
            {
                case "QA":
                    return new CarMockRepo();
                case "PROD":
                    return new CarRepoADO();
                default:
                    throw new Exception("Not a valid Repo type");
            }
            
        }

    }
}