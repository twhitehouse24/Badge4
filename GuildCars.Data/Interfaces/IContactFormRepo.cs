

using GuildCars.Models.ViewModels;

namespace GuildCars.Data.Interfaces
{
    public interface IContactFormRepo
    {

        void SubmitContactForm(ContactFormViewModel contactForm);
    }
}