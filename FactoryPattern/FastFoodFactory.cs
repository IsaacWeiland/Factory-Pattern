namespace FactoryPattern;

public static class FastFoodFactory
{
    public static IFastFood DriveThru(string foodWant)
    {
        while (true)
        {
            switch (foodWant.Replace(" ","").ToLower())
            {
                case "bigmac":
                    return new BigMac();
                case "mcnuggets":
                case "mcnugget":
                    return new McNuggets();
                case "largefry":
                    return new LargeFry();
                case "menu":
                    Console.WriteLine("Big Mac\n McNuggets\nLarge Fry");
                    foodWant = Console.ReadLine();
                    break;
                case "checkout":
                    Checkout.Run();
                    break;
                case "cancel":
                    MenuScreen.Cancel();
                    break;
                case null:
                    Console.WriteLine("Please enter menu item.");
                    foodWant = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Menu item not found.\nCheckout to checkout");
                    foodWant = Console.ReadLine();
                    break;
            }
        }
    }
}