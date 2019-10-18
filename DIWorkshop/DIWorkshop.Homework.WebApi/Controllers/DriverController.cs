using DIWorkshop.Managers;
using DIWorkshop.Persistence;
using System.Web.Http;

namespace DIWorkshop.Homework.WebApi.Controllers
{
    public class DriverController : ApiController
    {
        private readonly DriverManager _driverManager;

        public DriverController()
        {
            _driverManager = new DriverManager();
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
