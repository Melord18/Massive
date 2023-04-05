namespace Array3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter numbers for massive :");

            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            Random random = new Random();
            int[][] array = new int[m][];

            for (int i = 0; i < m; i++)
            {
                array[i]= new int [n];
                for (int j = 0; j < n; j++)
                {
                    array[i][j] = random.Next(5,10);
                    Console.WriteLine($"{array[i][j]}");
                }
            }

            for (int i = 0;i < m; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    if (array[i][j] == k)
                    {
                        if (array[0][0] == k)
                        {
                            continue;
                        }
                        if (k == array[i][0])
                        {
                            array[i - 1][j] = 0; array[i][j - 1] = 0;
                        }
                        else
                        {
                            array[i][j - 1] = 0;
                        }

                    }
                }
            }
            for(int i = 0;i < m; i++)
            {
                for(int j = 0;j< n; j++)
                {
                    Console.WriteLine($"{array[i][j]}");    
                }
            }
        }
    }
}