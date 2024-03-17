
Console.WriteLine("Hello new World");
x.B.SaySomething();

var average = x.B.countAverage(new int[] { 1, 2, 3, 4, 5, 6});
Console.WriteLine(average);

var max = x.B.getMaxElement(new int[] {0,7,-2,3,10,0,-2});
Console.WriteLine(max);

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

        public static int getMaxElement(int[] x) {
            int maxOfTab = x[0];
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > maxOfTab) { 
                    maxOfTab = x[i];
                }
            }
            return maxOfTab;
        }
    }
}
 
