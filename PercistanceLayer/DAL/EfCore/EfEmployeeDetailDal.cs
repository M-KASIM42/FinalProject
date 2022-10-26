using PercistanceLayer.DAL.Abstract;
using PercistanceLayer.Entities;

namespace PercistanceLayer.DAL.EfCore
{
    public class EfEmployeeDetailDal : BaseRepository<EmployeeDetail>,
        IEntityRepository<EmployeeDetail>,
        IEmployeeDetailDal

    {

    }


}
