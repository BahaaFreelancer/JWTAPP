using JWTAPP.Models;

namespace JWTAPP.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
    }
}
