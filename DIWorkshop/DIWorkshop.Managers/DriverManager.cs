using DIWorkshop.Entities;
using DIWorkshop.Persistence;

namespace DIWorkshop.Managers
{
    public class DriverManager
    {
        private readonly DriverRepository _driverRepository;

        public DriverManager()
        {
            _driverRepository = new DriverRepository(new DbContext());
        }

        public Driver GetDriver(int id)
        {
            return _driverRepository.GetDriver(id);
        }

        public Driver GetDriverWithCar(int driverID, int carID)
        {
            return _driverRepository.GetDriverWithCar(driverID, carID);
        }
    }
}
