namespace Topic___4___User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Username, faveTopping, foodName;
            int age;
            double price, diameter, radius;

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
            Console.ReadLine();

            Console.WriteLine("Enter your favourite pizza topping " + Username);
            faveTopping = Console.ReadLine();
            Console.WriteLine("My favourite topping is also " + faveTopping + ", we have so much in common " + Username);
            Console.ReadLine();

            Console.WriteLine("Enter the item of what you want to buy, " + Username);
            foodName = Console.ReadLine();
            Console.WriteLine("Now whats the price of " + foodName + " " + Username);
            Double.TryParse(Console.ReadLine(), out price);
            Console.WriteLine("To get three " + foodName + "s it will cost " + (price * 3 ) + " do you have the money " + Username);
            Console.ReadLine();

            Console.WriteLine("Lets calculate the Radius of a circle");
            Console.WriteLine("Enter the diameter");
            Double.TryParse(Console.ReadLine(), out diameter);
            radius = diameter / 2;
            Console.WriteLine("The radius of your circle is " + radius);
            Console.ReadLine();
            Console.WriteLine("Good job " + Username);
            Console.ReadLine();

        }
    }
}
