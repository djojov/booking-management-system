using Shared.Interfaces;
using Shared.Models;

namespace BusinessLayer
{
    public class AdminBusiness:IAdminBusiness
    {
        private readonly IAdminRepository adminRepository;

        public AdminBusiness(IAdminRepository _adminRepository)
        {
            adminRepository = _adminRepository;
        }
        
        public Admin GetAdmin(string username, string password)
        {
            return this.adminRepository.GetAdmin(username,password);
        }
    }
}