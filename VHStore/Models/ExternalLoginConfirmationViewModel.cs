using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VHStore.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Адрес электронной почты")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Driving license")]
        public string DrivingLicense { get; set; }

        [Required]
        [Phone]
        [StringLength(50)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
    }
}