using climateAction.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace climateAction.data
{
    public class Answers
    {
        public int id { set; get; }
        public string User_id { set; get; }
        public int Question_id { set; get; }
        public int Score { set; get; }
        public DateTime Answers_Date_Time { set; get; }
        public string status { set; get; }
        public bool flag { set; get; }
        public string question_code { set; get; }
        public int assessments_id { set; get; }
    }
}
