using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desmos_to_excel
{
    internal class desToExc
    {
        public void input(string fred)
        {
            char[] greg = fred.ToCharArray();
            char[] one = powerhandler(greg);
            char[] two = deleter(one);
            char[] three = fractionhandler(two);
            finisher(three);
        }
        public char[] finisher(char[] fred)
        {
            for (int i = 0; i < fred.Length; i++)
            {
                if (fred[i] == '{')
                {
                    fred[i] = '(';
                }
                if (fred[i] == '}')
                {
                    fred[i] = ')';
                }
            }
            Console.WriteLine(fred);
            return fred;
        }
        public char[] fractionhandler(char[] drew)
        {
            string fred = new string(drew);
            for (int i = 0; i < fred.Length; i++)
            {
                if (fred[i] == '}')
                {
                    if (i + 1 != fred.Length)
                    {
                        if (fred[i+1] == '{')
                        {
                            fred = fred.Remove(i, 2);
                            fred = fred.Insert(i, ")/(");
                        }
                    }
                    
                }
            }
            Console.WriteLine(fred);
            return fred.ToCharArray();
        }
        public char[] deleter(char[] drew)
        {
            string fred = new string(drew);
            for (int i = 0; i < fred.Length; i++)
            {

                if (fred[i] == '\\')
                {
                    if (fred[i + 1] == 'r')
                    {
                        fred = fred.Remove(i, 6);
                    }
                    else if (fred[i + 1] == 'c')
                    {
                        fred = fred.Remove(i, 5);
                        fred = fred.Insert(i, "*");
                    }
                    else if (fred[i + 1] == 's')
                    {
                        fred = fred.Remove(i, 1);
                    }
                    else
                    {
                        fred = fred.Remove(i, 5);
                    }
                }
            }
            Console.WriteLine(fred);
            return fred.ToCharArray();
        }
        public char[] powerhandler(char[] fred)
        {
            for (int i = 0; i < fred.Length; i++ )
            {
                
                if (fred[i] == '^')
                {
                    fred[(i + 1)] = ('(');
                    bool found = false;
                    for (int j = i; j < fred.Length; j++)
                    {
                        if (found == false)
                        {
                            if ((fred[j] == '}'))
                            {
                                fred[(j)] = (')');
                                found = true;
                            }
                        }
                        
                    }
                }
            }
            Console.WriteLine(fred);
            return fred;
        }
    }
}
