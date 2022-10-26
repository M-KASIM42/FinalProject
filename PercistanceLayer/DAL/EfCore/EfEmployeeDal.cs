using PercistanceLayer.DAL.Abstract;
using PercistanceLayer.Entities;

namespace PercistanceLayer.DAL.EfCore
{
    public class EfEmployeeDal : BaseRepository<Employee>,
        IEntityRepository<Employee>,
        IEmployeeDal
    {

    }
}
