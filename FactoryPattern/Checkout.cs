namespace FactoryPattern;

public class Checkout
{
    public static List<double> OrderPayment { get; set; } = new List<double>();
    public static void Run()
    {
        if (BigMac.Total > 0 || McNuggets.Total > 0 || LargeFry.Total > 0)
        {
            Console.WriteLine($"You have ordered {BigMac.Total} Big Mac(s), {McNuggets.Total} McNuggets, and {LargeFry.Total} large fries.");
            Console.WriteLine("Are you ok with this?\ny/n");
            if (!MenuScreen.YesNo(Console.ReadLine()))
            {
                bool unhappy = true;
                while (unhappy)
                {
                    Console.WriteLine("What would you like to do?\nRemove items\nCancel order\nContinue with order");
                    Thread.Sleep(1000);
                    switch (Console.ReadLine().Replace(" ","").ToLower())
                    {
                        case "removeitems":
                        case"remove":
                            Console.WriteLine("What food would you like to remove?\n(Cancel to cancel)");
                            var removal = FastFoodFactory.DriveThru(Console.ReadLine());
                            removal.RemoveOrder();
                            break;
                        case "cancelorder":
                        case"cancel":
                            MenuScreen.Cancel();
                            break;    
                        case "continue": 
                        case"continueorder":
                        case"continuewithorder":
                            unhappy = false;
                            break;
                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
            }
            else
            {
                double orderCashTotal = 0;
                foreach (var item in OrderPayment)
                {
                    orderCashTotal += item;
                }

                Console.WriteLine($"You order total is {orderCashTotal}");
                Console.WriteLine("Thank you for ordering from us");
                Environment.Exit(0);
            }
        }
        else
        {
            Console.WriteLine("No items in cart, did you mean to cancel?\ny/n");
            if (MenuScreen.YesNo(Console.ReadLine()))
            {
                MenuScreen.Cancel();
            }
            else
            {
                MenuScreen.Run();
            }
        }
    }
}