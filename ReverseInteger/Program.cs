using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(4589));
            Console.ReadLine();
        }

        static int Reverse(int x)
        {
            try
            {
                if (x < Int32.MinValue)
                {
                    return 0;
                }
                string input = Convert.ToString(x);

                int index = input.Length - 1;
                string reverse = "";


                for (int i = index; i >= 0; i--)
                {
                    if (input[i] == '-')
                    {
                        int revNegative = int.Parse(reverse) * -1;
                        return revNegative;
                    }
                    reverse += input[i];
                }
                int rev = int.Parse(reverse);

                return rev;
            }
            catch (OverflowException)
            {
                return 0;
            }
        }
    }
}
