using System.Collections.Generic;
using Shared.Interfaces;
using Shared.Models;

namespace BusinessLayer
{
    public class ClientBusiness:IClientBusiness
    {
        
        private readonly IClientRepository clientrepository;

        public ClientBusiness(IClientRepository _clientrepository)
        {
            clientrepository = _clientrepository;
        }
        
        public List<Client> GetAllClients()
        {
            return this.clientrepository.GetAllClients();
        }

        public string UpdateClient(Client client)
        {
            int rowsAffected = this.clientrepository.UpdateClient(client);

            if (rowsAffected > 0)
            {
                return "Client successfully updated!";
            }
            else
            {
                return "Failed to update client!";
            }
        }

        public string InsertClient(Client client)
        {
            int rowsAffected = this.clientrepository.InsertClient(client);

            if (rowsAffected > 0)
            {
                return "Client successfully added!";
            }
            else
            {
                return "Failed to insert client!";
            }
        }

        public string DeleteClient(int id)
        {
            int rowsAffected = this.clientrepository.DeleteClient(id);

            if (rowsAffected > 0)
            {
                return "Client successfully deleted!";
            }
            else
            {
                return "Failed to delete client!";
            }
        }
    }
}