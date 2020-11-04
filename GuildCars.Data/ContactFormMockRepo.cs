using GuildCars.Data.Interfaces;
using GuildCars.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildCars.Data
{
    public class ContactFormMockRepo : IContactFormRepo
    {
        private static List<ContactFormViewModel> _contactForm = new List<ContactFormViewModel>();

        static ContactFormMockRepo()
        {
            _contactForm = new List<ContactFormViewModel>
            {
                new ContactFormViewModel
                {
                    Name = "Toby Whitehouse",
                    Phone = "502-555-1221",
                    Email = "twhitehouse@guildcars.com",
                    Message = "VIN # 1"
                },
                new ContactFormViewModel
                {
                    Name = "Jill White",
                    Phone = "502-555-1222",
                    Email = "jwhite@guildcars.com",
                    Message = "VIN # 2"
                },
            };
        }
        public void SubmitContactForm(ContactFormViewModel contactForm)
        {
            _contactForm.Add(contactForm);

            
        }
    }
}