using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha
{
    class Program
    {
        static void SR02()
        {
            Console.WriteLine("--------");
            Console.WriteLine("|      |");
            Console.WriteLine("|      |");
            Console.WriteLine("|      |");
            Console.WriteLine("--------");
            Console.WriteLine("");
            Console.WriteLine("\\");
            Console.WriteLine("|\\");
            Console.WriteLine("| \\");
            Console.WriteLine("|  \\");
            Console.WriteLine("|   \\");
            Console.WriteLine("|    \\");
            Console.WriteLine("|     \\");
            Console.WriteLine("--------");
            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("|      |");
            Console.WriteLine("|      |");
            Console.WriteLine("|      |");
            Console.WriteLine("|      |");
            Console.WriteLine("|      |");
            Console.WriteLine("|      |");
            Console.WriteLine("--------");
        }

        static void SR03()
        {
            Console.WriteLine("On the first day we had orientation. We got into groups and learnt about eachother and Techtorium. There was also a pizza lunch");
        }

        static void SR04()
        {
            Console.WriteLine("Confidence: 6");
            Console.WriteLine("Creativity: 7");
            Console.WriteLine("Resilience: 5");
            Console.WriteLine("Positivity: 6");
            Console.WriteLine("Hard Work: 7");
            Console.WriteLine("Love For Programming: 10");
        }

        static void SR05()
        {
            Console.Write("Name: ");
            Console.ReadLine();
            Console.Clear();

            Console.Write("School: ");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Techtorium ID: ");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Trainer Name: ");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Contact Number: ");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Hobbies: ");
            Console.ReadLine();
            Console.Clear();
        }

        static void SR06()
        {
            Console.Write("How old are you: ");
            int YourAge = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("How old is the person sitting next to you: ");
            int ThierAge = Convert.ToInt32(Console.ReadLine());

            if (YourAge > ThierAge)
                Console.WriteLine("You are older! :)");

            else if (ThierAge > YourAge)
                Console.WriteLine("They are older :(");

            else if (YourAge == ThierAge)
                Console.WriteLine("You are both the same age :|");

            else
                Console.WriteLine("An error has occured, can you try again?");
        }

        static void SR07()
        {
            Console.Write("How old are you: ");
            int YourAge = Convert.ToInt32(Console.ReadLine());

            if (YourAge >= 18)
                Console.Write("You are eligible for voting! :)");

            else
                Console.WriteLine("You are not eligible for voting :(");
        }

        static void SR08()
        {
            Console.Write("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
                Console.Write("This number is positive! :)");

            else if (num < 0)
                Console.Write("This number is negative :(");

            else if (num == 0)
                Console.Write("This number is not positive or negative :|");
        }

        static void SR09()
        {
            int DavidAge = 19;
            int LukeAge = 17;

            int AgeDiff = DavidAge - LukeAge;
            string sAgeDiff = Convert.ToString(AgeDiff);

            Console.Write("Luke is " + sAgeDiff + " years younger than David");
        }

        static void SR10()
        {
            Console.Write("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
                Console.Write("This number is not even or odd :|");

            else if (num % 2 == 0)
                Console.Write("This number is even! :)");

            else if (num % 2 == 1)
                Console.Write("This number is odd :(");

        }

        static void SR11()
        {
            Console.Write("Please enter your mark: ");
            int Mark = Convert.ToInt32(Console.ReadLine());

            if (Mark < 0)
                Console.Write("Invaild score");

            else if (Mark >= 85)
                Console.Write("You got an A! :)");

            else if (Mark >= 70)
                Console.Write("You got an B! :)");

            else if (Mark >= 55)
                Console.Write("You got an C! :)");

            else if (Mark >= 40)
                Console.Write("You got an D :(");

            else if (Mark >= 25)
                Console.Write("You got an E :(");

            else if (Mark < 25)
                Console.Write("You got an F :((");

            else
                Console.Write("Invalid score");
        }

        static void SR12()
        {
            Console.Write("Enter your first number: ");
            float num1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Enter your second number: ");
            float num2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Enter your operator: ");
            string sign = Convert.ToString(Console.ReadLine());
            Console.Clear();

            if (sign == "+")
                Console.Write(num1 + num2);

            if (sign == "-")
                Console.Write(num1 - num2);

            if (sign == "*")
                Console.Write(num1 * num2);

            if (sign == "/")
                Console.Write(num1 / num2);
        }

        static void SR13()
        {
            Console.Write("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            int DigitAdd = 0;

            while (num > 0)
            {
                DigitAdd = DigitAdd + (num % 10);
                num = num / 10;
            }
            Console.Write(DigitAdd);
        }

        static void SR14()
        {
            Console.Write("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int numReverse = 0;
            int LastDigit = 0;
            int reverse = 0;

            while (num > 0)
            {
                LastDigit = num % 10;
                reverse = reverse * 10 + LastDigit;
                num = num / 10;
            }
            Console.WriteLine(reverse);
        }

        static void SR15()
        {
            int x = 0;
            
            while (x == 0)
            {
                Console.Clear();
                Console.Write("Choose your move (Rock (r), Paper (p), Scissors (s): ");
                char choice = Convert.ToChar(Console.ReadLine());
                Console.Clear();

                Random rnd = new Random();
                int randNum = rnd.Next(1, 4);
                // 1 is rock
                // 2 is paper
                //3 is scissors

                if (choice == 'r')
                {
                    if (randNum == 1)
                        Console.Write("Tie! :|\nComputer chose rock");

                    else if (randNum == 2)
                        Console.Write("You win! :)\nComputer chose rock");

                    else if (randNum == 3)
                        Console.Write("You lose! :(\nComputer chose rock");
                }

                else if (choice == 'p')
                {
                    if (randNum == 1)
                        Console.Write("You lose! :(\nComputer chose paper");

                    else if (randNum == 2)
                        Console.Write("Tie! :|\nComputer chose paper");

                    else if (randNum == 3)
                        Console.Write("You win! :)\nComputer chose paper");
                }

                else if (choice == 's')
                {
                    if (randNum == 1)
                        Console.Write("You won! :)\nComputer chose scissors");

                    else if (randNum == 2)
                        Console.Write("You lose! :(\nComputer chose scissors");

                    else if (randNum == 3)
                        Console.Write("Tie! :|\nComputer chose scissors");
                }

                Console.Write("\n\nDo you want to play again? (y/n) ");
                char playAgain = Convert.ToChar(Console.ReadLine());

                if (playAgain == 'y')
                    x = 0;

                else
                    x = 1;

                    
            }
        }

        static void Main(string[] args)
        {
            Console.Write("What project would you like to use: SR");
            string ProjectChoice = Convert.ToString(Console.ReadLine());

            switch (ProjectChoice)
            {
                case "02":
                    Console.Clear();
                    SR02();
                    break;

                case "03":
                    Console.Clear();
                    SR03();
                    break;

                case "04":
                    Console.Clear();
                    SR04();
                    break;

                case "05":
                    Console.Clear();
                    SR05();
                    break;

                case "06":
                    Console.Clear();
                    SR06();
                    break;

                case "07":
                    Console.Clear();
                    SR07();
                    break;

                case "08":
                    Console.Clear();
                    SR08();
                    break;

                case "09":
                    Console.Clear();
                    SR09();
                    break;

                case "10":
                    Console.Clear();
                    SR10();
                    break;

                case "11":
                    Console.Clear();
                    SR11();
                    break;

                case "12":
                    Console.Clear();
                    SR12();
                    break;

                case "13":
                    Console.Clear();
                    SR13();
                    break;

                case "14":
                    Console.Clear();
                    SR14();
                    break;

                case "15":
                    Console.Clear();
                    SR15();
                    break;

            }
            Console.ReadKey();
        }

    }
}
