using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KinoPolis.Web.ViewModels.Administration.Halls
{
    public class CreateInputModel
    {
        [Required(ErrorMessage = "The field is required")]
        public string CinemaName { get; set; }

        [Required(ErrorMessage = "The field is required")]
        public int NumberOfHall { get; set; }

        [Required(ErrorMessage = "The field is required")]
        public int Rows { get; set; }

        [Required(ErrorMessage = "The field is required")]
        public int SeatsPerRow { get; set; }
    }
}
