
using Tool.Server.Models;

public interface IUserService
{

    Task<bool> Login(User user);
}