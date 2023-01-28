using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace climateAction.data
{
    public class Facilities
    {
        public int id { set; get; }
        public string Facility_Code { set; get; }
        public string Facility_Name_EN { set; get; }
        public string Facility_Name_AR { set; get; }
        public int governorates_id { set; get; }
        public int directorates_id { set; get; }
        public int facility_Types_id { set; get; }
        public double Latitude { set; get; }
        public double Longitude { set; get; }
        public string User_Id { set; get; }
    }
}
