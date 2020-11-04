using GuildCars.Data.ADO;
using GuildCars.Data.Interfaces;
using System;


namespace GuildCars.Data.Factories
{
    public class ContactFormRepoFactory
    {
        public static IContactFormRepo GetRepo()
        {
            switch (Settings.GetRepositoryType())
            {
                case "QA":
                    return new ContactFormMockRepo();
                case "PROD":
                    return new ContactFormRepoADO();
                default:
                    throw new Exception("Not a valid Repo type");
            }
        }
    }
}