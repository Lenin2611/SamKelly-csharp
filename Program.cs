internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        int sam = 0;
        int kelly = 0;
        int days = 0;
        Console.Write("Sam Daily: ");
        int samDaily = int.Parse(Console.ReadLine());
        Console.Write("Kelly Daily: ");
        int kellyDaily = int.Parse(Console.ReadLine());
        Console.Write("Difference: ");
        int difference = int.Parse(Console.ReadLine());
        sam += difference;
        if (samDaily > 0 && samDaily < 100 && kellyDaily > 0 && kellyDaily < 100 && difference >= 0 && difference < 100)
        {
            while (sam >= kelly)
            {
                days += 1;
                sam += samDaily;
                kelly += kellyDaily;
            }
            Console.WriteLine($"\n{days}");
        }
        else
        {
            Console.WriteLine(-1);
        }
    }
}