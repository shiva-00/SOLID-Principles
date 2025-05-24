using System;

public interface IPaymentService
{
    void Payment(string user, double amount);
}

public class Creditcard : IPaymentService
{
    public void Payment(string user, double amount)
    {
        Console.WriteLine($"Dear {user}, total of {amount} is debited via Creditcard");
    }
}

public class GooglePay : IPaymentService
{
    public void Payment(string user, double amount)
    {
        Console.WriteLine($"Dear {user}, total of {amount} is debited via GooglePay");
    }
}

public class NetBanking : IPaymentService
{
    public void Payment(string user, double amount)
    {
        Console.WriteLine($"Dear {user}, total of {amount} is debited via NEFT");
    }
}

public class PaymentProcessor
{
    private readonly IPaymentService _paymentservice;
    public PaymentProcessor(IPaymentService paymentservice)
    {
        this._paymentservice = paymentservice;
    }

    public void ProcessPayment(string user, double amount)
    {
        _paymentservice.Payment(user, amount);
    }
}

class Program
{
    static void Main()
    {
        IPaymentService credit = new Creditcard();
        IPaymentService Gpay = new GooglePay();
        IPaymentService banking = new NetBanking();

        var creditcard = new PaymentProcessor(credit);
        var gpay = new PaymentProcessor(Gpay);
        var bank = new PaymentProcessor(banking);
        creditcard.ProcessPayment("shiva", 500);
        gpay.ProcessPayment("shiva", 500);
        bank.ProcessPayment("shiva", 500);
    }
}