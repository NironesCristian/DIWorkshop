using DIWorkshop.Entities;

namespace DIWorkshop.Persistence
{
    public interface IDriverRepository
    {
        Driver GetDriver(int id);
        Driver GetDriverByCarId(int carId);
    }
}