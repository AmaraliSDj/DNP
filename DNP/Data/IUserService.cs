
using ToDo.Models;

namespace DNP.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string Password);
    }
}