using BL = BusinessLogic.Contract.Models;
using DA = DataAccess.Contract.Models;

namespace BusinessLogic.Contract.Interfaces
{
    public interface IDepartmentService : IBusinessLogicService<BL.Department, DA.Department>
    {
    }
}
