## 🛎️ Booking Management System

This project was created as part of my Software Engineering class (Jan 2023) where I created a three-layer application in C# and .NET Framework to help small resorts manage their booking.

## 🛠️ Technologies and tools

- `C#`
- `.NET Framework 4.8`
- `Windows Forms`
- `Dependency Injection`
- `Regex`
- `Three Layer application`
- `LocalDB`
- `Unit tests`

## 👷‍♂️ Application details

This is a 3-layer app consisting of a Data Layer that communicates with our database made using Microsoft SQL LocalDB. Inside the data layer, there are repositories containing all the necessary methods for basic CRUD operations with a database. On the Business layer, I've implemented logic for those operations and passed them onto the Presentation Layer. The presentation Layer is made of several Windows forms used for managing client, accommodation, and reservation data. Apart from three-layer architecture, this app uses Dependency Injection for separation of concerns and Regex to make sure users are entering valid data into textboxes. On the Reservation form, there are several methods to make sure that you can't create a reservation for already used accommodation and also methods to display the total cost of renting accommodation for a selected period.

**💻 Code Examples:**
<details>
<summary>Data Layer</summary>
  
#
  
``` c#
public int InsertClient(Client client)
{
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        string query = "INSERT INTO CLIENTS (first_name,last_name,phone_number,email) VALUES(@firstName,@lastName,@phoneNumber,@email)";
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@firstName", client.FirstName);
        command.Parameters.AddWithValue("@lastName", client.LastName);
        command.Parameters.AddWithValue("@phoneNumber", client.PhoneNumber);
        command.Parameters.AddWithValue("@email", client.Email);

        connection.Open();
        int rowsUpdated;
        rowsUpdated = command.ExecuteNonQuery();
        connection.Close();
        return rowsUpdated;
    }
}
```

</details>
<details>
  <summary>Business Layer</summary>

  #

  ``` c#
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
```
</details>

<details>
  <summary>Presentation Layer</summary>
  
```c#
 private void button_InsertClient_Click(object sender, EventArgs e)
        {
            if (textBox_FirstName.Text == "" || textBox_LastName.Text == ""  ||
                textBox_PhoneNumber.Text == "" || 
                textBox_Email.Text == "")
            {
                MessageBox.Show("You have to fill out all of the fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_FirstName.Focus();
                return;
            }
            else if (!Regex.Match(textBox_Email.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success)
            {
                MessageBox.Show("E-mail entered incorrectly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Email.Focus();
                return;
            }
            else if (!Regex.Match(textBox_FirstName.Text, @"^[A-Z]+[A-Za-z\s]{1,15}([A-Z]?)+([A-Za-z\s]?)$").Success)
            {
                MessageBox.Show("First name cannot contain a digit!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_FirstName.Focus();
                return;
            }
            else if (!Regex.Match(textBox_LastName.Text, @"^[A-Z]+[A-Za-z\s-]{1,30}([A-Z]?)+([A-Za-z\s]?)$").Success)
            {
                MessageBox.Show("Last name cannot contain a digit!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_LastName.Focus();
                return;
            }
            else if (!Regex.Match(textBox_PhoneNumber.Text, @"^[0][6]\d{7,8}$").Success)
            {
                MessageBox.Show("Phone number entered incorrectly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_PhoneNumber.Focus();
                return;
            }
            else
            {
                Client client = new Client();
                client.FirstName = textBox_FirstName.Text;
                client.LastName = textBox_LastName.Text;
                client.PhoneNumber = textBox_PhoneNumber.Text;
                client.Email = textBox_Email.Text;
                string result = clientBusiness.InsertClient(client);
                MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox_FirstName.Text = "";
                textBox_LastName.Text = "";
                textBox_PhoneNumber.Text = "";
                textBox_Email.Text = "";
            }
        } 

```

</details>

## 🧪 Unit testing

As part of my Software Quality Management class in my Master's studies, I added several unit tests to make sure key parts of this app are working correctly. Below you can find examples of two Unit tests. The former is for checking if a valid administrator exists in a database and the latter is created to make sure you can successfully insert new clients into the database.

<details>
  <summary>Unit test 1</summary>

  ```c#
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
```
</details>

<details>
  <summary>Unit test 2</summary>

  ```c#
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
```
</details>

<details> <summary><h2>📸 Demo Images</h2></summary>

#

![Screenshot1](https://i.ibb.co/8jKX4yL/msedge-a-DNNhe-Yh-YK.png)

#

![Screenshot2](https://i.ibb.co/7VPydyV/msedge-jp-J8-B0-Ocy-P.png)

#

![Screenshot3](https://i.ibb.co/28QDSx5/msedge-XIVu-Rjrgbr.png)

#

![Screenshot4](https://i.ibb.co/vYCmchk/msedge-Rctm-Y6-Jwt-Y.png)

#

![Screenshot5](https://i.ibb.co/2cV7tVf/msedge-A1c-XR6guvt.png)

#

![Screenshot6](https://i.ibb.co/T8GGvf2/msedge-v-R0x0-T2-YCt.png)

#

![Screenshot7](https://i.ibb.co/fkgZBTs/msedge-P9uxxjm58-Y.png)

</details>
