using System.Text;

namespace search_algo.DesignPatterns.Structural;

public class Facade
{
    public StringBuilder statusPrint = new();
    public readonly IIRCTCBookingSystem _irctc;
    public readonly IPaytmPaymentSystem _paytm;

    public Facade(IIRCTCBookingSystem irctc, IPaytmPaymentSystem paytm)
    {
        _irctc = irctc;
        _paytm = paytm;
    }
    public string StartBookingTicket()
    {
        statusPrint.AppendLine(_irctc.SelectSourceDestination());
        statusPrint.AppendLine(_irctc.SelectSeats());
        statusPrint.AppendLine(_paytm.SelectBankMode());
        statusPrint.AppendLine(_paytm.InitiatePayment());
        if (_paytm.PaymentCompleted())
            statusPrint.AppendLine(_irctc.FinalizeBooking());
        else
            statusPrint.AppendLine(_irctc.Failed());

        return statusPrint.ToString();
    }

}

public interface IPaytmPaymentSystem
{
    string SelectBankMode();
    string InitiatePayment();
    bool PaymentCompleted();
}
public class PaytmPaymentSystem : IPaytmPaymentSystem
{

    public string SelectBankMode()
    {
        return "HDFC";
    }

    public string InitiatePayment()
    {
        return "Started Payment";
    }

    public bool PaymentCompleted()
    {
        return true;
    }

}

public interface IIRCTCBookingSystem
{
    string SelectSourceDestination();
    string SelectSeats();
    string FinalizeBooking();
    string Failed();
}
public class IRCTCBookingSystem : IIRCTCBookingSystem
{

    public string SelectSourceDestination()
    {
        return "Source: Hyderabad | Destination : Delhi";
    }
    public string SelectSeats()
    {
        return "Train Number : 12740A | Seat : 34a";
    }
    public string FinalizeBooking()
    {
        return "Done";
    }
    public string Failed()
    {
        return "ERROR";
    }
}

class Client
{
    public static void GenerateTicket(Facade facade)
    {
        Console.WriteLine(facade.StartBookingTicket());
    }
}

public static class FacadePatternExection
{
    public static void Execute()
    {
        IIRCTCBookingSystem iRCTCBookingSystem = new IRCTCBookingSystem();
        IPaytmPaymentSystem paytmPaymentSystem = new PaytmPaymentSystem();
        var facade = new Facade(iRCTCBookingSystem, paytmPaymentSystem);
        Client.GenerateTicket(facade);
    }
}