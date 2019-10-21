using DIWorkshop.Entities;
using DIWorkshop.Persistence;

namespace DIWorkshop.Managers
{
    public class DriverManager : IDriverManager
    {
        private readonly IDriverRepository _driverRepository;

        public DriverManager(IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository; /*new DriverRepository(new DbContext());*/
        }

        public Driver GetDriver(int id)
        {
            return _driverRepository.GetDriver(id);
        }
        public Driver GetDriverByCarId(int carId)
        {
            return _driverRepository.GetDriverByCarId(carId);
        }
        public Driver AssignCarToDriver(int driverId, int carId)
        {
            _driverRepository.AssignCarToDriver(driverId, carId);
            return GetDriver(driverId);
        }
    }
}
