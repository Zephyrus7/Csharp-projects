using System;

namespace Assignment2
{
    public class Program
    {
        #region Hidden

        public static void Main(string[] args)
        {
            string number;
            do
            {
                Console.Write("Enter the number (1-7) for the question to run or 0 to exit: ");
                number = Console.ReadLine();
                ShowTitle(number);

                switch (number)
                {
                    case "1":
                        Question1();
                        break;
                    case "2":
                        Question2();
                        break;
                    case "3":
                        Question3();
                        break;
                    case "4":
                        Question4();
                        break;
                    case "5":
                        Question5();
                        break;
                    case "6":
                        Question6();
                        break;
                    case "7":
                        Question7();
                        break;
                }
            } while (number != "0");
        }

        public static void ShowTitle(string number)
        {
            Console.Clear();
            Console.WriteLine("Question {0}", number);
            Console.WriteLine("------------");
            Console.WriteLine();
        }
        
        #endregion

        /// <summary>
        /// Write code to prompt the user to enter their first name, middle initial
        /// and last name. Then read their input and display the user's name three 
        /// times using the following three formats:
        ///     first last
        ///     first middle last
        ///     last, first middle
        /// </summary>
        
        ///H.A.E
        
        public static void Question1()
        {
            
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What is your middle name? ");
            string middleName = Console.ReadLine();

            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            Console.Write(firstName +" "+ lastName);
            Console.WriteLine();
            Console.Write(firstName + " " + middleName + " " + lastName);
            Console.WriteLine();
            Console.Write(lastName + "," + " " + firstName + " " + middleName);
            



        }

        /// <summary>
        /// Write code to prompt the user for two integers. Then read their input and
        /// display the sum and the difference of the two integers.
        /// </summary>
        public static void Question2()
        {

            Console.Write("Please provide two integers to continue");
            Console.WriteLine();
           
            Console.Write("Provide integer No.1" + " : ");
            string Input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(Input1);

            Console.WriteLine();

            Console.Write("Provide integer No.2" + " : ");
            string Input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(Input2);

            Console.WriteLine();

            int sum = number1 + number2;
            int diff = number1 - number2;

            Console.Write(sum);
            Console.WriteLine();
            Console.Write(diff);


        }

        /// <summary>
        /// Write code to calculate the area of a circle. The user will enter the radius
        /// of the circle and the program will calculate and display the area. 
        /// You must accept decimal places as input.
        /// Formula: area = 3.14 * radius * radius
        /// </summary>
        public static void Question3()
        {
            Console.Write("Please provide radious to continue: ");
            
            double radius = Convert.ToDouble(Console.ReadLine());
            double Area = 3.14 * radius * radius;
            
            Console.WriteLine("Area of the circle: " + Area);
            Console.ReadKey();


        }
        

        /// <summary>
        /// Write code to prompt the user to enter a single character. Then read their 
        /// input and display the following message: You entered <char>
        /// For this question, you must use a variable of type char.
        /// </summary>
        public static void Question4()
        {

          Console.Write("Please provide a single character to continue: ");
          string characterInput = Console.ReadLine();
            char userChar = Convert.ToChar(characterInput);

            Console.WriteLine("You entered " + userChar);
            
        }

        /// <summary>
        /// Write code to ask the user a simple true or false question and then read
        /// their answer. The code should then display the message: Your answer was <bool>
        /// For this question, you must use a variable of type boolean.
        /// </summary>
        public static void Question5()
        {
           
            Console.WriteLine("Lorem Ipsum is a placeholder text");
            Console.WriteLine("");
            Console.WriteLine("Decide whether if this argument is true or false with True/False ");
        
            Boolean TorF = Convert.ToBoolean(Console.ReadLine());
            
                
            

                         
        }

        /// <summary>
        /// Write code to prompt the user to enter how many siblings they have.
        /// Then read their input and display a message saying: I also have <int> siblings
        /// </summary>
        public static void Question6()
        {
            Console.WriteLine("How many siblings do you have? ");
            string siblingCount= Console.ReadLine();
            int siblings = Convert.ToInt32(siblingCount);

            
            Console.Write("I also have" + " " + siblings + " " + "siblings.");
            Console.WriteLine(" What a coincidence!");


        }

        /// <summary>
        /// Adult tickets cost $3.75 and child tickets cost $2.25. Write code to prompt 
        /// the user for the number of adult tickets and the number of child tickets 
        /// that they want. Then display the total cost.
        /// </summary>
        public static void Question7()
        {
            Console.WriteLine("How many tickets would you like?");
            Console.WriteLine();
            
                string adultTicketCount = Console.ReadLine();
                Console.WriteLine();
                string childTicketCount = Console.ReadLine();


        }
    }
}
