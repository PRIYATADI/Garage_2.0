using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Garage_2._0.Models.ViewModel;
using Garage_2._0.Models;
using Garage_2._0.DataAccessLayer;

namespace Garage_2._0.Controllers
{
    public class SearchController : Controller
    {
        private GarageContext db = new GarageContext();
        // GET: Search
        public ActionResult Index( string SearchString, string SearchModel, string Searchbrand)
        {
            var ParkedVehicles = from v in db.ParkedVehicles
                                 select v;
            if (!string.IsNullOrEmpty(SearchString))
            {
                ParkedVehicles = ParkedVehicles.Where(s => s.Registration_number.Contains(SearchString));
            }
            else if (!string.IsNullOrEmpty(SearchModel))
            {
                ParkedVehicles = ParkedVehicles.Where(s => s.Model.Contains(SearchModel));
            }
            else if (!string.IsNullOrEmpty(Searchbrand)) 
            {
                ParkedVehicles = ParkedVehicles.Where(s => s.Brand.Contains(Searchbrand));
            }
        
        
            return View(ParkedVehicles);
        }
    }
}