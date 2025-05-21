using System;
public abstract class PaymentMethod
{
    public abstract void ProcessPayment(double amount);
}

public class PayPal : PaymentMethod
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"{amount} is processing in Paypal Mode");
    }
}

public class GooglePay : PaymentMethod
{
    public override void ProcessPayment(double amount) =>  Console.WriteLine($"{amount} is proccessing in GooglePay Mode");
}


public class PaymentProessor
{
    public void MakePayment(PaymentMethod paymentmethod, double amount)
    {
        paymentmethod.ProcessPayment(amount);
    }
}

class Program
{
    static void Main()
    {
        PaymentProessor pay = new PaymentProessor();
        double amount = 500;
        PaymentMethod ppay = new PayPal();
        PaymentMethod gpay = new GooglePay();

        pay.MakePayment(ppay, amount);
        pay.MakePayment(gpay, amount);

    }
}
