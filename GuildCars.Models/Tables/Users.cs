using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildCars.Models.Tables
{
    public class Users
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string Password { get; set; }
        public string Id { get; set; }
        public string UserName { get; set; }
        public decimal TotalSales { get; set; }
        public int CountOfCarsSold { get; set; }

    }
}