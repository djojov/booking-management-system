using Shared.Models;

namespace Shared.Interfaces
{
    public interface IAdminRepository
    {
        Admin GetAdmin(string username, string password);
    }
}