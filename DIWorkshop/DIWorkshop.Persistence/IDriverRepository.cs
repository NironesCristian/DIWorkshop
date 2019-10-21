using DIWorkshop.Entities;

namespace DIWorkshop.Persistence
{
    public interface IDriverRepository
    {
        void AssignCarToDriver(int driverId, int carId);
        Driver GetDriver(int id);
        Driver GetDriverByCarId(int carId);
    }
}