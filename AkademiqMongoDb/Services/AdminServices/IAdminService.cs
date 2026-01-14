using AkademiqMongoDb.DTOs.AdminDtos;

namespace AkademiqMongoDb.Services.AdminServices
{
    public interface IAdminService
    {
        Task CreateAdminAsync(RegisterAdminDto registerAdminDto);
        Task<bool> LoginAdminAsync(LoginAdminDto loginAdminDto);
    }
}
