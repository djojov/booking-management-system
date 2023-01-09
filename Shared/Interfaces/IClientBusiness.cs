using System.Collections.Generic;
using Shared.Models;

namespace Shared.Interfaces
{
    public interface IClientBusiness
    {
        List<Client> GetAllClients();
        string UpdateClient(Client client);
        string InsertClient(Client client);
        string DeleteClient(int id);
    }
}