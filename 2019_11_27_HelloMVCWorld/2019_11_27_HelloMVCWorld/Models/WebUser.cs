using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _2019_11_27_HelloMVCWorld.Models
{
    public class WebUser
    {
        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50,MinimumLength = 3)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string MailAddress { get; set; }
    }
}
