using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;


namespace GuildCars.UI.Models
{
    public class SpecialsViewModel
    {

        public List<Specials> Specials { get; set; }
        public Specials specials { get; set; }


        public string StartDate { get; set; }
        public string EndDate { get; set; }

        [Required(ErrorMessage = ("Please enter a title"))]
        public string Title { get; set; }

        [Required(ErrorMessage = ("Please enter a description"))]
        public string Description { get; set; }

        
        public string ImageFileName { get; set; }

        public IEnumerable<SelectListItem> ddImageFileName { get; set; }

    }
}