class program
{
    static void Main(string[] args)
    {
        Calculator cal01 = new Calculator();

        Console.WriteLine("Welcome to your claculator!\nWhat is your name?");
        cal01.name = Console.ReadLine();

        Console.WriteLine("\nNice to meet you " + cal01.name);

        cal01.run();

    }
}