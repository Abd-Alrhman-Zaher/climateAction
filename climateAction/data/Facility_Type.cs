using climateAction.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace climateAction.data
{
    public class Facility_Type
    {
        public int id { set; get; }
        public string Facility_Type_EN { set; get; }
        public string Facility_Type_AR { set; get; }

    }
}
