using System;

namespace Program
{
    class Program
    {
        static int ArrayMaxResult(int[] arr,int SelectValue)
        {
            int count = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] == SelectValue)
                    count++;
            }
            return SelectValue * count;
        }
        static void Main(string[] args)
        {
            int[] arr=new int[5];
            int select;
            int addItem;
            //Inisial array
            Console.WriteLine("Please enter array items, its should be 5 items between 1-10 :");
            for (int i = 0; i < arr.Length; i++)
            {
                addItem = int.Parse(Console.ReadLine());
                try
                {
                    if (addItem >= 1 && addItem <= 10)
                        arr[i] = addItem;
                    else throw new ArgumentOutOfRangeException("Your Number it should be between 1-10");


                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
          }
            //chose a number from array
            Console.WriteLine("Please chose a number from this array :");
            for (int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
            //check if the number inside the array
                try
                {
                select = int.Parse(Console.ReadLine());
                var result = Array.Find(arr, element => element == select);
                if (result != 0) {
                    Console.WriteLine("your score: " + ArrayMaxResult(arr, select));
                }
                else throw new Exception("not inside the array");



                }
                catch(Exception e)
                {
                Console.WriteLine(e.Message);
            }
           



        }
    }
}
