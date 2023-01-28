using climateAction.data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace climateAction.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Facility_Code { set; get; }
        public int Governorate_Id { set; get; }
        public int Directorate_Id { set; get; }
        public DateTime year { set; get; }
        public bool Submitted { set; get; }
    }
}
