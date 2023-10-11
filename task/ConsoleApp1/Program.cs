namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {   //1
            //Console.WriteLine("Eded daxil edin: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i < number; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //1

            ////1
            //Console.WriteLine("Eded daxil edin: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int i = 0;

            //while (i <= number)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i+=7;
            //}
            ////1

            ////2
            //Console.WriteLine("Eded daxil edin: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int quantity = 0;

            //for (int i = 1; i < number; i++)
            //{
            //    if (i % 15 == 0)
            //    {
            //        Console.WriteLine(i);
            //        quantity++;
            //    }
            //}
            //Console.WriteLine(quantity);
            ////2

            ////3
            //int number = 42368;
            //int biggestDigit = 0;

            //for (int i = 1; i < 10; i++)
            //{

            //}
            ////3

            //4
            int number = 255;
            bool checker = false;

            for (int i = 2; i <= number; i *= 2)
            {
                Console.WriteLine(i);
                if (i == number)
                {
                    checker = true;
                }
            }
            Console.WriteLine(checker);
            //4

        }
    }
}

