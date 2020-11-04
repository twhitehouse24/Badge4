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
    public class BodyStylesRepoADO : IBodyStylesMockRepo

    {
        public List<BodyStyles> GetBodyStyles()
        {
            List<BodyStyles> bodyStyles = new List<BodyStyles>();

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("usp_GetBodyStyles", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        BodyStyles currentRow = new BodyStyles();
                        currentRow.BodyStyleId = (int)dr["BodyStyleId"];
                        currentRow.BodyStyleDesc = (string)dr["BodyStyleDesc"];
                        bodyStyles.Add(currentRow);
                    }
                }
            }
            return bodyStyles;
        }
    }
}