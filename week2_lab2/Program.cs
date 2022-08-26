using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
menu.Add("apple", 0.99m);
menu.Add("banana", 0.59m);
menu.Add("cauliflower", 1.59m);
menu.Add("dragonfruit", 2.19m);
menu.Add("elderberry", 1.79m);
menu.Add("figs", 2.09m);
menu.Add("grapefruit", 1.99m);
menu.Add("honeydew", 3.49m);

List<string> cart = new List<string>();
Console.WriteLine("Welcome to the market!");
bool redisplayFlag = true;
while (redisplayFlag == true)
{
    Console.WriteLine("Item\t\tPrice");
    Console.WriteLine("====================================");
    foreach (KeyValuePair<string, decimal> item in menu)
    {
        string menuItemFormatted = "";
        menuItemFormatted += string.Format("{0, -20}", item.Key);
        menuItemFormatted += string.Format("{0, 10}", item.Value);
        Console.WriteLine(menuItemFormatted);
    }
    bool validEntryFlag = false;
    while (validEntryFlag == false)
    {
        Console.WriteLine("What item would you like to order?");
        string itemEntry = Console.ReadLine().ToLower();
        if (itemEntry == null || itemEntry.Length == 0 || menu.ContainsKey(itemEntry) == false)
        {
            Console.WriteLine("That was not a valid entry.");
            Console.WriteLine("Please enter a valid item from the menu.");
            validEntryFlag = false;
        }
        else if (menu.ContainsKey(itemEntry))
        {
            validEntryFlag = true;
            cart.Add(itemEntry);
            Console.WriteLine("Would you like to add another item? Please enter y/n");
            string addAnotherItem = Console.ReadLine();
            if (addAnotherItem == "y")
            {
                redisplayFlag = true;
            }
            else
            {
                redisplayFlag = false;
            }
        }
    }
}
Console.WriteLine("Thanks for your order!");
Console.WriteLine("Here's what you got:");
List<decimal> sumValues = new List<decimal>();
foreach (var item in cart)
{
    foreach (var menuItem in menu)
        if (item == menuItem.Key)
        {
            string menuItemFormatted = "";
            menuItemFormatted += string.Format("{0, -10}", menuItem.Key);
            menuItemFormatted += string.Format("{0, 10}", menuItem.Value);
            Console.WriteLine(menuItemFormatted);
            sumValues.Add(menuItem.Value);
        }

}
var total = sumValues.Sum();
Console.WriteLine($"Your total is: ${total}");

