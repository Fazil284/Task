using System;
using System.Collections.Generic;
using System.Linq;

namespace Work3Project
{
    class Program
    {
        public static void Question1()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter the numbers:");
            for (int i = 0; i < 10; i++)
            {
                int s = Convert.ToInt32(Console.ReadLine());
                numbers.Add(s);
            }
            Console.WriteLine("The number divisible by 7 are listed below:");
            foreach (var i in numbers)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void Q2()
        {
            Console.WriteLine("Enter the minimum value");
            int starting_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the maximum value");
            int ending_no = Convert.ToInt32(Console.ReadLine());
            if (starting_no > ending_no)
            {
                Console.WriteLine("Invalid entry");
            }
            else
            {
                Console.WriteLine("The prime numbers between {0} and {1} are :", starting_no, ending_no);
                for (int i = starting_no; i <= ending_no; i++)
                {
                    int flag = 0;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                        Console.WriteLine(i);
                }
            }
        }
        public static void Q3()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter the numbers");
            while (true)
            {
                int i = Convert.ToInt32(Console.ReadLine());
                if (i < 0)
                    break;
                else
                    numbers.Add(i);
            }
            IEnumerable<int> duplicates = numbers.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key);
            Console.WriteLine("repeated elements are:");
            foreach (var item in duplicates)
            {
                Console.WriteLine(item);
            }
        }
        public static void Q4()
        {
                List<int> inputs = new List<int>();
                Console.WriteLine("enter inputs:");
            while(true)
            {
                int k = Convert.ToInt32(Console.ReadLine());
                if (k < 0)
                {
                    Console.WriteLine("Try to enter Positive integer");
                }
                else if (k>0)
                {
                    inputs.Add(k);
                    //var num = inputs.Select(s => s).OrderBy(s => s).ToList();
                }
                else if(k==0)
                {
                    break;
                }
            }
            var num = (from i in inputs
                       select i).OrderBy(i => i).ToList();
            foreach(var item in num)
            {
                Console.WriteLine(item);
            }

        }

        public static void Q5()
        {
            int count = 0;
            do
            {
                Console.WriteLine("Enter Username: ");
                string user = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                if (user == "Admin" && password == "admin")
                {
                    Console.WriteLine("Welcome");
                    break;
                }

                else
                {
                    Console.WriteLine("Inavalid username or password");
                    Console.WriteLine("Try Again");
                    count = count + 1;
                }
            } while (count < 3);
            if (count >= 3)
            {
                Console.WriteLine("Sorry you have already tried 3 times");
            }
        }

        public static void Q7()
        {
            Console.WriteLine("Please enter the Card Number");
            string Card_number = Console.ReadLine();
            if (Card_number.Length == 16)
            {
                Card_number = reverse(Card_number);
                Console.WriteLine(Card_number);
                string sum = Sumandmul(Card_number);
                Console.WriteLine(sum);
                string mod = ModAndCheck(sum);
                Console.WriteLine(mod);
            }
            else
                Console.WriteLine("Enter card length is 16");
        }
        private static string ModAndCheck(string sum)
        {
            int number = Convert.ToInt32(sum);
            if (number % 10 == 0)
                return "Valid Card";
            else
                return "Please verify correct number";
        }

        private static string reverse(string number)
        {
            string output = string.Empty;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                output += number[i];
            }
            return output;
        }
        private static string Sumandmul(string number)
        {
            int num_convert, mul_, sum = 0, even_sum = 0, odd_sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                char v = number[i];
                num_convert = (int)Char.GetNumericValue(v);
                if ((i + 1) % 2 == 0)
                {
                    mul_ = num_convert * 2;
                    if (mul_ >= 10)
                    {
                        while (mul_ > 0)
                        {
                            int n = mul_ % 10;
                            even_sum += n;
                            mul_ = mul_ / 10;
                        }
                    }
                    else
                        even_sum += mul_;
                }
                else
                {
                    odd_sum += num_convert;
                }
                sum = even_sum + odd_sum;
            }
            return Convert.ToString(sum);
        }

        static void PrintMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Question1-Divisible by 7");
                Console.WriteLine("2.Question2-Print all prime numbers within the range");
                Console.WriteLine("3.Question3-Print numbers that are repeating");
                Console.WriteLine("4.Question4-Numbers in ascending order");
                Console.WriteLine("5.Question5-Login details Program");
                //Console.WriteLine("6.Question6-Cow and bull Game");
                Console.WriteLine("7.Question7-Credit card validation.");
                Console.WriteLine("8.Exit");
                Console.WriteLine("Enter the number to run the code");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Question1();
                        break;
                    case 2:
                        Q2();
                        break;
                    case 3:
                        Q3();
                        break;
                    case 4:
                        Q4();
                        break;
                    case 5:
                        Q5();
                        break;
                    //case 6:
                    //    break;
                    case 7:
                        Q7();
                        break;
                    case 8:
                        Console.WriteLine("Exitting");
                        break;
                    default:
                        Console.WriteLine("Invalid entry");
                        break;
                }
            } while (choice != 8);
        }
        static void Main(string[] args)
        {
            
        }
    }
}
