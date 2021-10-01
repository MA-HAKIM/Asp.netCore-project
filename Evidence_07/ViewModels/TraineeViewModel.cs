using Evidence_07.Attribute;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Evidence_07.ViewModels
{
    public class TraineeViewModel
    {
        public int TraineeId { get; set; }
        [Required, Display(Name = "Trainee Name"), StringLength(40)]
        public string TraineeName { get; set; }

        public IFormFile Picture { get; set; }
        [Required]
        public string Email { get; set; }
        [Required, Display(Name = "Training Location"), ValidLocation(ErrorMessage = "Location will be Dhaka, Chattagram or Rajshahi")]

        public string TLocation { get; set; }
        [Required, Display(Name = "Course Name")]
        public int CourseId { get; set; }
    }
}
