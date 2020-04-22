using KinoPolis.Data.Models;
using KinoPolis.Services.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KinoPolis.Web.ViewModels.Tickets
{
    public class ReserveViewModel : IMapFrom<Ticket>
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field can't be empty")]
        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "This field should contain only letters")]
        public string FirstNameOfBuyer { get; set; }

        [Required(ErrorMessage = "This field can't be empty")]
        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "This field should contain only letters")]
        public string SecondNameOfBuyer { get; set; }
    }
}
