using GuildCars.Data.Interfaces;
using GuildCars.Models.Tables;
using System.Collections.Generic;

namespace GuildCars.Data
{
    public class BodyStyleMockRepo : IBodyStylesMockRepo
    {
        private static List<BodyStyles> _bodyStyles = new List<BodyStyles>();

        static BodyStyleMockRepo()
        {
            _bodyStyles = new List<BodyStyles>
            {
                new BodyStyles
                {
                    BodyStyleId = 0,
                    BodyStyleDesc = "Car",
                },
                new BodyStyles
                {
                    BodyStyleId = 1,
                    BodyStyleDesc = "SUV",
                },
                new BodyStyles
                {
                    BodyStyleId = 2,
                    BodyStyleDesc = "Truck",
                },
                new BodyStyles
                {
                    BodyStyleId = 3,
                    BodyStyleDesc = "Van",
                },
            };
        }
        public List<BodyStyles> GetBodyStyles()
        {
            return _bodyStyles;
        }
    }
}