using Flight_Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Flight_Service_DAL
{
    public interface IFlightCompanyRepository
    {
        List<FlightCompany> GetAllFlightCompanies();
    }
}

