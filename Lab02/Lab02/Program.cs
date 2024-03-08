// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("MOD 1");
Console.WriteLine("MOD 2.1");
Console.WriteLine("MOD 3");
Console.WriteLine("MOD 4");

static double GetAvg(int[] aa)
{
    double avg = 0;
    for (int i = 0; i < aa.Length; i++)
    {
        avg += aa[i];
    }

    return avg / aa.Length;
}