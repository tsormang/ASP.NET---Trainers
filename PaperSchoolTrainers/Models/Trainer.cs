using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PaperSchoolTrainers.Models
{
    public class Trainer
    {
        public int Id { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [Required(ErrorMessage = "Name is Required")]
        [Display(Name="Name")]
        public String FirstName { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [Required(ErrorMessage = "Surname is Required")]
        [Display(Name = "Surname")]
        public String LastName { get; set; }

        [StringLength(50, MinimumLength = 2)]
        public String Subject { get; set; }

        //[Range(1, 12000, ErrorMessage = "Must be between 1-12000 euros")]
        public int Salary { get; set; }

    }


}