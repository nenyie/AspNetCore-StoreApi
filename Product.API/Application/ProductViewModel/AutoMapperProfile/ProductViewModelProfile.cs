using AutoMapper;
using Product.API.Application.Command.CreateProduct;
using Product.API.Application.Command.UpdteProduct;
using Product.API.Application.ProductViewModel;

namespace Product.API.Application.ProductProfile;

public class ProductViewModelProfile : Profile
{
    public ProductViewModelProfile()
    {
        CreateMap<CreateProductCommand, CreateProductCommandDto>();
        CreateMap<UpdateProductCommand, UpdateProductCommandDto>();
    }
}
