using DIWorkshop.Entities;
using System.Linq;

namespace DIWorkshop.Persistence
{
	public class DriverRepository : IDriverRepository
    {
		private readonly DbContext _dbContext;

		public DriverRepository(DbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public Driver GetDriver(int id)
		{
			return _dbContext.Drivers.FirstOrDefault(x => x.Id == id);
		}

        public void AssignCarToADriver(int carID, int driverID)
        {
            var driver = _dbContext.Drivers.FirstOrDefault(x => x.Id == driverID);
            driver.Car = _dbContext.Cars.FirstOrDefault(x => x.Id == carID);
        }
	}
}
