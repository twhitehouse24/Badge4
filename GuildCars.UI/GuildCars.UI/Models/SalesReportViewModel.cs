using GuildCars.Models.Queries;
using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuildCars.UI.Models
{
    public class SalesReportViewModel
    {
        public List<Users> UserList { get; set; }
        public List<Users> getSalesResults { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public IEnumerable<SelectListItem> UDDList { get; set; }

    }
}