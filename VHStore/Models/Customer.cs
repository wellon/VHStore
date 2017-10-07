﻿using System;
using System.ComponentModel.DataAnnotations;

namespace VHStore.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please, enter customer's name")]
        [StringLength(255)]
        public string Name { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIsAMember]
        public DateTime? Birthdate { get; set; }

        public bool IsSubcribedToNewsletter { get; set; }
    }
}