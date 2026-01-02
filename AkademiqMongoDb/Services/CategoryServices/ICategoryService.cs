using AkademiqMongoDb.DTOs.CategoryDtos;

namespace AkademiqMongoDb.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> GetAllAsync();
        Task<UpdateCategoryDto> GetByIdAsync(string id);

        Task CreateAsync(CreateCategoryDto categoryDto);

        Task UpdateAsync(UpdateCategoryDto updatecategoryDto);

        Task DeleteAsync(string id);

    }
}
