using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
   class Program
    {
        private static IEnumerable<char> str;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine(Check(str));
            Console.ReadKey();
        }

        static bool Check(string st)
        { 
            Stack<char> stack = new Stack<char>(); 
            Dictionary<char, char> sk = new Dictionary<char, char>              
        {
            {'(',')'},
            {'{','}'},
            {'[',']'},
        };           
            foreach (char i in str)
            {
                if (i=='('||i=='{'||i=='[')
                    stack.Push(sk[i]);
                if (i == ')' || i == '}' || i == ']')
                    stack.Push(sk[i]);
                {                 
                    if (stack.Count==0|| stack.Pop()!=i)
                    { 
                        return false;
                    }
                }
            }                
                if (stack.Count == 0)
                return true;
                else
                return false;

        }

    }
}
