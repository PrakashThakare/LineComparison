namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Starting Point: ");
            Double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Ending Point: ");
            Double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Starting Point: ");
            Double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Ending Point: ");
            Double y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Ending Point: ");
            Double x3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Ending Point: ");
            Double x4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Starting Point: ");
            Double y3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Ending Point: ");
            Double y4 = Convert.ToDouble(Console.ReadLine());

            Double Length1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + (Math.Pow((y2 - y1), 2)));
            Double Length2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + (Math.Pow((y3 - y4), 2)));

            if (Length1 == Length2)
            {
                Console.WriteLine("Length is Equal : " + Length1);
            }
            else
            {
                Console.WriteLine("Length is Not Equal : " + Length1 + " \n" + Length2);
            }


            Console.ReadLine();
        }
    }
}