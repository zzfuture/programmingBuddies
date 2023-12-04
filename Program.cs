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