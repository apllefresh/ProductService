using AutoMapper;
using BLBaseModels = BusinessLogic.Models;
using BLContractModels = BusinessLogic.Contract.Models;
using DAContractModels = DataAccess.Contract.Models;

namespace BusinessLogic.DI
{
    public class BusinessLogicAutoMapperProfile : Profile
    {
        public BusinessLogicAutoMapperProfile()
        {
            CreateMap<DAContractModels.Department, BLContractModels.Department>()
                .ReverseMap();
            CreateMap<DAContractModels.ProductGroup, BLContractModels.ProductGroup>()
                .ReverseMap();
            CreateMap<DAContractModels.Product, BLContractModels.Product>()
                .ReverseMap();
            

            CreateMap<BLBaseModels.Department, BLContractModels.Department>()
                .ReverseMap();
            CreateMap<BLBaseModels.ProductGroup, BLContractModels.ProductGroup>()
                .ReverseMap();
            CreateMap<BLBaseModels.Product, BLContractModels.Product>()
                .ReverseMap();
            

            CreateMap<BLBaseModels.Department, DAContractModels.Department>()
                .ReverseMap();
            CreateMap<BLBaseModels.ProductGroup, DAContractModels.ProductGroup>()
                .ReverseMap();
            CreateMap<BLBaseModels.Product, DAContractModels.Product>()
                .ReverseMap();
        }
    }
}
