using System;
class Program
{
    static void Main()
    {
        //Simple print statement
        Console.WriteLine("Hello C#");
        //write to console
        Console.WriteLine("Enter username");
        //Read to console
        string username = Console.ReadLine();
        //Placeholder
        Console.WriteLine("Hello {0}" , username);
        //Concantentation
        Console.WriteLine("Hello" + username);

        //Data Types
        //Integer Type
        int i = 0;
        Console.WriteLine("Min={0}", int.MinValue);
        Console.WriteLine("Max={0}", int.MaxValue);

        //Operators
        int num = 4;
        int den = 2;
        int result = num * den;
        Console.WriteLine("result={0}", result);

        //Nullable
        bool? areumajor = null;
        if (areumajor == true)
        {
            Console.WriteLine("user is major");
        }
        else if(areumajor == false)
        {
            Console.WriteLine("user is minor");
        }
        else
        {
            Console.WriteLine("user didn't answer question");
        }

        //Implicit conversion
        float f = 123.45f;
        int s = Convert.ToInt32(f);//explicit conversion
        Console.WriteLine(s);

        //Parse method
        string strnumber = "10";
        int j = int.Parse(strnumber);
        Console.WriteLine(j);

        //Arrays(collection of variables which belongs to similar data type)
        int[] evenno = new int[3];
        evenno[0] = 0;
        evenno[1] = 2;
        evenno[2] = 4;
        Console.WriteLine(evenno[2]);

        //Comments(ctrl+kc)
        //Console.WriteLine("Hello");single line comment
        /* Console.WriteLine("Hello"); 
         Console.WriteLine("Hello");*/ //multi line comment

        //Conditional statements(if,switch)
        //if else statement
        Console.WriteLine("Please enter number");
        int userno = int.Parse(Console.ReadLine());
        if (userno == 1)
        {
            Console.WriteLine("ur no is 1");
        }
        else if(userno == 2)
        {
            Console.WriteLine("ur no is 2");
        }
        else
        {
            Console.WriteLine("ur no doesn't exist");
        }
    
        //Switch Statment

        static void Main()
        {
            Console.WriteLine("Please enter a  number");
            int userno = int.Parse(Console.ReadLine());


        }







    }
}

