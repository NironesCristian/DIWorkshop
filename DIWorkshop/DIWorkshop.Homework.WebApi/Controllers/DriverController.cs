using DIWorkshop.Managers;
using DIWorkshop.Persistence;
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

        [Route("driver/{id}")]
        public IHttpActionResult GetDriver(int id)
        {
            return Ok(_driverManager.GetDriver(id));
        }

        [HttpGet]
        [Route("driver/{driverId}/car/{carId}")]
        public IHttpActionResult AssignCarToDriver(int driverId, int carId)
        {
            return Ok(_driverManager.AssignCarToDriver(driverId, carId));
            //return Ok(_driverManager.GetDriver(driverId));
        }


    }
}
