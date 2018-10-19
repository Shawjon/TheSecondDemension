using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSecondDemension
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = new int[,]
            {
                    {5,-4,3,0} ,
                    {5,1,-2,-1},
                    {8,6,-7, 4},
                    {-2,1,-5,2},
            };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(grid[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == i)
                    {
                        Console.Write(grid[i, j] + " ");
                        sum = sum + grid[i, j];
                    }
                    else
                    {
                        Console.Write("x ");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine($"The sum of the diagonal is {sum}");
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j==i)
                    {
                        Console.Write(grid[i, j] + " ");
                        Console.WriteLine();
                    }
                    
                }
            }


            

        }
        static void getSum  ( Array[,] array)
        {
            Int32 sum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == i)
                    {
                        ///string b = (array[i, j]);
                        Console.Write(array[i, j] + " ");
                        var b = array.GetValue(i,j);
                        sum = sum + (int.Parse(b.ToString()));
                    }
                    else
                    {
                        Console.Write("x ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine($"The sum of the diagonal is {sum}");
        }
    }
    
    
}
