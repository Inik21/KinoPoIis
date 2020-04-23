using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KinoPolis.Web.ViewModels.Administration.Cinemas
{
    public class CreateInputModel
    {
        [Required(ErrorMessage ="The field is required")]
        [RegularExpression(@"^[a-zA-Z -]*$", ErrorMessage ="The field should contain only letters and -")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field is required")]
        public string Address { get; set; }
    }
}
