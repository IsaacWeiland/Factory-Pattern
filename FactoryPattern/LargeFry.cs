namespace FactoryPattern;

public class LargeFry : IFastFood
{
    public static int Total { get; set; } = 0;
    public void FoodOrder()
    {
        Console.WriteLine("Large fry added to order!");
        Checkout.OrderPayment.Add(2.00);
        Total++;
        Console.WriteLine($"{Total} in cart");
    }

    public void RemoveOrder()
    {
        if (Total > 0)
        {
            Checkout.OrderPayment.Remove(2.00);
            Total--;
            Console.WriteLine("Large Fries removed from order.");
            Console.WriteLine($"{Total} in cart");
            Thread.Sleep(1000);
        }
        else
        {
            Console.WriteLine("Selected item not in cart.");
        }
    }
}