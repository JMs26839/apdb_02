// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("MOD 1");
Console.WriteLine("MOD 2.1");
Console.WriteLine("MOD 3");
Console.WriteLine("MOD 4");
Console.WriteLine("==========================================");
static double GetAvg(int[] aa)
{
    double avg3 = 0;
    for (int i = 0; i < aa.Length; i++)
    {
        avg3 += aa[i];
    }

    return avg3 / aa.Length;
}
int[]nums= {1,2,3,4,5,6};
double av= GetAvg(nums);
Console.WriteLine(av);