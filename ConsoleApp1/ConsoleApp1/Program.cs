
Console.WriteLine("Hello, World!");
x.B.SaySomething();

var average = x.B.countAverage(new int[] { 1, 2, 3, 4, 5, 6});
Console.WriteLine(average);
namespace x
{
    class B
    {
        public static void SaySomething()
        {
            Console.WriteLine("Hello Hello APBD");
        }

        public static double countAverage(int[] x) { 
            double sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum+= x[i];
            }
            return sum / x.Length;
        }
    }
}

