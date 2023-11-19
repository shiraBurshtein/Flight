using Flight_Model.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Model
{
    public class FlightContext:DbContext
    {
        public FlightContext(DbContextOptions<FlightContext> options) : base(options)
        {
            
        }
         public DbSet<Pilot> Pilot { get; set; } 
         public DbSet<Passenger> Passenger { get; set; } 
         public DbSet<Flighting>  Flighting { get; set; } 
         public DbSet<FlightCompany> FlightCompany { get; set; } 

    }
}
