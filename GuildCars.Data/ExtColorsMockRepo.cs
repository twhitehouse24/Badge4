using System;
using System.Collections.Generic;
using GuildCars.Data.Interfaces;
using GuildCars.Models.Tables;


namespace GuildCars.Data
{
    public class ExtColorsMockRepo : IExtColorsRepo
    {
        private static List<ExtColors> _extColors = new List<ExtColors>();

        static ExtColorsMockRepo()
        {
            _extColors = new List<ExtColors>
            {
                new ExtColors
                {
                    ExtColorId =0,
                    ExtColorDesc = "White",
                },
                new ExtColors
                {
                    ExtColorId = 1,
                    ExtColorDesc = "Black",
                },
                new ExtColors
                {
                    ExtColorId = 2,
                    ExtColorDesc = "Tan",
                },
                new ExtColors
                {
                    ExtColorId = 3,
                    ExtColorDesc = "Gold",
                },
                new ExtColors
                {
                    ExtColorId = 4,
                    ExtColorDesc = "Red",
                },
                new ExtColors
                {
                    ExtColorId = 5,
                    ExtColorDesc = "Blue",
                },
                new ExtColors
                {
                    ExtColorId = 6,
                    ExtColorDesc = "Green",
                },
                new ExtColors
                {
                    ExtColorId = 7,
                    ExtColorDesc = "Orange",
                },
                new ExtColors
                {
                    ExtColorId = 8,
                    ExtColorDesc = "Silver",
                },
                new ExtColors
                {
                    ExtColorId = 9,
                    ExtColorDesc = "Brown",
                },
            };
        }
        public List<ExtColors> GetExtColors()
        {
            return _extColors;
        }
    }
}