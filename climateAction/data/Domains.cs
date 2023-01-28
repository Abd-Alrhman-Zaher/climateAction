using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace climateAction.data
{
    public class Domains
    {
        public int id { set; get; }
        public string Domain_Name_EN { set; get; }
        public string Domain_Name_AR { set; get; }
    }
}
