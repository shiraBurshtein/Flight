using Flight_Model.Model;
using Flight_Service_BL;
using Microsoft.AspNetCore.Mvc;

namespace Flight_Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightCompanyController : ControllerBase
    {
        readonly IFlightCompanyService _FlightCompanyService;

        public FlightCompanyController(IFlightCompanyService FlightCompanyService)
        {
            _FlightCompanyService = FlightCompanyService;
        }

        [HttpGet]
        [Route("GetFlightCompanies")]
        public List<FlightCompany> GetFlightCompanies()
        {
            return _FlightCompanyService.getAllFlightCompanies();
        }
    }
}
