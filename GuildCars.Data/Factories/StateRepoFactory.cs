using GuildCars.Data.ADO;
using GuildCars.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildCars.Data.Factories
{
    public class StateRepoFactory
    {
        public static IStatesRepo GetRepo()
        {
            switch (Settings.GetRepositoryType())
            {
                case "QA":
                    return new StatesRepo();
                case "PROD":
                    return new StatesRepo();
                default:
                    throw new Exception("Not a valid Repo type");
            }
        }
    }
}