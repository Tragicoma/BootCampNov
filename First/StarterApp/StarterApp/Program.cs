using System;
using System.Linq;

namespace StarterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your string containing brackets - (),{},[] :");
            string s = Console.ReadLine();


            for (int i = 0; i < s.Length; i++)
            {
                char x = '0';
                switch (s[i])
                {
                    case '(':
                         x = s.Substring(i).First(ch => ch == ')');
                        if(x == ')')
                        {
                            Console.WriteLine("+");
                        }
                        break;
                    case '[':
                         x = s.Substring(i).First(ch => ch == ']');
                        if (x == ']')
                        {
                            Console.WriteLine("+");
                        }
                        break;
                    case '{':
                            x = s.Substring(i).First(ch => ch == '}');
                            if (x == '}')
                            {
                            Console.WriteLine("+");
                            }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(s);

        }
    }
}
