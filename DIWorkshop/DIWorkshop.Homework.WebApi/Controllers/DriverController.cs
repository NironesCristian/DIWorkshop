using DIWorkshop.Managers;
using DIWorkshop.Persistence;
using System.Web.Http;

namespace DIWorkshop.Homework.WebApi.Controllers
{
	public class DriverController : ApiController
    {
		private readonly IDriverManager _driverManager;

		public DriverController(IDriverManager driver)
		{
			_driverManager = driver;
		}

        [Route("driver/{id}")]
        public IHttpActionResult GetDriver(int id)
        {
            return Ok(_driverManager.GetDriver(id));
        }

        [Route("driver/{driverId}/car/{carId}")]
        public IHttpActionResult GetDriverAndHisCar(int driverId, int carId)
        {
            return Ok(_driverManager.GetDriverAndHisCar(driverId, carId));
        }
    }
}
