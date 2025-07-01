using System.ComponentModel;

namespace Demo_C44_G01_C_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 1 
            /*1 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
                Example(1)
                Input: 12
                Output: Yes
                Example(2)
                Input: 9
                Output: No
            */

            //Console.WriteLine("please enter a number ..");

            //int number;

            //bool isParsed = int.TryParse(Console.ReadLine(), out number);


            //if (number%3 == 0 && number%4 == 0 )    
            //{
            //    Console.WriteLine("Yes");

            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}


            #endregion



            #region  Question 2
            // -Write a program that allows the user to insert an integer then
            // print negative if it is negative number otherwise print positive.

            Console.WriteLine("please enter a number ..");

            int number;

            bool isParsed = int.TryParse(Console.ReadLine(), out number);


            if (number < 0)
            {
                Console.WriteLine("negative");

            }
            else
            {
                Console.WriteLine("positive");
            }







            #endregion













        }


    }

}