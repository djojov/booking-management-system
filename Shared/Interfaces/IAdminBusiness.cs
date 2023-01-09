using Shared.Models;

namespace Shared.Interfaces
{
    public interface IAdminBusiness
    {
        Admin GetAdmin(string username, string password);
    }
}