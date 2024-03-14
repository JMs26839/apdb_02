public class Program2
{
    public static void Main(string[] Args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(Avg(new[] { 1, 2, 3, 4 }));
        Console.WriteLine(Max(new[] { 1,5,6,2, 3, 4 }));
    }
   
    public static double Avg(int[] a)

    {
        double sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }

        double avg = sum / a.Length;
        return avg;
    }


    public static int Max(int[] a)
    { 
        int max = a[0];
        for (int i = 0; i < a.Length; i++)
        {
           
            int temp = a[i];
          
            if (max<=temp)
            {
                max = a[i];
               

            }
           
        }

        return max;
    }
}