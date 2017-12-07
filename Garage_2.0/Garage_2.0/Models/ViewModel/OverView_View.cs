using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage_2._0.Models.ViewModel
{
    public class OverView_View
    {
        public string Registration_number { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public DateTime Parking_time { get; set; }

        public OverView_View()
        { }

        public OverView_View(ParkedVehicle pvehicle)
        {
            Registration_number = pvehicle.Registration_number;
            Type = pvehicle.Type.ToString();

            Color = pvehicle.Color;
            Parking_time = pvehicle.Parking_time;
        }
    }
}