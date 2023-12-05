public class Calculator
{
    public string name;

    //calculating methods
    public int add(int a, int b)
    { return a + b; }

    public int subtract(int a, int b)
    { return a - b; }

    public int multiply(int a, int b)
    { return a * b; }

    public int divide(int a, int b)
    { return a / b; }

    public void run()
    {
        Console.WriteLine("Well i can add, subtract, multiply and divide numbers which would you like?");

        string answer = Console.ReadLine();

        if (answer == "add")
        {
            Console.WriteLine("Perfect then please enter your first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("and then your second number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of your numbers are " + add(a, b));
            Console.ReadLine();
        }
    }
}