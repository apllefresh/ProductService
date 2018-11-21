using BL = BusinessLogic.Contract.Models;
using DA = DataAccess.Contract.Models;

namespace BusinessLogic.Contract.Interfaces
{
    public interface IProductService : IBusinessLogicService<BL.Product, DA.Product>
    {
    }
}
