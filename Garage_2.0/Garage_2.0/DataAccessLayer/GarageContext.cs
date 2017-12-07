using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Garage_2._0.DataAccessLayer
{
    public class GarageContext:DbContext
    {
        public GarageContext() : base("Garage_2._0")
        { }

        public DbSet<Models.ParkedVehicle> ParkedVehicles { get; set; }
    }
}