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

        [HttpGet]
		[Route("driver/{id}")]
		public IHttpActionResult GetDriver(int id)
		{
			return Ok(_driverManager.GetDriver(id));
		}

        [HttpGet]
        [Route("assignCarToADriver/{carID}/{driverID}")]
        public IHttpActionResult GetDriverWithAssignetCar(int carID, int driverID)
        {
            _driverManager.AssignCarToADriver(carID, driverID);
            return Ok(_driverManager.GetDriver(driverID));
        }
    }
}
