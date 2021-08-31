using System;

namespace NestedIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=5, b=10, c=4;
            if (a>b)
            {
                if (a>c)
                {
                    Console.WriteLine("{0} is The largest",a);
                }
                else{
                    Console.WriteLine("{0} is The largest", c);
                }
            }
            else
            {
                if(b>c){
                    Console.WriteLine("{0} is The largest", b);
                }
                else
                {
                    Console.WriteLine("{0} is The largest", c);
                }
            }
        }
    }
}
