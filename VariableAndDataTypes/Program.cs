using System;

namespace VariableAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            //--------------Built in datatypes

            // Numbers

            //1. int 2
            //int a = 1523416543;
            //Console.WriteLine(a);

            //2. long 
            //long b = -1;
            //Console.WriteLine(b);

            //3. float  12.5,56.7
            //float c = 1.676798799879889951234651423612536125371582318763812638128797979971f;
            //Console.WriteLine(c);

            //4. double 12.54646876456468
            //double d = 1.345345345345345345465768678;
            //Console.WriteLine(d);


            //b. Characters h,j,k,
            //char c = '9';
            //Console.WriteLine(c);

            //c. boolean true,false
            //bool booleanvar = false;
            //Console.WriteLine(booleanvar);

            //d. string my name is rajesh
            //string s = "my name is rajesh";
            //Console.WriteLine(s);

            //Variable names must be unique.
            //Variable names can contain letters, digits, and the underscore _ only.
            //Variable names must start with a letter.
            //Variable names are case-sensitive, num and Num are considered different names.
            //Variable names cannot contain reserved keywords. Must prefix @ before keyword if want reserve keywords as identifiers.


            //---------Custom DataTypes(we will learn this in future)


            //----Typecasting
            //Implicit  char -> int -> long -> float -> double
            //Explicit  double -> float -> long -> int -> char

            //char a = 'A';
            //int b = a;
            //Console.WriteLine(b);

            //int a = 100;
            //long b = a;
            //Console.WriteLine(b);

            //double a = 12.8967876878897;
            //float b = (float)a;
            //Console.WriteLine(b);

            //long a = 123456;
            //int b = (int)a;
            //Console.WriteLine(b);


            //double a = 123;
            //int b = Convert.ToInt32(a);
            //Console.WriteLine(b);

            //string inputvalue = Console.ReadLine();

            //Console.WriteLine(inputvalue);
        }
    }
}
