using DIWorkshop.Entities;
using System.Linq;

namespace DIWorkshop.Persistence
{
    public class CarRepository : ICarRepository
    {
        private readonly DbContext _dbContext;

        public CarRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Car GetCar(int id)
        {

            if (_dbContext.Cars.FirstOrDefault(x => x.Id == id) == null)
                return null;
            else return _dbContext.Cars.FirstOrDefault(x => x.Id == id);
        }
    }
}
