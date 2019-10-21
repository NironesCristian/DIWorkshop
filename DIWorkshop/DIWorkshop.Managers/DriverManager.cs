using DIWorkshop.Entities;
using DIWorkshop.Persistence;

namespace DIWorkshop.Managers
{
    public class DriverManager : IDriverManager
    {
        private readonly IDriverRepository _driverRepository;
        private readonly ICarRepository _carRepository;

        public DriverManager(IDriverRepository driverRepository,ICarRepository carRepository)
        {
            _driverRepository = driverRepository;
            _carRepository = carRepository;
        }

        public Driver GetDriver(int id)
        {
            return _driverRepository.GetDriver(id);
        }

        public Driver GetDriverByCarId(int id,int jd)
        {
            Driver d = _driverRepository.GetDriver(jd);
            d.Car = _carRepository.GetCar(id);
            return d;
        }
    }
}
