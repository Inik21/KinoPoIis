using KinoPolis.Data.Models;
using KinoPolis.Services.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KinoPolis.Web.ViewModels.Administration.Films
{
    public class CreateImputModel
    {
        [Required(ErrorMessage ="The field is required")]
        [RegularExpression(@"^[a-zA-Z0-9: ]*$", ErrorMessage ="The field should contain only numbers, letters and :")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z/]*$", ErrorMessage = "The field should contain only letters and /")]
        public string Category { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "The field should contain only letters")]
        public string Country { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "The field should contain only numbers")]
        public int Year { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "The field should contain only numbers")]
        public int Lenght { get; set; }

        [Required(ErrorMessage = "The field is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The field is required")]
        public string ImgUrl { get; set; }
    }
}
