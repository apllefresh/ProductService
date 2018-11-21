using BL = BusinessLogic.Contract.Models;
using DA = DataAccess.Contract.Models;

namespace BusinessLogic.Contract.Interfaces
{
    public interface IProductGroupService : IBusinessLogicService<BL.ProductGroup, DA.ProductGroup>
    {
    }
}
