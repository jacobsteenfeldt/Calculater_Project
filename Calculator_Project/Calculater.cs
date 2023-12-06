public class Calculator
{
    public string name;

    public bool truth;


    //calculating methods
    public int add(int a, int b)
    { return a + b; }

    public int subtract(int a, int b)
    { return a - b; }

    public int multiply(int a, int b)
    { return a * b; }

    public float divide(int a, int b)
    {
        float calc = Convert.ToSingle(a) / Convert.ToSingle(b);
        return calc;
    }

    public void run()
    {
        Console.WriteLine("I can add, subtract, multiply and divide numbers which would you like?");

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
        else if (answer == "subtract")
        {
            Console.WriteLine("Perfect then please enter your first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("and then your second number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The correct answer is " + subtract(a, b));
            Console.ReadLine();
        }
        else if (answer == "multiply")
        {
            Console.WriteLine("Perfect then please enter your first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("and then your second number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The correct answer is " + multiply(a, b));
            Console.ReadLine();
        }
        else if (answer == "divide")
        {
            Console.WriteLine("Perfect then please enter your first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("and then your second number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The correct answer is ");
            Console.WriteLine(divide(a, b));
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("I didn't understand that please be more specific!");
            run();
        }
    }

    public void rerun()
    {
        Console.WriteLine("Do you need me for more calculations?");
        string answer = Console.ReadLine();

        if (answer == "yes")
        {
            truth = true;
        }
        else if (answer == "no")
        {
            truth = false;
        }
        else 
        {
            rerun();
        }
    }
}