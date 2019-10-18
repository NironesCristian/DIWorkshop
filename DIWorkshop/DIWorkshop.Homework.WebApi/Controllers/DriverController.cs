using DIWorkshop.Interfaces;
using System.Web.Http;

namespace DIWorkshop.Homework.WebApi.Controllers
{
    public class DriverController : ApiController
    {
        private readonly IDriverManager _driverManager;

        public DriverController(IDriverManager driverManager)
        {
            _driverManager = driverManager;
        }

        [HttpGet]
        [Route("driver/{id}")]
        public IHttpActionResult GetDriver(int id)
        {
            return Ok(_driverManager.GetDriver(id));
        }

        [HttpGet]
        [Route("driver/{driverID}/car/{carID}")]
        public IHttpActionResult GetDriverWithCar(int driverID, int carID)
        {
            return Ok(_driverManager.GetDriverWithCar(driverID, carID));
        }
    }
}
