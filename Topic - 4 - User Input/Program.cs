namespace Topic___4___User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Username;
            int age;
            double price;

            Console.WriteLine("Enter username:");
            Username = Console.ReadLine();
            Console.WriteLine("Your username is: " + Username);
            Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age));
            Console.WriteLine("Your age is " + age);
            Console.ReadLine();

            Console.WriteLine("What is the price?");
            Double.TryParse(Console.ReadLine(), out price);
            Console.WriteLine("The price is " + price.ToString("C"));

        }
    }
}
