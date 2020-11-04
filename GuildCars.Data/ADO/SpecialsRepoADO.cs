using GuildCars.Data.Interfaces;
using GuildCars.Models.Queries;
using GuildCars.Models.Tables;
using GuildCars.Models.ViewModels;
using GuildCars.UI.Models.Ajax;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace GuildCars.Data.ADO
{
    public class SpecialsRepoADO : ISpecialsRepo
    {
        public List<Specials> GetSpecials()
        {
            List<Specials> specials = new List<Specials>();
            using (System.Data.SqlClient.SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("usp_GetSpecials", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Specials currentRow = new Specials();
                        currentRow.ID = (int)dr["ID"];
                        currentRow.Title = (string)dr["Title"];
                        currentRow.Description = (string)dr["Description"];
                        currentRow.ImageFileName = (string)dr["ImageFileName"];
                        specials.Add(currentRow);
                    }
                }
            }
            return specials;
        }
        public void AddSpecial(Specials model)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("usp_AddSpecial", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                cmd.Parameters.AddWithValue("@Title", model.Title);
                cmd.Parameters.AddWithValue("@Description", model.Description);
                cmd.Parameters.AddWithValue("@ImageFileName", model.ImageFileName);

                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteSpecial(string id)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                SqlCommand cmd = new SqlCommand("usp_DeleteSpecial", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
       

    }
}