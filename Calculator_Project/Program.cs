class program
{
    
    static void Main(string[] args)
    {
        Calculator cal01 = new Calculator();

        Console.WriteLine("Welcome to your claculator!\nWhat is your name?");
        cal01.name = Console.ReadLine();
        cal01.truth = true;

        Console.WriteLine("\nNice to meet you " + cal01.name);

        

        while (cal01.truth == true)
        {
            cal01.run();
            cal01.rerun();
        }

    }
}