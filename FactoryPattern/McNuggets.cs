namespace FactoryPattern;

public class McNuggets : IFastFood 
{
    public static int Total { get; set; } = 0;
    public void FoodOrder()
    {
        Console.WriteLine("McNuggets added to order!");
        Checkout.OrderPayment.Add(5.00);
        Total++;
        Console.WriteLine($"{Total} in cart");
    }

    public void RemoveOrder()
    {
        if (Total > 0)
        {
            Checkout.OrderPayment.Remove(5.00);
            Total--;
            Console.WriteLine("McNuggets removed from order.");
            Console.WriteLine($"{Total} in cart");
            Thread.Sleep(1000);
        }
        else
        {
            Console.WriteLine("Selected item not in cart.");
        }
    }
}