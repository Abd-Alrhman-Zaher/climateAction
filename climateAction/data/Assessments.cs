using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace climateAction.data
{
    public class Assessments
    {
        public int id { set; get; }
        public string Form_Name_AR { set; get; }
        public string Form_Name_EN { set; get; }
        public DateTime Created_At { set; get; }
        public string Status { set; get; }
        public DateTime Start_Date { set; get; }
        public DateTime End_Date { set; get; }
        public int domains_id { set; get; }
        public double Compltion_Prct { set; get; }
    }
}
