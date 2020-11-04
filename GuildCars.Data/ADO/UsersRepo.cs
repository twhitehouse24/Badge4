using GuildCars.Data.Interfaces;
using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GuildCars.Data
{
    public class UsersRepo : IUserRepo
    {
        public Users GetUserById(string id)
        {
            Users items = null;

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("usp_GetUserById", cn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        items = new Users();

                        items.FirstName = (string)dr["FirstName"];
                        items.LastName = (string)dr["LastName"];
                        items.Email = (string)dr["Email"];
                        items.RoleName = (string)dr["Name"];
                        items.RoleId = (string)dr["RoleId"];
                        items.UserId = (string)dr["UserId"];
                    }
                }
            }
            return items;
        }

        public List<Users> GetUsers()
        {
            //throw new NotImplementedException();

            List<Users> users = new List<Users>();


            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;


                SqlCommand cmd = new SqlCommand("usp_GetUsers", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Users currentRow = new Users();
                        currentRow.FirstName = (string)dr["FirstName"];
                        currentRow.LastName = (string)dr["LastName"];
                        currentRow.Email = (string)dr["Email"];
                        currentRow.RoleName = (string)dr["Role"];
                        currentRow.UserId = (string)dr["UserId"];

                        users.Add(currentRow);
                    }
                }
            }
            return users;
        }

        public void AddNewUser(Users users)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("usp_AddUsers", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                cmd.Parameters.AddWithValue("@FName", users.FirstName);
                cmd.Parameters.AddWithValue("@LNAme", users.LastName);
                cmd.Parameters.AddWithValue("@Email", users.Email);
                cmd.Parameters.AddWithValue("@RoleId", users.RoleId);

                cmd.ExecuteNonQuery();

            }
        }

        public void UpdateUser(Users users)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("usp_UpdateUser", cn);
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;


                cn.Open();
                cmd.Parameters.AddWithValue("@UserId", users.UserId);
                cmd.Parameters.AddWithValue("@FName", users.FirstName);
                cmd.Parameters.AddWithValue("@LNAme", users.LastName);
                cmd.Parameters.AddWithValue("@Email", users.Email);
                cmd.Parameters.AddWithValue("@RoleId", users.RoleId);

                cmd.ExecuteNonQuery();

            }
        }
    }
}