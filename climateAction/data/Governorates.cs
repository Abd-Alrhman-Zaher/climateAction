using climateAction.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace climateAction.data
{
    public class Governorates
    {
        public int id { set; get; }
        public string Governorates_EN { set; get; }
        public string Governorates_AR { set; get; }
    }
}
