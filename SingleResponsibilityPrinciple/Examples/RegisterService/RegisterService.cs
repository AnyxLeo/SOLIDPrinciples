using System;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SingleResponsibilityPrinciple.Bad.Examples.RegisterService
{
    public class RegisterService
    {
        public void RegisterUser(string username)
        {
            if (username == "admin")
                throw new InvalidOperationException();

            var connection = new SqlConnection();
            connection.Open();
            var command = new SqlCommand("INSERT INTO [...]");//Insert user into database. 

            var client = new SmtpClient("smtp.myhost.com");
            client.Send(new MailMessage()); //Send a welcome email. 
        }
    }
}
