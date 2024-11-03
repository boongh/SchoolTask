using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;

namespace SchoolTask
    {
    internal class Tasks
    {

        public static Queue<string> inputQueue = new Queue<string>(5);
        public static void InteruptlessInputThread()
        {
            Thread t = new Thread(() =>
            {
                while (true)
                {
                    string key = Console.ReadLine();
                    inputQueue.Enqueue(key);
                }
            });
            t.Start();
        }

        public static char[] ShuffleArray(char[] array, int times)
        {
            Random rnd = new Random();
            int random;
            for (int j = times; j >= 0; j--)
            {
                for (int i = array.Length - 1; i > 0; i--)
                {
                    random = rnd.Next(array.Length - 1);
                    char temp = array[i];
                    array[i] = array[random];
                    array[random] = temp;
                }
            }
            return array;
        }
        public static int[] ShuffleArray(int[] array, int times)
        {
            Random rnd = new Random();
            int random;
            for (int j = times; j >= 0; j--)
            {
                for (int i = array.Length - 1; i > 0; i--)
                {
                    random = rnd.Next(array.Length - 1);
                    int temp = array[i];
                    array[i] = array[random];
                    array[random] = temp;
                }
            }
            return array;

        }
        public static string[] ShuffleArray(string[] array, int times)
        {
            Random rnd = new Random();
            int random;
            for (int j = times; j >= 0; j--)
            {
                for (int i = array.Length - 1; i > 0; i--)
                {
                    random = rnd.Next(array.Length - 1);
                    string temp = array[i];
                    array[i] = array[random];
                    array[random] = temp;
                }
            }
            return array;

        }

        public static string ShuffleString(string stringIN, int times)
        {
            char[] array = stringIN.ToCharArray();
            Random rnd = new Random();
            int random;
            for (int j = times; j >= 0; j--)
            {
                for (int i = array.Length - 1; i > 0; i--)
                {
                    random = rnd.Next(array.Length - 1);
                    char temp = array[i];
                    array[i] = array[random];
                    array[random] = temp;
                }
            }

            return new string(array);
        }
        public static void Task1()
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter a number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x + y);

        }

        public static void Task2()
        {
            Console.WriteLine("Task 2");
            string aName = "";
            Console.Write("Type name: ");
            aName = Console.ReadLine();
            if (aName == "Bill" || aName == "Susan" || aName == "Fred")
            {
                Console.Write("Hi " + aName);
            }
            else
            {
                Console.Write("Go away!");
            }
            Console.ReadKey();

        }

        public static void Task3()
        {
            Console.WriteLine("Task 3");
            Console.WriteLine("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (((x + y) % 2) == 0)
            {
                Console.WriteLine("It's even!");
            }
            else
            {
                Console.WriteLine("It's odd!");
            }

        }

        public static void Task4()
        {
            Console.WriteLine("Task 4");
            Console.WriteLine("Enter a score out of 100:");
            int score = Convert.ToInt32(Console.ReadLine());
            switch (score)
            {
                case > 100:
                    Console.WriteLine("What");
                    break;
                case > 70:
                    Console.WriteLine("A");
                    break;
                case > 60:
                    Console.WriteLine("B");
                    break;
                case > 50:
                    Console.WriteLine("C");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }

        public static void Task5()
        {
            Console.WriteLine("Task 5");
            for (int i = 1; i <= 25; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public static void Task6()
        {
            Console.WriteLine("Task 6");
            Random random = new Random();
            int x = random.Next(0, 100);
            int guess = x + 1;
            do
            {
                Console.WriteLine("Guess a number: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess > x)
                {
                    Console.WriteLine("High");
                }
                else if (guess < x)
                {
                    Console.WriteLine("Low");
                }
                else if (guess == x)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            } while (guess != x);
        }

        public static void Task7()
        {
            Console.WriteLine("Task 7");
            Console.WriteLine("Think of a number between 0 - 100 and enter L if it's too low, H if it's too high, and C if it's correct");
            Random random = new Random();
            int top = 100;
            int low = 0;
            int guess = (top + low) / 2;
            string input = "";
            bool loop = true;
            do
            {
                Console.WriteLine("Is it " + guess);
                input = Console.ReadLine();
                switch (input)
                {
                    case "L":
                        low = guess;
                        guess = (top + low) / 2;
                        break;
                    case "H":
                        top = guess;
                        guess = (top + low) / 2;
                        break;
                    case "C":
                        Console.WriteLine("yay.");
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Error");
                        loop = false;
                        break;
                }
            } while (loop);
        }

        public static void Task8()
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(i + " - ");
                for (int j = 0; j <= array[i]; j++)
                {
                    Console.Write("|||||");
                }
                Console.WriteLine(array[i]);
                Console.WriteLine("");
            }
        }

        public static void Task9()
        {
            string[] insults = { "Fuck", "You", "I", "Bastard", "Stick" };
            Random rand = new Random();
            while (true)
            {
                if (inputQueue.Count > 0)
                {
                    if (inputQueue.Dequeue() == "q")
                    {
                        break;
                    }
                }
                Thread.Sleep(10);
                Console.Write(insults[rand.Next(5)] + " ");
            }

        }

        public static void Task9b()
        {
            Console.WriteLine("Task9b");
            string[] insults;
            string fName = @"..\..\..\rsc\insults.txt";
            insults = File.ReadAllLines(fName);
            Random rand = new Random();
            while (true)
            {
                if (inputQueue.Count > 0)
                {
                    if (inputQueue.Dequeue() == "q")
                    {
                        break;
                    }
                }
                Thread.Sleep(10);
                Console.Write(insults[rand.Next(insults.Length)] + " ");
            }
        }

        public static void Task9c()
        {
            Console.WriteLine("Task9c");
            string[] insults;
            try
            {
                string fName = @"..\..\..\rsc\insults.txt";
                insults = File.ReadAllLines(fName);
                Random rand = new Random();
                while (true)
                {
                    if (inputQueue.Count > 0)
                    {
                        if (inputQueue.Dequeue() == "q")
                        {
                            break;
                        }
                    }
                    Thread.Sleep(10);
                    Console.Write(insults[rand.Next(insults.Length)] + " ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR");
            }

        }

        public static void Task12()
        {
            Console.WriteLine("Task9d");
            Console.WriteLine("Guess the anagram");
            string[] topWords;
            string fName = @"..\..\..\rsc\Topthousandwords.txt";
            Random rand = new Random();
            try
            {
                topWords = File.ReadAllText(fName).Split(",");
                string oldWord = topWords[rand.Next(topWords.Length)];
                string newWord = ShuffleString(oldWord, 64);

                string guess = "";

                Console.WriteLine("Guess the anagram");
                do
                {
                    Console.WriteLine(newWord);
                    guess = Console.ReadLine();

                    if (guess == oldWord)
                    {
                        Console.WriteLine("yay");
                        break;
                    }
                    else if (guess == newWord)
                    {
                        Console.WriteLine("The word was " + oldWord);
                        break;
                    }

                } while (true);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }
        }


        public static string Task13(int decimalNumber)
        {
            char[] words = new char[32];
            int count = 31;
            while (decimalNumber != 0)
            {

                words[count] = (char)((decimalNumber & 1) + 48);
                decimalNumber = decimalNumber >> 1;
                count--;
            }
            return new string(words);

        }

        public static string Task13Test(int decimalNumber)
        {
            // Handle the special case of 0
            if (decimalNumber == 0)
            {
                return "0";
            }

            string binary = "";

            // Process the number until it becomes 0
            while (decimalNumber > 0)
            {
                // Get the remainder (0 or 1) and add it to the binary string
                int remainder = decimalNumber % 2;
                binary = remainder + binary;

                // Update the number by dividing it by 2
                decimalNumber /= 2;
            }

            return binary;
        }
        public static void Task14()
        {
            Random rnd = new Random();
            string lot = "";
            for (int i = 1; i <= 17; i++)
            {
                if (i % 3 == 0)
                {
                    lot = lot.Insert(0, "-");
                }
                else
                {
                    lot = lot.Insert(0, Convert.ToString(rnd.Next(0, 9)));
                }
            }
            Console.WriteLine(new string(lot));
            Console.WriteLine("Task14");
        }

        public static void RegexTutorial()
        {
            // Create a pattern for a word that starts with letter "B"  
            string pattern = "\\b[Bb]\\w+"; // note double \\ as \ is an escape character in strings
            Regex rg = new Regex(pattern);
            // check if string matches
            if (rg.IsMatch(" Bob "))
            {
                Console.WriteLine("its a match");
            }
            string Names = "Bill Bob Mary Brian Susan Paul berni";
            // find a match
            Match firstmatch = rg.Match(Names);
            if (firstmatch != null)
            {
                Console.WriteLine(firstmatch.Value);
            }
            // Find all the matches
            MatchCollection MatchedNames = rg.Matches(Names);
            foreach (Match match in MatchedNames)
            {
                Console.WriteLine(match.Index + " " + match.Value);

            }

        }

        public static void Task15()
        {
            string pattern = @"\w+\b[@]\w+";

        }

        public static void Task17()
        {
            string[] staff = { "Anna", "Bob", "Carol" };
            int[,] quarterSales = {
                    { 100, 110, 120, 110},
                    { 350, 355, 360, 360 },
                    { 200, 210, 220, 220 }
                };
            int annualSales = 0;

            for (int i = 0; i < quarterSales.GetLength(0); i++)
            {
                Console.Write(staff[i] + " ");

                for (int j = 0; j < quarterSales.GetLength(1); j++)
                {
                    annualSales += quarterSales[i, j];
                    Console.Write(quarterSales[i, j] + " ");
                }

                Console.WriteLine("");
            }

            Console.WriteLine("Annual sale " + annualSales);
        }

        public static BitArray Task18(int limit, bool print)
        {
            BitArray allNum = new BitArray(limit, true);
            //Check for each multiples of i (at least 2i) starts at 2
            int checkBound = (int)Math.Sqrt(limit);
			for (int j = 4; j < limit; j += 2)
			{
				allNum[j] = false;
			}
			for (int i = 3; i <= checkBound; i += 2)
            {
                if (allNum[i])
                {
                    for (int j = i * i; j < allNum.Count; j = j + (i << 1)) 
                    {
                        allNum[j] = false;
                    }
                }
            }

            //Special Case 0 and 1
            allNum[0] = allNum[1] = false;
            if (print)
            {
                for (int k = 0; k < limit; k++)
                {
                    if (allNum[k]) {Console.WriteLine(k + " Is " + allNum[k]); } }
            }
            return allNum;
        }

        public static void Task20b()
        {
            right_angled_triangle newtriangle = new right_angled_triangle(4.0, 3.0);
            Console.WriteLine(newtriangle.Hypotneus());
        }
        public static void Task21()
        {
			SchoolTask.NumberSchool newNum = new SchoolTask.NumberSchool("8888", NumberSchool.allBases.Dec);
			Console.WriteLine(newNum.Bin());
			Console.WriteLine(newNum.Hex());
		}
	}
}
