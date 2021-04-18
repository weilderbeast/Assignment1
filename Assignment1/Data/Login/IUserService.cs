using System.Threading.Tasks;

namespace Assignment1.Data.Login
{
    public interface IUserService
    {
        Task<User> ValidateUser(string Username, string Password);
    }
}