namespace FactoryPattern;

public class MenuScreen
{
    public static void Run()
    {
        while (true)
        {
            Console.WriteLine("Please enter menu item to add.\nCheckout to checkout\nCancel to cancel");
            Thread.Sleep(1000);
            var orderAdd = FastFoodFactory.DriveThru(Console.ReadLine());
            orderAdd.FoodOrder();
            Thread.Sleep(1000);
        }
    }

    public static void Cancel()
    {
            Console.WriteLine("Are you sure you would like to cancel?\ny/n");
            if(YesNo(Console.ReadLine()))
            {
                Environment.Exit(0);
            }
            else
            {
                Run();
            }
    }

    public static bool YesNo(string userInput)
    {
        while (true)
        {
            if (userInput.ToLower() == "y")
            {
                return true;
            }
            else if(userInput.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid option. Please enter y/n");
                Thread.Sleep(1000);
                userInput = Console.ReadLine();
            }
        }
    }
}