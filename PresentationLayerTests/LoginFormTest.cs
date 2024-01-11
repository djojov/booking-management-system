using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces;
using Shared.Models;
using PresentationLayer;
using System;
using System.Reflection;
using System.Windows.Forms;
using NUnit.Framework;

namespace PresentationLayerTests
{
    [TestFixture]
    public class LoginFormTest
    {
        [Test]
        public void button_Login_Click_ValidAdmin_LogsIn()
        {
            // Arrange
            Mock<IAdminBusiness> mockAdminBusiness = new Mock<IAdminBusiness>();
            Mock<IClientBusiness> mockClientBusiness = new Mock<IClientBusiness>();
            Mock<IAccommodationBusiness> mockAccommodationBusiness = new Mock<IAccommodationBusiness>();
            Mock<IReservationBusiness> mockReservationBusiness = new Mock<IReservationBusiness>();

            // Replace with valid admin data
            Admin validAdmin = new Admin { Id = 1, Username = "admin@example.com", Password = "ValidPassword123@" };

            mockAdminBusiness.Setup(business => business.GetAdmin(It.IsAny<string>(), It.IsAny<string>())).Returns(validAdmin);

            LoginForm loginForm = new LoginForm(mockAdminBusiness.Object, mockClientBusiness.Object, mockAccommodationBusiness.Object, mockReservationBusiness.Object);

            // Use reflection to set the private fields
            Type formType = loginForm.GetType();

            FieldInfo usernameField = formType.GetField("textBox_Username", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxUsername = (TextBox)usernameField.GetValue(loginForm);
            textBoxUsername.Text = "admin@example.com";

            FieldInfo passwordField = formType.GetField("textBox_Password", BindingFlags.NonPublic | BindingFlags.Instance);
            TextBox textBoxPassword = (TextBox)passwordField.GetValue(loginForm);
            textBoxPassword.Text = "ValidPassword123@";

            // Act
            loginForm.button_Login_Click(null, EventArgs.Empty);

            // Assert
            // Add assertions based on the expected behavior of your application after a successful login.
        }
    }
}