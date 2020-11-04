using GuildCars.Data.Interfaces;
using GuildCars.Models.Tables;
using GuildCars.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GuildCars.Data.ADO
{
    public class ContactFormRepoADO : IContactFormRepo
    {

        public void SubmitContactForm(ContactFormViewModel contactForm)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("usp_ContactForm", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", contactForm.Name);
                if (contactForm.Phone == null)
                {
                    cmd.Parameters.AddWithValue("@Phone", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Phone", contactForm.Phone);

                }
                if (contactForm.Email == null)
                {
                    cmd.Parameters.AddWithValue("@Email", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Email", contactForm.Email);
                }
                cmd.Parameters.AddWithValue("@Message", contactForm.Message);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}