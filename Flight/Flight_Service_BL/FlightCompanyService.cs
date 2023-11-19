using Flight_Model.Model;
using Flight_Service_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Service_BL
{
    public class FlightCompanyService : IFlightCompanyService
    {
        readonly IFlightCompanyRepository _FlightCompanyRepository;
        public FlightCompanyService(IFlightCompanyRepository Repository)
        {
            _FlightCompanyRepository = Repository;
        }

        public List<FlightCompany> getAllFlightCompanies()
        {
            return _FlightCompanyRepository.GetAllFlightCompanies();
        }
    }
}
