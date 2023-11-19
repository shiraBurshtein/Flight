using Flight_Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Service_BL
{
    public interface IFlightCompanyService
    {
        List<FlightCompany> getAllFlightCompanies();
    }
}
