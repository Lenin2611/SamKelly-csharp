# Sam y Kelly

1. Complete the function minNum in the editor below.
   MinNum has the following parameter(s):
   SamDaily: Number of problems Sam solves in a day
   KellyDaily: Number of problems Kelly solves in a day
   Difference: Number of problems Sam isa head to begin
   Return Int: the minimum number of days needed by Kelly to exceed Samm, or -1 if it is imposible
   Constraints
   • 1 ≤ 𝑠𝑎𝑚𝐷𝑎𝑖𝑙𝑦, 𝑘𝑒𝑙𝑙𝑦𝐷𝑎𝑖𝑙𝑦 ≤ 100
   • 0 ≤ 𝑑𝑖𝑓𝑓𝑒𝑟𝑒𝑛𝑐𝑒 ≤ 100

   ```c#
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
   ```

