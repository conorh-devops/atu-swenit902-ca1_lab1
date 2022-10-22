Console.WriteLine("Please enter your name:");

string username = Console.ReadLine();

if (username == null || username == "")
    Console.WriteLine("Goodbye!");
else
    Console.WriteLine("Hello {0}!", username);

Console.ReadKey();
