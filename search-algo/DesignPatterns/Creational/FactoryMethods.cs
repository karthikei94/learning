namespace search_algo.DesignPatterns.Creational;

// ! Factory Method
// * Factory 
// * Concrete Factory
// * interfact Product
// * Concrete Product

public abstract class CreditCardFactory
{
    public abstract CreditCard IssueCreditCard();

    public CreditCard CreateProduct()
    {
        return this.IssueCreditCard();
    }
}

#region Credit Card class
public interface CreditCard
{
    public string GetCardType();
    public int GetCardLimit();
    public int GetAnnualCharges();
}
public class TitaniumCard : CreditCard
{
    public int GetAnnualCharges() => 1500;
    public int GetCardLimit() => 3_00_000;
    public string GetCardType() => "MoneyBack Titanium";
}
public class PlatinumCard : CreditCard
{
    public int GetAnnualCharges() => 500;
    public int GetCardLimit() => 1_00_000;
    public string GetCardType() => "Spofiy Platinum";
}

#endregion

public class TitaniumCardFactory : CreditCardFactory
{
    public override CreditCard IssueCreditCard()
    {
        return new TitaniumCard();
    }
}
public class PlatinumCardFactory : CreditCardFactory
{
    public override CreditCard IssueCreditCard()
    {
        return new PlatinumCard();
    }
}

public class FactoryMethodExecution
{
    public static void Execute()
    {
        var titaniumCard = new TitaniumCardFactory().CreateProduct();
        if (titaniumCard != null)
        {
            Console.WriteLine($"Card Type: {titaniumCard.GetCardType()}");
            Console.WriteLine($"Card Limit: {titaniumCard.GetCardLimit()}");
            Console.WriteLine($"Card Charges: {titaniumCard.GetAnnualCharges()}");
        }
        var platinumCard = new PlatinumCardFactory().CreateProduct();
        if (platinumCard != null)
        {
            Console.WriteLine($"Card Type: {platinumCard.GetCardType()}");
            Console.WriteLine($"Card Limit: {platinumCard.GetCardLimit()}");
            Console.WriteLine($"Card Charges: {platinumCard.GetAnnualCharges()}");
        }
    }
}