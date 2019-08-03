using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyAtoi("2983"));
        }

        public static int MyAtoi(string v)
        {
            List<int> listInt = new List<int>();
            int result = 0;
            for (int i = 0; i < v.Length; i++)
            {
                switch (v[i])
                {
                    case '0':
                        listInt.Add(0);
                        break;
                    case '1':
                        listInt.Add(1);
                        break;

                    case '2':
                        listInt.Add(2);
                        break;

                    case '3':
                        listInt.Add(3);
                        break;

                    case '4':
                        listInt.Add(4);
                        break;

                    case '5':
                        listInt.Add(5);
                        break;

                    case '6':
                        listInt.Add(6);
                        break;

                    case '7':
                        listInt.Add(7);
                        break;

                    case '8':
                        listInt.Add(8);
                        break;

                    case '9':
                        listInt.Add(9);
                        break;
                }
            }
            int num = 1;
            for (int i = listInt.Count - 1; i >= 0; i--)
            {
                listInt[i] = listInt[i] * num;
                result += listInt[i];
                num = num * 10;
            }
            return result;
        }
    }
}
