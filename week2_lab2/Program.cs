Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
menu.Add("apple\t", 0.99m);
menu.Add("banana\t", 0.59m);
menu.Add("cauliflower", 1.59m);
menu.Add("dragonfruit", 2.19m);
menu.Add("elderberry", 1.79m);
menu.Add("figs\t", 2.09m);
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
        Console.WriteLine($"{item.Key}\t{item.Value}");
    }
    bool validEntryFlag = false;
    while (validEntryFlag == false)
    {
        Console.WriteLine("What item would you like to order?");
        string itemEntry = Console.ReadLine().ToLower();
        if (itemEntry == null || itemEntry.Length == 0 || menu.ContainsKey(itemEntry) == false)
        {
            Console.WriteLine("That was not a valid entry.");
            Console.WriteLine("Please enter a valid item from ");
            validEntryFlag = false;
        }
        else if (menu.ContainsKey(itemEntry))
        {
            validEntryFlag = true;
            cart.Add(itemEntry);
        }


    }



}
