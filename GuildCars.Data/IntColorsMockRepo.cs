using System;
using System.Collections.Generic;
using GuildCars.Data.Interfaces;
using GuildCars.Models.Tables;

namespace GuildCars.Data
{
    public class IntColorsMockRepo : IIntColorsRepo

    {
        private static List<IntColors> _intColors = new List<IntColors>();

        static IntColorsMockRepo()
        {
            _intColors = new List<IntColors>
            {
                new IntColors
                {
                    IntColorId = 1,
                    IntColorDesc = "Grey",
                },
                new IntColors
                {
                    IntColorId = 2,
                    IntColorDesc = "Black",
                },
                new IntColors
                {
                    IntColorId = 3,
                    IntColorDesc = "White",
                },
                new IntColors
                {
                    IntColorId = 4,
                    IntColorDesc = "Tan",
                },
                new IntColors
                {
                    IntColorId = 5,
                    IntColorDesc = "Beige",
                },
                new IntColors
                {
                    IntColorId = 6,
                    IntColorDesc = "Maroon",
                },
            };
        }
        public List<IntColors> GetIntColors()
        {
            return _intColors;
        }
    }
}