using System;
using DataLayer.Repositories;
using NUnit.Framework;
using Shared.Interfaces;
using Shared.Models;

namespace ClientRepositoryTests
{
    [TestFixture]
    public class InsertClientTest
    {
        private readonly IClientRepository clientRepository;

        public InsertClientTest()
        {
            // Assuming Constants.ConnectionString is correctly configured for testing purposes
            clientRepository = new ClientRepository();
        }

        [Test]
        public void InsertClient_ShouldReturnOneRowInserted()
        {
            // Arrange
            Client newClient = new Client
            {
                FirstName = "John",
                LastName = "Doe",
                PhoneNumber = "123456789",
                Email = "john.doe@example.com"
            };

            // Act
            int rowsInserted = clientRepository.InsertClient(newClient);

            // Assert
            Assert.AreEqual(1, rowsInserted);
        }
    }
}