using GuildCars.Data.Interfaces;
using GuildCars.Models.Tables;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace GuildCars.Data.ADO
{
    public class IntColorsRepoADO : IIntColorsRepo
    {

        public List<IntColors> GetIntColors()
        {
            List<IntColors> intColors = new List<IntColors>();

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                SqlCommand cmd = new SqlCommand("usp_GetIntColors", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        IntColors currentRow = new IntColors();
                        currentRow.IntColorId = (int)dr["IntColorId"];
                        currentRow.IntColorDesc = (string)dr["IntColorDesc"];
                        intColors.Add(currentRow);
                    }
                }
            }
            return intColors;
        }
    }
}