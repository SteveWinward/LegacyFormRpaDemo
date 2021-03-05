using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace LegacyFormRpaDemo.Models
{
    public class CreateForm
    {
        [Required]
        [Display(Name = "Event Name")]
        public string EventName { get; set; }

        [Required]
        [Display(Name = "Event Date")]
        public string EventDate { get; set; }

        [Required]
        [Display(Name = "Event Time")]
        public string EventTime { get; set; }

        [Required]
        [Display(Name = "Location")]
        public string Location { get; set; }

        [Required]
        [Display(Name = "Type of Food")]
        public string TypeOfFood { get; set; }

        [Required]
        [Display(Name = "Volunteer Name")]
        public string VolunteerName { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Display(Name = "Phone Number (alt)")]
        public string PhoneAlt { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

    }
}