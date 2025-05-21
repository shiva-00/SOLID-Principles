using System;

public class Notification
{
    public virtual void Notify(string message)
    {
        Console.WriteLine("This is a Notification alert");
    }
}

public class Email : Notification
{
    public override void Notify(string message)
    {
        Console.WriteLine($"Email : {message}");
    }
}

public class SMS : Notification
{
    public override void Notify(string message)
    {
        Console.WriteLine($"SMS : {message}");
    }
}

public class PushNotification : Notification
{
    public override void Notify(string message)
    {
        Console.WriteLine($"Push Notification : {message}");
    }
}

public class SendAlert
{
    public void SendNotification(Notification notify, string message)
    {
        notify.Notify(message);
    }
}

public class Program
{
    static void Main()
    {
        var print = new SendAlert();

        Notification email = new Email();
        Notification sms = new SMS();
        Notification push = new PushNotification();

        print.SendNotification(email,"Your order has been processed");
        print.SendNotification(sms, "Your OTP is *******");
        print.SendNotification(push, "You have a Friend Request");
    }

}