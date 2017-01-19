using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mCPA.Models
{
    public class EmailModel
    {
        [Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }

        
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "This field is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        
        public string Phone { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}