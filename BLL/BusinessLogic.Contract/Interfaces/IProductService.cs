using System.Threading.Tasks;
using BL = BusinessLogic.Contract.Models;
using DA = DataAccess.Contract.Models;

namespace BusinessLogic.Contract.Interfaces
{
    public interface IProductService : IBusinessLogicService<BL.Product, DA.Product>
    {
        Task<BL.Product> GetItemByEan(string ean);
    }
}
