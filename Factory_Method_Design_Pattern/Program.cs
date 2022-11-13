using Factory_Method_Design_Pattern;

ICreditCard creditCard = new PlatinumFactory().CreateProduct();
if(creditCard != null)
{
    Console.WriteLine("Card type " + creditCard.GetCardType());
    Console.WriteLine("Credit Limit " + creditCard.GetCreditLimit());
    Console.WriteLine(" Annual cahrge " + creditCard.GetAnnualCharge());
} else
{
    Console.WriteLine("Invalid Card type.");
}

Console.WriteLine("-----------------------");

creditCard = new MoneyBackFactory().CreateProduct();
if (creditCard != null)
{
    Console.WriteLine("Card type " + creditCard.GetCardType());
    Console.WriteLine("Credit Limit " + creditCard.GetCreditLimit());
    Console.WriteLine(" Annual cahrge " + creditCard.GetAnnualCharge());
}
else
{
    Console.WriteLine("Invalid Card type.");
}