using System.Collections.Generic;
using Shared.Models;

namespace Shared.Interfaces
{
    public interface IClientRepository
    {
        List<Client> GetAllClients();
        int UpdateClient(Client client);
        int InsertClient(Client client);
        int DeleteClient(int id);
    }
}