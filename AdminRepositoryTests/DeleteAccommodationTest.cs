using NUnit.Framework;
using DataLayer.Repositories;
using Shared.Interfaces;
using Shared.Models;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace AdminRepositoryTests
{
    [TestFixture]
    public class DeleteAccommodationTest
    {
        
        private readonly IAdminRepository adminRepository;

        public DeleteAccommodationTest()
        {
            // Assuming Constants.ConnectionString is correctly configured for testing purposes
            adminRepository = new AdminRepository();
        }

        [Test]
        public void GetAdmin_WithValidCredentials_ShouldReturnAdmin()
        {
            // Arrange
            string validUsername = "djordje";
            string validPassword = "Adminadmin123!";

            // Act
            Admin result = adminRepository.GetAdmin(validUsername, validPassword);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(validUsername, result.Username);
            Assert.AreEqual(validPassword, result.Password);
        }

        [Test]
        public void GetAdmin_WithInvalidCredentials_ShouldReturnEmptyAdmin()
        {
            // Arrange
            string invalidUsername = "nonexistent";
            string invalidPassword = "InvalidPassword";

            // Act
            Admin result = adminRepository.GetAdmin(invalidUsername, invalidPassword);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Id); // Assuming Id is initialized as 0 for an empty admin
            Assert.IsNull(result.Username);
            Assert.IsNull(result.Password);
        }
    }
}