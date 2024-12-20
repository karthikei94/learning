namespace search_algo.DesignPatterns.Creational;

#region Payment Types and their functions
public interface IPaymentAuthorization
{
    bool AuthorizePayment(decimal amount);
}
public interface IPaymentTransfer
{
    bool Transfer(decimal amount);
}

public class CreditCardAuthorization : IPaymentAuthorization
{
    public bool AuthorizePayment(decimal amount)
    {
        Console.WriteLine("Authirizing payment of amount {0} via Credit card", amount);
        return true;
    }
}

public class CreditCardTransfer : IPaymentTransfer
{
    public bool Transfer(decimal amount)
    {
        System.Console.WriteLine("Payment transfer via credit card, amount: {0}", amount);
        return true;
    }
}

public class PayPalAuthorization : IPaymentAuthorization
{
    public bool AuthorizePayment(decimal amount)
    {
        Console.WriteLine("Authirizing payment of amount {0} via Paypal", amount);
        return true;
    }
}


public class PayPalTransfer : IPaymentTransfer
{
    public bool Transfer(decimal amount)
    {
        System.Console.WriteLine("Payment transfer via Paypal, amount: {0}", amount);
        return true;

    }
}

#endregion

#region Factory wrapping functionality for each payment.

public interface IPaymentFactory
{
    IPaymentAuthorization CreateAuthorization();
    IPaymentTransfer CreateTransfer();
}

public class CreditCardPaymentFactory : IPaymentFactory
{
    public IPaymentAuthorization CreateAuthorization() => new CreditCardAuthorization();
    public IPaymentTransfer CreateTransfer() => new CreditCardTransfer();
}
public class PayPalPaymentFactory : IPaymentFactory
{
    public IPaymentAuthorization CreateAuthorization() => new CreditCardAuthorization();
    public IPaymentTransfer CreateTransfer() => new CreditCardTransfer();
}

#endregion

#region Abstraction where the actual payment is done by taking the factory as input in constructor.
public class PaymentProcessor
{

    private readonly IPaymentAuthorization _authorization;
    private readonly IPaymentTransfer _transfer;
    public PaymentProcessor(IPaymentFactory factory)
    {
        _authorization = factory.CreateAuthorization();
        _transfer = factory.CreateTransfer();
    }

    public bool ProcessPayment(decimal amount)
    {
        if (_authorization.AuthorizePayment(amount))
        {
            return _transfer.Transfer(amount);
        }
        return false;
    }
}
#endregion

public class AbstractFactoryExecutor
{

    public static void Execute()
    {
        System.Console.WriteLine("Paypal Transfer: ");
        PayPalPaymentFactory factory = new PayPalPaymentFactory();
        PaymentProcessor processor = new PaymentProcessor(factory);
        processor.ProcessPayment(2000);
        
        System.Console.WriteLine("Credit Card Transfer: ");
        CreditCardPaymentFactory factory2 = new CreditCardPaymentFactory();
        PaymentProcessor processor2 = new PaymentProcessor(factory2);
        processor2.ProcessPayment(2000);
    }
}