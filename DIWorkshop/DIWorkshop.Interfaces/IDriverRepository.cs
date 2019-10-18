using DIWorkshop.Entities;

namespace DIWorkshop.Interfaces
{
    public interface IDriverRepository
    {
        Driver GetDriver(int id);
    }
}