//SOLID PRINCIPLE
//Single Responsibility Principle

using System;

class UserManager
{
    public string ? UserName { get; set; }

    public void CreateUser()
    {
        Console.WriteLine($"User {UserName} created");
    }
}
class Login
{
    public void UserLogin(UserManager user)
    {
        Console.WriteLine($"User {user.UserName} loggedin @ {DateTime.Now}");
    }
}

class Email
{
    public void EmailGen(UserManager user)
    {
        Console.WriteLine($"Welcome : {user.UserName}  ");
    }
}

class Program
{
    static void Main()
    {
        UserManager name = new UserManager();
        Login login = new Login();
        Email email = new Email();

        name.UserName = ("Shiva");
        name.CreateUser();
        login.UserLogin(name);
        email.EmailGen(name);
    }
}