using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Garage_2._0.Models
{
    public class ParkedVehicle
    {
        public int Id { get; set; }
        public Type Type { get; set; }
        [Required]
        [DisplayName("Registration_number")]
        public string Registration_number { get; set; }
        [Required]
        [DisplayName("Color")]
        [RegularExpression(@"^[a-zA-Z'' ']+$", ErrorMessage = "Special character & Numbers should not be entered")]
        public string Color { get; set; }
        [Required]
        [DisplayName("Brand")]
        [RegularExpression(@"^[a-zA-Z'' ']+$", ErrorMessage = "Special character & Numbers should not be entered")]
        public string Brand { get; set; }
        [Required]
        [DisplayName("Model")]
        [RegularExpression(@"^[a-zA-Z'' ']+$", ErrorMessage = "Special character & Numbers should not be entered")]
        public string Model { get; set; }
        public int Number_of_wheels { get; set; }
        public DateTime Parking_time { get; set; }


        public ParkedVehicle()
        {
            Parking_time = DateTime.Now;
        }
    }

    public enum Type
        {
        Car,Jeep,Truck,Bike,Van,Bicycle
        }

    }

   

