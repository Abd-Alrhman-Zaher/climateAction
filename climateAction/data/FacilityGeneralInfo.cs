using climateAction.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace climateAction.data
{
    public class FacilityGeneralInfo
    {
        public int id { set; get; }
        public double Latitude { set; get; }
        public int Facility_id { set; get; }
        public string User_id { set; get; }
        public double Longitude { set; get; }
        public string Management_Type { set; get; }
        public int Total_Staff { set; get; }
        public int Number_Of_Doctors { set; get; }
        public int Number_Of_Nurses { set; get; }
        public int Number_Of_Midwives { set; get; }
        public int Number_Of_inpatients { set; get; }
        public int Number_Of_beds { set; get; }
        public double Occupancy_Rate { set; get; }
        public int Outpatients { set; get; }
        public bool Kitchen { set; get; }
        public bool Laundry { set; get; }
        public bool Toilets { set; get; }
        public bool Laboratory { set; get; }
        public bool Triage_Area { set; get; }
        public bool waiting_area { set; get; }
        public bool Covid_waiting_area { set; get; }
        public bool Oxygen { set; get; }
        public bool Inpatient_beds { set; get; }
        public bool Mortuary { set; get; }
        public bool Showers { set; get; }
        public bool Ventilators { set; get; }
        public bool Delivery_ward { set; get; }
        public bool Surgical_ward { set; get; }
        public string Electric_power { set; get; }
        public string Water_supply { set; get; }
    }
}
