using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace climateAction.data
{
    public class QuestionCategory
    {
        public int id { set; get; }
        public string category_EN { set; get; }
        public string category_AR { set; get; }
        public string id_Question { set; get; }
        public int question_id { set; get; }
        public int domain_id { set; get; }
    }
}
