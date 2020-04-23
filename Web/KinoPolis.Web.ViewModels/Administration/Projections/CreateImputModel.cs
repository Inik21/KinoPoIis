using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KinoPolis.Web.ViewModels.Administration.Projections
{
    public class CreateImputModel
    {
        public string NameOfFilm { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[0-9: ]*$", ErrorMessage = "The field should contain only numbers")]
        public int Price { get; set; }

        [Required(ErrorMessage = "The field is required")]
        public DateTime Time { get; set; }

        [Required(ErrorMessage = "The field is required")]
        public string CinemaName { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "The field should contain only numbers")]
        public int NumberOfHall { get; set; }
    }
}
