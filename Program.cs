using System;
using System.Security.Cryptography.X509Certificates;

namespace FlowChart
{
    class Program
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

        start:
            if (x > 0)
            {
                if (y > 0)
                {
                    x = x - 1;
                    y = y - 1;
                    Console.Write("C");
                    goto start;
                }
                else
                {
                    Console.Write("D");
                }
                if (z > 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("G");
                }

            }
            else
            {
                Console.Write("E");
                Console.Write("G");
                Console.WriteLine();
            }


        }
    }
}

// while | Do while

using System;
using System.Security.Cryptography.X509Certificates;

namespace FlowChart
{
    class Program
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            while (x > 0)
            {
                if (y > 0)
                {
                    x = x - 1;
                    y = y - 1;
                    Console.Write("C");
                }
                else
                {
                    if (y <= 0)
                    {
                        Console.Write("D");

                        if (z > 0)
                        {
                            Console.Write("");
                        }
                        else
                        {
                            Console.Write("G");
                            Console.Write("");
                        }
                        return;
                    }
                    return;
                }

            }

            Console.Write("E");
            Console.Write("G");
        }
    }
}

// for 

using System;
using System.Security.Cryptography.X509Certificates;

namespace FlowChart
{
    class Program
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            for (int i = 0; x > 0 && y > 0; i++)
            {
                x = x - 1;
                y = y - 1;
                Console.Write("C");
            }
            if (x > 0)
            {
                if (y <= 0)
                {
                    Console.Write("D");
                    if (z > 0)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("G");
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.Write("E");
                Console.Write("G");
                Console.WriteLine();
            }

        }
    }
}