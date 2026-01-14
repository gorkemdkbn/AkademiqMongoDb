using AkademiqMongoDb.DTOs.ProductDtos;

namespace AkademiqMongoDb.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GettAllAsync();
        Task<UpdateProductDto> GetByIdAsync(string id);

        Task CreateAsync(CreateProductDto productDto);
        Task UpdateAsync(UpdateProductDto productDto);

        Task DeleteAsync(string id);
    }
}
