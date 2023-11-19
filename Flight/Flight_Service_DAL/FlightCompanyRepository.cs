using Flight_Model;
using Flight_Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Service_DAL
{
    public class FlightCompanyRepository : IFlightCompanyRepository
    {

        readonly FlightContext _FlightContext;
        public FlightCompanyRepository(FlightContext FlightContext)
        {
            _FlightContext = FlightContext;
        }


       

        public List<FlightCompany> GetAllFlightCompanies()
        {
            return _FlightContext.FlightCompany.ToList();
        }
    }
}
