
//Data types specify the type of data that a value C# variable can hold
//Program to demonstrate 
//the data type

/**
 * Data types in c# is mainly divided into three categories
 * value Data types
 * Reference Data Types
 * Pointer Data type
 */
using System;

namespace DataTypes
{
class Program
{

    //Main function
    static void Main(string[] args)
    {
            
         
        char a = 'O';

        //Integer data types is generally
        //used for numeric values
        int i = 89;

        short s = 56;

        //this will give erro as number
        //is larger than short rangfe
        // short s1 =838383888383


        //long uses Integer values which
        //may signed or unsigened  
        long l = 4564;

   
            
                //declaring boolean
                bool b = true;
                if (b == true)
                {
                    Console.WriteLine("Hey this true");

                }



            

            decimal dec = 389.6m;

        Console.WriteLine("char" + a);
        Console.WriteLine("integer" + i);
        Console.WriteLine("short" + s);
        Console.WriteLine("long" + l);
        Console.WriteLine("Decimal" + dec);
        Console.ReadKey();
    }


}
  
}
