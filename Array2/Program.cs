namespace Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter numbers for massive :");

            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            Random random = new Random();
            int[][] array = new int[m][];

            for (int i = 0; i < m; i++)
            {
                array[i] = int[n];
                for (int j = 0; j < n; j++)
                {
                    array[i][j] = random.Next(77.777);
                    Console.Writeline($"{array[i][j]}"); 
                }
            }
            int arr = 0;
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(i == k)
                    {
                        arr = arr + array[i][j];
                    }
                    else
                    {
                        Console.Writeline(" K in m is not founded !!!");
                    }
                }
            }
            Console.WriteLine($"{arr}");

        }
    }
}