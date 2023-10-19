namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region JaggedArray
            //int[][] arrays= new int[3][];
            //arrays[0] = new int[1];
            //arrays[1] = new int[2];
            //arrays[2] = new int[3];
            //Console.WriteLine();
            //arrays[0][0] = 1;
            //arrays[1][0] = 2;
            //arrays[1][1] = 2;
            //arrays[2][0]= 3;
            //arrays[2][1] = 3;
            //arrays[2][2] = 3;
            //Console.WriteLine(arrays[0][0]);//1
            //Console.WriteLine(arrays[1][1]);//2
            //Console.WriteLine(arrays[2][2]);//3

            #endregion

            #region Element qushish va uqish

            //int[][] arr = new int[3][];
            //arr[0] = new int[4];
            //arr[1] = new int[5];
            //arr[2] = new int[6];

            //Random rd = new Random();

            //for(int i=0; i<arr.Length; i++)
            //{
            //    for(int j=0; j < arr[i].Length; j++)
            //    {
            //        arr[i][j] = rd.Next(0,10);
            //    }

            //}
            //for(int i=0 ; i<arr.Length ; i++)
            //{
            //    for(int j=0; j < arr[i].Length; j++)
            //    {
            //        Console.Write($"a[{i}][{j}]={arr[i][j]}\t");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Massiv ulchami .Rank;
            int[,,] arr1 = new int[2, 3, 3];
            int[,,,,,,] arr2 = new int[1, 2, 3, 4, 5, 4, 3];
            int[,] arr3 = new int[3, 3] 
            { 
                { 1, 2, 3 }, 
                { 1, 2, 3 }, 
                { 1, 2, 3 } 
            };
            Console.WriteLine($"Massiv ulchami:{arr1.Rank}");
            Console.WriteLine($"Massiv ulchami:{arr2.Rank}");
            Console.WriteLine($"Massiv ulchami:{arr3.Rank}");
            

            #endregion
        }
    }
}