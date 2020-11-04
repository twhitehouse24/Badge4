using GuildCars.Data.ADO;
using GuildCars.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildCars.Data.Factories
{
    public class ModelRepoFactory
    {
        public static IModelRepo GetRepo()
        {
            switch (Settings.GetRepositoryType())
            {
                case "QA":
                    return new ModelMockRepo();
                case "PROD":
                    return new ModelRepoADO();
                default:
                    throw new Exception("Not a valid Repo type");
            }
    }

}
}