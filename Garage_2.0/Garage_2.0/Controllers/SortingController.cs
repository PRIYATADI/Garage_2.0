using Garage_2._0.DataAccessLayer;
using Garage_2._0.Models;
using Garage_2._0.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Garage_2._0.Controllers
{
    public class SortingController : Controller
    {
        private GarageContext db = new GarageContext();
        // GET: Sorting
        public ActionResult Index(string sortOrder)
        {


            ViewBag.TypeSortParm = String.IsNullOrEmpty(sortOrder) ? "type_desc" : "";
            ViewBag.Parking_timeSortParm = sortOrder == "Parking_time" ? "parking_time_desc" : "";
            ViewBag.colorSortParm = String.IsNullOrEmpty(sortOrder) ? "color_desc" : "";
            ViewBag.Registration_numberSortParm = String.IsNullOrEmpty(sortOrder) ? "Registration_number_desc" : "";
            //Parkedvehicles = from s in db.Parkedvehicles
            //                      select s;
            List<OverView_View> Parkedvs = new List<OverView_View>();
            foreach (var veh in db.ParkedVehicles)
            {
                Parkedvs.Add(new OverView_View(veh));
            }
            switch(sortOrder)
            {
                case "Type":
                    Parkedvs = Parkedvs.OrderByDescending(s=>s.Type).ToList();
                    break;
                case "Parking_time":
                    Parkedvs = Parkedvs.OrderByDescending(s => s.Parking_time).ToList();
                    break;
                case "color":
                    Parkedvs = Parkedvs.OrderByDescending(s => s.Color).ToList();
                    break;
                case "Registration_number":
                    Parkedvs = Parkedvs.OrderByDescending(s => s.Registration_number).ToList();
                    break;
                default:
                    Parkedvs = Parkedvs.OrderBy(s => s.Type).ToList();
                    break;

            }

                return View(Parkedvs);
        }
    }
}