using GuildCars.Data.Interfaces;
using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildCars.Data
{
    public class StatesMockRepo : IStatesRepo
    {

        public static List<States> _models = new List<States>();
        
        static StatesMockRepo()
        {
            _models = new List<States>
            {
                new States
                {
                St_Id = 0,
                State_Abbrev = "AL",
                State_Name = "Alabama"
                },

               new States
                {
                St_Id = 1,
                State_Abbrev = "AK",
                State_Name = "Alaska"
                },
                new States
                {
                St_Id = 2,
                State_Abbrev = "AZ",
                State_Name = "Arizona"
                },
                new States
                {
                St_Id = 3,
                State_Abbrev = "AR",
                State_Name = "Arkansas"
                },
               new States
                {
                St_Id = 4,
                State_Abbrev = "CA",
                State_Name = "California"
                },
                new States
                {
                St_Id = 5,
                State_Abbrev = "CO",
                State_Name = "Colorado"
                },
                new States
                {
                St_Id = 6,
                State_Abbrev = "CT",
                State_Name = "Connecticut"
                },
                new States
               {
               St_Id = 7,
               State_Abbrev = "DE",
               State_Name = "Delaware"
               },
                new States
                {
                St_Id = 8,
                State_Abbrev = "FL",
                State_Name = "Florida"
                },
                new States
                {
                St_Id = 9,
                State_Abbrev = "GA",
                State_Name = "Georgia"
                },
                new States
                {
                St_Id = 10,
                State_Abbrev = "HI",
                State_Name = "Hawaii"
                },
                new States
                {
                St_Id = 11,
                State_Abbrev = "ID",
                State_Name = "Idaho"
                },
                new States
                {
                St_Id = 12,
                State_Abbrev = "IL",
                State_Name = "Illinois"
                },
                new States
                {
                St_Id = 13,
                State_Abbrev = "IN",
                State_Name = "Indiana"
                },
                new States
                {
                St_Id = 14,
                State_Abbrev = "IA",
                State_Name = "Iowa"
                },
                new States
                {
                St_Id = 15,
                State_Abbrev = "KS",
                State_Name = "Kansas"
                },
                new States
                {
                St_Id = 16,
                State_Abbrev = "KY",
                State_Name = "Kentucky"
                },
                new States
                {
                St_Id = 17,
                State_Abbrev = "LA",
                State_Name = "Louisiana"
                },
                new States
                {
                St_Id = 18,
                State_Abbrev = "ME",
                State_Name = "Maine"
                },
                new States
                {
                St_Id = 19,
                State_Abbrev = "MD",
                State_Name = "Maryland"
                },
                new States
                {
                St_Id = 20,
                State_Abbrev = "MA",
                State_Name = "Massachusetts"
                },
                new States
                {
                St_Id = 21,
                State_Abbrev = "MI",
                State_Name = "Michigan"
                },
                new States
                {
                St_Id = 22,
                State_Abbrev = "MN",
                State_Name = "Minnesota"
                },
                new States
                {
                St_Id = 23,
                State_Abbrev = "MS",
                State_Name = "Mississippi"
                },
                new States
                {
                St_Id = 24,
                State_Abbrev = "MO",
                State_Name = "Missouri"
                },
                new States
                {
                St_Id = 25,
                State_Abbrev = "MT",
                State_Name = "Montana"
                },
                new States
                {
                St_Id = 26,
                State_Abbrev = "NE",
                State_Name = "Nebraska"
                },
               new States
                {
                St_Id = 27,
                State_Abbrev = "NV",
                State_Name = "Nevada"
                },
                new States
                {
                St_Id = 28,
                State_Abbrev = "NH",
                State_Name = "New Hampshire"
                },
                new States
                {
                St_Id = 29,
                State_Abbrev = "NJ",
                State_Name = "New Jersey"
                },
                new States
                {
                St_Id = 30,
                State_Abbrev = "NM",
                State_Name = "New Mexico"
                },
                new States
                {
                St_Id = 31,
                State_Abbrev = "NY",
                State_Name = "New York"
                },
                new States
                {
                St_Id = 32,
                State_Abbrev = "NC",
                State_Name = "North Carolina"
                },
                new States
                {
                St_Id = 33,
                State_Abbrev = "ND",
                State_Name = "North Dakota"
                },
                new States
                {
                St_Id = 34,
                State_Abbrev = "OH",
                State_Name = "Ohio"
                },
                new States
                {
                St_Id = 35,
                State_Abbrev = "OK",
                State_Name = "Oklahoma"
                },
                new States
                {
                St_Id = 36,
                State_Abbrev = "OR",
                State_Name = "Oregon"
                },
               new States
                {
                St_Id = 37,
                State_Abbrev = "PA",
                State_Name = "Pennsylvania"
                },
                new States
                {
                St_Id = 38,
                State_Abbrev = "RI",
                State_Name = "Rhode Island"
                },
                new States
                {
                St_Id = 39,
                State_Abbrev = "SC",
                State_Name = "South Carolina"
                },
                new States
                {                St_Id = 40,
                State_Abbrev = "SD",
                State_Name = "South Dakota"
                },
                new States
                {
                St_Id = 41,
                State_Abbrev = "TN",
                State_Name = "Tennessee"
                },
                new States
                {
                St_Id = 42,
                State_Abbrev = "TX",
                State_Name = "Texas"
                },
                new States
                {
                St_Id = 43,
                State_Abbrev = "UT",
                State_Name = "Utah"
                },
                new States
                {
                St_Id = 44,
                State_Abbrev = "VT",
                State_Name = "Vermont"
                },
               new States
                {
                St_Id = 45,
                State_Abbrev = "VA",
                State_Name = "Virginia"
                },
                new States
                {
                St_Id = 46,
                State_Abbrev = "WA",
                State_Name = "Washington"
                },
                new States
                {
                St_Id = 47,
                State_Abbrev = "WV",
                State_Name = "West Virginia"
                },
                new States
                {
                St_Id = 48,
                State_Abbrev = "WI",
                State_Name = "Wisconsin"
                },
                new States
                {
                St_Id = 49,
                State_Abbrev = "WY",
                State_Name = "Wyoming"
                }
            };
        }
        public List<States> GetStates()
        {
            return _models;
        }
        
    }
}
