using GuildCars.Data.Interfaces;
using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GuildCars.Data.ADO
{
    public class StatesRepo : IStatesRepo

    {

        public List<States> GetStates()
        {
            List<States> states = new List<States>();

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("usp_GetStates", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        States currentRow = new States();
                        currentRow.State_Abbrev = (string)dr["State_Abbrev"];
         
                        states.Add(currentRow);
                    }
                }
            }
            return states;
        }

    }
}