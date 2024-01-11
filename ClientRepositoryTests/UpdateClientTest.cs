using DataLayer.Repositories;
using NUnit.Framework;
using Shared.Interfaces;
using Shared.Models;

namespace ClientRepositoryTests
{
    [TestFixture]
    public class UpdateClientTest
    {
        private readonly IClientRepository clientRepository;

        public UpdateClientTest()
        {
            // Assuming Constants.ConnectionString is correctly configured for testing purposes
            clientRepository = new ClientRepository();
        }

        [Test]
        public void UpdateClient_ShouldReturnOneRowUpdated()
        {
            // Arrange
            Client existingClient = GetAnyExistingClient(); // Implement a method to get an existing client
            existingClient.FirstName = "test";

            // Act
            int rowsUpdated = clientRepository.UpdateClient(existingClient);

            // Assert
            Assert.AreEqual(1, rowsUpdated);
        }

        private Client GetAnyExistingClient()
        {
            // Implement a method to retrieve an existing client for testing purposes
            // Ensure that there is at least one client in the database for testing
            // You may use the InsertClient method to insert a client before updating
            return new Client
            {
                Id = 3, // Provide a valid client ID from the database
                FirstName = "John",
                LastName = "Doe",
                PhoneNumber = "123456789",
                Email = "john.doe@example.com"
            };
        }
    }
}