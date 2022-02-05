// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(String[] args )
    {
        Console.WriteLine(" ***** Five Star Bakery ");
        Console.WriteLine(" -  -   -   -   -   -   -   - ");
        Console.WriteLine("Customer Information");
        Console.WriteLine("Name ");
        var ccstnam = Console.ReadLine(); // customer name
        var dcrrnam = DateTime.Now; // current date
        Console.WriteLine("Order nr ");
        var ccstordnmb = 0;
        try
            {
                ccstordnmb = int.Parse(Console.ReadLine().ToString()); // receive number caracter, after cast to string
            }
        catch (System.Exception ex)
            {
                throw new ArgumentNullException("Valid integer number", ex);
            }
        Console.WriteLine("Product code and description ");
        var ccstordprd = Console.ReadLine();
        Console.Write($"\n - - - - - - - - - - - - - -");
        Console.Write($"\n * * * * *    Five Star Bakery ");
        Console.Write($"\n Date {dcrrnam}");
        Console.Write($"\n Customer {ccstnam}");
        Console.Write($"\n Order nr {ccstordnmb}");
        Console.Write($"\n Product nr {ccstordprd}");
        Console.Write($"\n Press any key to exit...");
        Console.ReadKey(true);
    }
}