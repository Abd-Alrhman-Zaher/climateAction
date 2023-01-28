using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace climateAction.Models
{
    public class signUpModel
    {
        [Required]
        public string Username { set; get; }
        [Required]
        [Compare("confirmPassword")]
        [DataType(DataType.Password)]
        public string password { set; get; }
        [DataType(DataType.Password)]
        public string confirmPassword { set; get; }
    }
}
