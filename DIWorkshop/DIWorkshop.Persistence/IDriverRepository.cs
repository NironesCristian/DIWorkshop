using DIWorkshop.Entities;

namespace DIWorkshop.Persistence
{
    public interface IDriverRepository
    {
        void AssignCarToADriver(int carID, int driverID);
        Driver GetDriver(int id);
    }
}