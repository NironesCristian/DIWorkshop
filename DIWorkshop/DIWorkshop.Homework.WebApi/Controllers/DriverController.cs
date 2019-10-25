using DIWorkshop.Managers;
using DIWorkshop.Persistence;
using System.Web.Http;
using Autofac;

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

        [Route("car/{carId}/driver/{driverId}")]
        public IHttpActionResult GetDriverByCarId(int carId,int driverId)
        {
            return Ok(_driverManager.GetDriverByCarId(carId,driverId));
        }
    }
}
