using System.Collections.Generic;
using DataLayer.Repositories;
using NUnit.Framework;
using Shared.Interfaces;
using Shared.Models;

namespace ClientRepositoryTests
{
    [TestFixture]
    public class DeleteClientTest
    {
        private readonly IClientRepository clientRepository;

        public DeleteClientTest()
        {
            // Assuming Constants.ConnectionString is correctly configured for testing purposes
            clientRepository = new ClientRepository();
        }
        
        [Test]
        public void DeleteClient_ShouldReturnOneRowDeleted()
        {
            // Arrange
            Client existingClient = GetAnyExistingClient(); // Implement a method to get an existing client

            // Act
            int rowsDeleted = clientRepository.DeleteClient(existingClient.Id);

            // Assert
            Assert.AreEqual(1, rowsDeleted);
        }
        
        private Client GetAnyExistingClient()
        {
            // Implement a method to retrieve an existing client for testing purposes
            List<Client> clients = clientRepository.GetAllClients();
            return clients.Count > 0 ? clients[0] : new Client();
        }
    }
}