using DIWorkshop.Entities;
using DIWorkshop.Persistence;

namespace DIWorkshop.Managers
{
    public class DriverManager : IDriverManager
    {
        private readonly IDriverRepository _driverRepository;
        private readonly ICarRepository _carRepository;

        public DriverManager(IDriverRepository i, ICarRepository c)
        {
            _driverRepository = i;
            _carRepository = c;
        }

        public Driver GetDriver(int id)
        {
            return _driverRepository.GetDriver(id);
        }

        public Driver GetDriverAndHisCar(int driverId, int carId)
        {
            Driver dr = _driverRepository.GetDriver(driverId);
            dr.Car = _carRepository.GetCar(carId);
            return dr;
        }
    }
}
