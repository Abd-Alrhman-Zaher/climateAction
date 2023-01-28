using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace climateAction.Models
{
    public class SignInModel
    {
        [Required]
        public string Username { set; get; }
        [Required]
        [DataType(DataType.Password)]
        public string password { set; get; }
        public bool RememberMe { set; get; }
    }
}
