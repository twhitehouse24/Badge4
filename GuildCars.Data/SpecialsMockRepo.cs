using GuildCars.Data.Interfaces;
using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;


namespace GuildCars.Data
{
    public class SpecialsMockRepo : ISpecialsRepo
    {
        private static List<Specials> _specials = new List<Specials>();

        static SpecialsMockRepo()
        {
            _specials = new List<Specials>
            {
                new Specials
                {
                    ID = 1,
                    Title = "Special 1",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod " +
                    "tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud " +
                    "exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor " +
                    "in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur " +
                    "sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est " +
                    "laborum.",

                },
                new Specials
                {
                    ID = 2,
                    Title = "Special 2",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod " +
                    "tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud " +
                    "exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor " +
                    "in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur " +
                    "sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est " +
                    "laborum.",

                },
                new Specials
                {
                    ID = 3,
                    Title = "Special 3",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod " +
                    "tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud " +
                    "exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor " +
                    "in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur " +
                    "sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est " +
                    "laborum.",

                },
                new Specials
                {
                    ID = 4,
                    Title = "Special 4",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod " +
                    "tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud " +
                    "exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor " +
                    "in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur " +
                    "sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est " +
                    "laborum.",

                },
                new Specials
                {
                    ID = 5,
                    Title = "Special 5",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod " +
                    "tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud " +
                    "exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor " +
                    "in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur " +
                    "sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est " +
                    "laborum.",

                },
                new Specials
                {
                    ID = 6,
                    Title = "Special 6",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod " +
                    "tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud " +
                    "exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor " +
                    "in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur " +
                    "sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est " +
                    "laborum.",

                },
                new Specials
                {
                    ID = 7,
                    Title = "Special 7",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod " +
                    "tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud " +
                    "exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor " +
                    "in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur " +
                    "sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est " +
                    "laborum.",

                },
                new Specials
                {
                    ID = 8,
                    Title = "Special 8",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod " +
                    "tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud " +
                    "exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor " +
                    "in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur " +
                    "sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est " +
                    "laborum.",

                },
            };

        }
        public List<Specials> GetSpecials()
        {
            return _specials;
        }
        public void AddSpecial(Specials special)
        {
            _specials.Add(special);
        }

        public void DeleteSpecial(string id)
        {
            Specials specials = _specials.Find(s => s.ID == int.Parse(id));
             _specials.Remove(specials);
        }
    }
}