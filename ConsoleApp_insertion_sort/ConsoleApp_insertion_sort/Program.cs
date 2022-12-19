using System;

namespace ConsoleApp_insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of element of array : ");
           int  n = int.Parse(Console.ReadLine());
            
            int[] array = new int[n];

            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter the element of index : "+i);
                array[i] = int.Parse(Console.ReadLine());

            }
            //array




            for (int i = 1; i < array.Length; i++)
            {
                var key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                    array[j + 1] = key;

                }
            }
            Console.WriteLine("the sorting array :");
            for (int c = 0; c < array.Length; c++)
            {
                
                Console.Write(array[c] + " ");
           
            }
               
        }
    }
}
