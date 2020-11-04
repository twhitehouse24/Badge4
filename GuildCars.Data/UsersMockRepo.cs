using GuildCars.Data.Interfaces;
using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GuildCars.Data
{
    public class UsersMockRepo : IUserRepo

    {
        private static List<Users> _users = new List<Users>();

        static UsersMockRepo()
        {
            _users = new List<Users>
            {
                new Users
                {
                    Id = "1",
                    UserId = "15899470-9b85-433f-bbda-3f5adf749256",
                    FirstName = "Toby",
                    LastName = "Whitehouse",
                    Email = "twhitehouse@guildcars.com",
                    RoleId = "1",
                    RoleName = "Admin",
                    UserName = "twhitehouse",
                    Password = "AABxw+8sA95f8QjcUb4agsKYxKKLkTNtCV1esr19wvlaEdYOo8NWKbkpF38S/Ar3IA=="

                },
                new Users
                {
                    Id = "2",
                    UserId = "b7fb4b7b-15c8-40cb-8eeb-608cf8f84fc7",
                    FirstName = "Ted",
                    LastName = "Williams",
                    Email = "twilliams@guildcars.com",
                    RoleId = "4",
                    RoleName = "Sales",
                    UserName = "twilliams",
                    Password = "AFUBj4bNJcOpRRabOKYJuvwoqt2ZSl4EXjNuATtC+vvXAMe1/HBTGi5ynDQKEBjb7w=="
                },
                new Users
                {
                    Id = "3",
                    UserId = "b9a6ed1f-06eb-41b8-bb5d-8b01d7f99bd9",
                    FirstName = "Jill",
                    LastName = "White",
                    Email = "jwhite@guildcars.com",
                    RoleId = "4",
                    RoleName = "Sales",
                    UserName = "jwhite",
                    Password = "AJyCz5WMF+shfpCO/L7xlewwIproO9ZdpwHhVeg+UcLrO/InY4hG5ZEeDjgc0bS8sw=="
                },
            };
        }
        public List<Users> GetUsers()
        {
            return _users;
        }
        public List<Users> GetSalesUsers()
        {
            List<Users> users = GetUsers();
            List<Users> _salesUsers = users.FindAll(u => u.RoleId == "4");
            return _salesUsers;
        }
        public void AddNewUser(Users users)
        {
            throw new NotImplementedException();
        }


        public void UpdateUser(Users users)
        {
            Users user = _users.FirstOrDefault(u => u.UserId == users.UserId);
            if (user.RoleId == "1")
            {
                user.RoleName = "Admin";
            }
            else
            {
                user.RoleName = "Sales";
            }

            int index = _users.FindIndex(u => u.UserId == users.UserId);
            _users.RemoveAt(index);

            _users.Insert(index, user);




        }
        public Users GetUserById(string id)
        {
            Users user = _users.FirstOrDefault(u => u.UserId == id);
            return user;
        }
    }


}