using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VHStore.Models;

namespace VHStore.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please, enter customer's name")]
        [StringLength(255)]
        public string Name { get; set; }

        public byte MembershipTypeId { get; set; }

        //[Min18YearsIsAMember]
        public DateTime? Birthdate { get; set; }

        public bool IsSubcribedToNewsletter { get; set; }
    }
}