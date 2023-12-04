# RETO 5 Programming Buddies



Can Kelly solve enough code challenges to catch up with Sam?

Sam and Kelly are programming buddies. Kelly resolves to practice more as Sam is ahead initially. They each solve a number of problems daily. Find the minimum number of days for Kelly to have solved more problems than Sam. If Kelly cannot surpass return -1.

**Example**

*samDaily = 3*

*kellyDaily = 5*

*difference = 5*

Initially, Sam has solved *difference* problems more than Kelly. Each day, they solve *samDaily* and *kellyDaily* problems each.

Day 1: *samSolved = difference + samDaily =* 5 + 3 = 8

_            kellySolved_ = _kellyDaily = _5

Day 2: *samSolved* = 8 + 3 = 11

_            kellySolved_ = 5 + 5 = 10

Day 3: *samSolved* = 11 + 3 = 14

_            kellySolved_ = 10 + 5 = 15

Sam is 5 problems ahead of Kelly and they solve 3 and 5 problems a day. Sam will be ahead by only 3 after the first day, 1 after the second, and Kelly will pass Sam on day 3.

**Function Description **

Complete the function *minNum* in the editor below.

minNum has the following parameter(s):

    *samDaily:*  Number of problems Sam solves in a day

    *kellyDaily:*  Number of problems Kelly solves in a day

    *difference_*:_  Number of problems Sam is ahead to begin

**Return**

    _int: _the minimum number of days needed by Kelly to exceed Sam, or -1 if it is impossible



```csharp
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("SamDaily: ");
        int SamDaily = int.Parse(Console.ReadLine());
        Console.Write("KellyDaily: ");
        int KellyDaily = int.Parse(Console.ReadLine());
        Console.Write("Difference: ");
        int Difference = int.Parse(Console.ReadLine());
        Console.WriteLine   (minNum(SamDaily,KellyDaily, Difference));
    }
    private static int minNum(int SamDaily, int KellyDaily, int Difference)
    {
        if ((SamDaily<1 || SamDaily>100) || (KellyDaily<1 || KellyDaily>100) || (Difference< 0 || Difference>100))
        {
            return -1;
        }
        else{
            int SamSolved = 0;
            SamSolved += Difference;
            int KellySolved = 0;
            bool loop = true;
            int days = 0;
            while(loop)
            {
                if (KellySolved > SamSolved)
                {
                    loop = false;
                    break; 
                }
                SamSolved += SamDaily;
                KellySolved += KellyDaily;
                days++;
            }
            return days;
        }
    }
}
```
