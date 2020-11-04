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
    public class ModelRepoADO : IModelRepo
    {
        public List<Mods> GetModels()
        {
            List<Mods> mods = new List<Mods>();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("usp_GetModels", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Mods currentRow = new Mods();
                        currentRow.ModelId = (int)dr["ModelId"];
                        currentRow.ModelName = (string)dr["ModelName"];
                        currentRow.MakeId = (int)dr["MakeId"];
                        currentRow.MakeName = (string)dr["MakeName"];
                        currentRow.DateAdded = (DateTime)dr["DateAdded"];
                        currentRow.UpdatedBy = (string)dr["UpdatedBy"];
                        mods.Add(currentRow);
                    }
                }
            }
            return mods;
        }
        public List<Mods> GetFilteredModels(string maketofilter)
        {
            List<Mods> mods = new List<Mods>();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;


                SqlCommand cmd = new SqlCommand("usp_GetFilteredModels", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MakeId", maketofilter);

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Mods currentRow = new Mods();
                        currentRow.ModelId = (int)dr["ModelId"];
                        currentRow.MakeName = (string)dr["MakeName"];
                        currentRow.ModelName = (string)dr["ModelName"];
                        mods.Add(currentRow);
                    }
                }
            }
            if(maketofilter == "0")
            {
                return mods;
            }
            else
            {
            var newModsList = (from m in mods
                               select new Mods
                               {
                                   ModelId = m.ModelId,
                                   ModelName = m.ModelName,
                                   MakeName = m.MakeName
                               }).ToList();


            return newModsList;
 }
        }

        public void Insert(Mods mods)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("usp_AddModel", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MakeId", mods.MakeId);
                cmd.Parameters.AddWithValue("@ModelName", mods.ModelName);
                cmd.Parameters.AddWithValue("@MakeName", mods.MakeName);
                cn.Open();
                
                cmd.ExecuteNonQuery();

            }
        }

  
    }
}