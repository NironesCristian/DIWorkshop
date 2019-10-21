using DIWorkshop.Entities;

namespace DIWorkshop.Managers
{
    public interface IDriverManager
    {
        Driver GetDriver(int id);

        Driver GetDriverByCarId(int id,int jd);
    }
}