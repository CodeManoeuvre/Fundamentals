//C3 program to demonstrate the
//Compile time initialization
using System;

namespace Variables
{

    
    class Program
    {

        //only declaring ,complier will
        //provide the default value 0 to it
        int y;
        static void Main(string[] args)
        {
            //compling time intializaion of variable x
            //assiging value 32 to x
            int x = 32;

            //printing the value
            Console.WriteLine("Value of x is " + x);


            //creating object to acces 
            //the variable
            Program f = new Program();



            //printing the value
            Console.WriteLine("Value of y is " + f.y);


         

            //Run Time Initialization

            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value of runtime initialization is :"+num1);
            Console.ReadLine();


        }
    }

   
}
