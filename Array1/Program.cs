namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine(" Enter two numbers for massive ");

            // mxn o'lchovli massive ichidan eng kattasi va kichigini aniqlaydigan dastur .

            int.TryParse(Console.ReadLine(),out int first);
            int.TryParse(Console.ReadLine(), out int second);
           
            Maxminarray(ref first, ref second);
        }
            public static void Maxminarray( ref int first , ref int second)
        {
            Random random = new Random();
               
            int[][] array = new int[first][];

            int max= 0,min=0;
            
          
            for (int i = 0; i < first; i++)
            {
                array[i] = new int[second];

                for (int j = 0; j < second; j++)
                {
                    array[i][j]  = random.Next(0,100);
                   
                }
            }
             
            for(int i = 0; i < first;i++)
            {
                for     (int j = 0;j < second; j++)
                {
                    if (max <= array[i][j])
                    {
                        max = array[i][j];
                        
                    }
                    if (min >= array[i][j])
                    {
                        min = array[i][j];
                        
                    }
                }
            }
            Console.WriteLine("Max number in massive : " + max);
            Console.WriteLine("Min number in massive : " + min);
            Console.WriteLine();


        }
    
        
    }
}