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
    public class MakeRepoADO : IMakeRepo

    {

        public List<Make> GetMakes()
        {
            List<Make> makes = new List<Make>();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;


                SqlCommand cmd = new SqlCommand("usp_GetMakes", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Make currentRow = new Make();
                        currentRow.MakeId = (int)dr["MakeId"];
                        currentRow.MakeName = (string)dr["MakeName"];
                        currentRow.DateAdded = (DateTime)dr["DateAdded"];
                        currentRow.UpdatedBy = (string)dr["UpdatedBy"];
                        makes.Add(currentRow);
                    }
                }
            }
            return makes;
        }

        public void Insert(Make make)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("usp_AddMake", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MakeName", make.MakeName);
                cn.Open();
                
                cmd.ExecuteNonQuery();

            }
        }

  
    }
}