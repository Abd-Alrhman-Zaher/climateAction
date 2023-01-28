using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace climateAction.data
{
    //[Table("waterQuestion")]
    public class Question
    {
        public int id { set; get; }
        public string question_code { set; get; }
        public string category_title_EN { set; get; }
        public int category_id{ set; get; }
        public int domains_id { set; get; }
        public string Indicator_EN { set; get; }
        public string explanatoryNotes_EN { set; get; }
        public string green_EN { set; get; }
        public string yellow_EN { set; get; }
        public string red_EN { set; get; }
        public string category_title_AR { set; get; }
        public string Indicator_AR { set; get; }
        public string explanatoryNotes_AR { set; get; }
        public string green_AR { set; get; }
        public string yellow_AR { set; get; }
        public string red_AR { set; get; }
    }
}
