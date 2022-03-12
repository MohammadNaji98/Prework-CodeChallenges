using System;

namespace Program
{
    class Program
    {
        static int ArrayMaxResult(int[] arr,int selectValue)
        {
            int count = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] == selectValue)
                    count++;
            }
            return selectValue * count;
        }
        static string LeapYearCalculator(int year)
        {
            if(year%4==0)
            {
                if (year % 100 == 0)
                {
                    if(year%400==0)
                    return "This year " + year + " is Leap";
                    else return "This year " + year + " is not Leap";

                }
                else return "This year " + year + " is Leap";
            }
            else return "This year " + year + " is not Leap";
        }
        static string PerfectSequence(int[] arr)
        {
            int sum = 0;
            int mult=1;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] > 0) {
                    sum += arr[i];
                    mult *= arr[i];
                }
                else return "This is not a Perfect Sequence Array";


            }
            if (sum == mult)
                return "This is a Perfect Sequence Array";
            else
                return "This is not a Perfect Sequence Array";
        }
        static void Main(string[] args)
        {

            // Challeange01 
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
            Console.WriteLine("");
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


            // Challeange02
            int year;
            Console.WriteLine("Please enter the year :");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine(LeapYearCalculator(year));

            // Challeange03
            int[] arrTest = new int[3];
            Console.WriteLine("Please enter the array item :");
            for (int i=0;i<arrTest.Length;i++)
            {
                arrTest[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(PerfectSequence(arrTest));
        }
    }
}
