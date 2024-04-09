// See https://aka.ms/new-console-template for more information
namespace Collections
{
    class Program
    {
        static void Main(String[] args)
        {
            // 1st Way to intialize an array. The following array will have 5 index
            int[] array1 = new int[5];

            // 2nd way to initalize an array
            int[] array2 = { 1, 2, 3, 4, 5 };

            // 3rd way to initalize an array
            int[] array3 = new int[] {1, 2, 3, 4, 5 };

            int[,] array2D = new int[,]
            {
                {1,2,3},
                {4,5,6},
                {5,6,7}
            };
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    if (array2D[i,j] % 2 != 0)
                    {
                        Console.WriteLine(array2D[i, j]);
                    }
                }    
            }
            
        }   
    }
}