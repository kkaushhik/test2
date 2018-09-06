using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Infraction_2.Models
{
    public class PostModel
    {

        [Display(Name = "Id")]

        public int Empid { get; set; }
    

        [Required]
        public string Title{ get; set; }
        [Required]
        public string Tags { get; set; }
        [Required]
        public string Subject { get; set; }

    }
}