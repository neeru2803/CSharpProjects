using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApp.Models
{
    public class Person
    {
        public int PersonId { get; set;}
        [Required,StringLength(50), Display(Name="Name")]
        public string  FirstName { get; set; }
        [Required, StringLength(50), Display(Name = "LastName")]
        public string LastName { get; set; }
        [Required, StringLength(50), Display(Name = "Email")]
        public string Email  { get; set; }

        
    }
}