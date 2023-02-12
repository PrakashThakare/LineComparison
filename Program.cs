namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to Line Comparison");
            Console.Write("Enter Starting Point: ");
            Double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Ending Point: ");
            Double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Starting Point: ");
            Double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Ending Point: ");
            Double y2 = Convert.ToDouble(Console.ReadLine());

            Double Length = Math.Sqrt(Math.Pow((x2 - x1), 2) + (Math.Pow((y2 - y1), 2)));
            Console.WriteLine("Length is : " + Length);

            
            Console.ReadLine();
        }
    }
}