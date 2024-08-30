namespace FactoryPattern;

public class BigMac : IFastFood
{
    public static int Total { get; set; }
    public void FoodOrder()
    {
        Console.WriteLine("Big Mac added to order!");
        Checkout.OrderPayment.Add(5.50);
        Total++;
        Console.WriteLine($"{Total} in cart");
    }

    public void RemoveOrder()
    {
        if (Total > 0)
        {
            Checkout.OrderPayment.Remove(5.50);
            Total--;
            Console.WriteLine("Big Mac removed from order.");
            Console.WriteLine($"{Total} in cart");
            Thread.Sleep(1000);
        }
        else
        {
            Console.WriteLine("Selected item not in cart.");
        }
    }
}