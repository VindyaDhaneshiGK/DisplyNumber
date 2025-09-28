namespace DisplyNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            NumberDisplay numberDisplay = new NumberDisplay();  
            numberDisplay.DisplayNumbers();
            Console.ReadLine();
        }
    }
}
