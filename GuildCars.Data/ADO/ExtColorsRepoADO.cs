using GuildCars.Data.Interfaces;
using GuildCars.Models.Tables;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace GuildCars.Data.ADO
{
    public class ExtColorsRepoADO : IExtColorsRepo

    {

        public List<ExtColors> GetExtColors()
        {
            List<ExtColors> extColors = new List<ExtColors>();

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("usp_GetExtColors", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        ExtColors currentRow = new ExtColors();
                        currentRow.ExtColorId = (int)dr["ExtColorId"];
                        currentRow.ExtColorDesc = (string)dr["ExtColorDesc"];
                        extColors.Add(currentRow);
                    }
                }
            }
            return extColors;
        }
    }
}