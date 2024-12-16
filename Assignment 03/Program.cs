using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1.Enter number from 
            int x;
            bool flag;
            do
            {
                Console.WriteLine("Enter the number : ");
                flag = int.TryParse(Console.ReadLine(), out x);
            } while (!flag);
            Console.WriteLine(x);
            #endregion

            #region Q2.convert into string
            Console.WriteLine("Enter a word : ");
            string word = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            foreach (char ch in word)
            {
                if (char.IsDigit(ch))
                    sb.Append(ch);
            }
            long num = long.Parse(sb.ToString());
            Console.WriteLine(num);
            Console.WriteLine("==============");

            #endregion

            #region Q3.simple arithematic
            Console.Write("Enter a decimal number: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Enter another decimal number: ");
            float n2 = float.Parse(Console.ReadLine());
            float sum = n1 + n2;
            float sub = n1 - n2;
            float multiply = n1 * n2;
            float divide = n1 / n2;
            float rem = n1 % n2;

            Console.WriteLine($"Sum: {sum}\nSubtraction: {sub}\nMultiplication: {multiply}\nDivision: {divide}\nRemainder: {rem}");
            Console.WriteLine("============================================");
            #endregion

            #region Q4.Extract a substring from a given string
            string str = "Route Acadamy";
            string substring = str.Substring(0, 5);
            Console.WriteLine(substring);
            #endregion

            #region Q5. Assigning one value type variable to another and modifying the value 
            int nn1 = 5;
            int nn2 = nn1;
            nn1++;
            Console.WriteLine(nn1);
            Console.WriteLine(nn2);
            #endregion

            #region Q6.Assigning one reference type variable to another and modifying 
            Point p1;
            Point p2;
            p1 = new Point();
            p1.x = 10; p1.y = 20;
            p2 = new Point();
            p2 = p1;
            p1.x = 25;
            Console.WriteLine(p2.x);
            #endregion

            #region Q7.take two string variables and print them as one variable
            Console.WriteLine("Enter first Word : ");
            string w1 = Console.ReadLine();
            Console.WriteLine("Enter second Word : ");
            string w2 = Console.ReadLine();
            string full_word = w1 + w2;
            Console.WriteLine(full_word);
            #endregion

            #region Q8.that calculates the simple interest given the principal amount
            Console.Write("Enter the principle :  ");
            int principal = int.Parse(Console.ReadLine());
            Console.Write("Enter the rate :  ");
            int rate = int.Parse(Console.ReadLine());
            Console.Write("Enter the time : ");
            int time = int.Parse(Console.ReadLine());
            int interest = principal * rate * time;
            Console.Write($"the interest is : {interest}");
            #endregion

            #region Q9.calculates the Body Mass Index 
            Console.Write("Enter the weight : ");
            float w = float.Parse(Console.ReadLine());
            Console.Write("Enter the height: ");
            float h = float.Parse(Console.ReadLine());
            float BMI = w / (h * h);
            Console.WriteLine($"BMI = {BMI}");
            Console.WriteLine("====================");
            #endregion

            #region Q10.ternary Operator
            Console.Write("Enter the temparuture : ");
            float temperature = float.Parse(Console.ReadLine());

            String reslt = temperature < 10 ? "Just Cold" : (temperature > 30 ? "Just Hot" : "Just Good");
            Console.WriteLine($"the temperature is :  {reslt}");
            #endregion

            #region Q.11 string interpolation
            //    .Write a program that takes the date from the user and displays it in various formats using string interpolation.
            //Ex:
            //            Today’s date : 20 , 11 , 2001
            //Today's date : 20 / 11 / 2001
            //Today's date : 20 – 11 – 2001

            int Day, Month, year;

            do
            {
                Console.Write("Enter day : ");
                flag = int.TryParse(Console.ReadLine(), out Day);
            } while (!flag);
            do
            {
                Console.Write("Enter Month : ");
                flag = int.TryParse(Console.ReadLine(), out Month);
            } while (!flag);

            do
            {
                Console.Write("Enter year : ");
                flag = int.TryParse(Console.ReadLine(), out year);
            } while (!flag);

            Console.WriteLine($"Today's date : {Day} , {Month} , {year}");
            Console.WriteLine($"Today's date : {Day} / {Month} / {year}");
            Console.WriteLine($"Today's date : {Day} - {Month} - {year}");
            #endregion

            #region Q12.- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            int n;
            do
            {
                Console.WriteLine("Enter a number");
                flag = int.TryParse(Console.ReadLine(), out n);
            } while (!flag);
            if (n % 3 == 0 && n % 4 == 0)
            {
                Console.WriteLine("yes");
            }
            else { Console.WriteLine("No"); }
            #endregion

            #region Q13.Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            int a;
            do
            {
                Console.WriteLine("Enter number : ");
                flag = int.TryParse(Console.ReadLine(), out a);
            } while (!flag);
            if (a > 0)
                Console.WriteLine("positive");
            else
                Console.WriteLine("negative");


            #endregion

            #region Q13.- Write a program that takes 3 integers from the user then prints the max element and the min element
            int nu1, nu2, nu3;
            do
            {
                Console.Write("Enter number 1: ");
                flag = int.TryParse(Console.ReadLine(), out nu1);
            } while (!flag);

            do
            {
                Console.Write("Enter number 2: ");
                flag = int.TryParse(Console.ReadLine(), out nu2);
            } while (!flag);

            do
            {
                Console.Write("Enter number 1: ");
                flag = int.TryParse(Console.ReadLine(), out nu3);
            } while (!flag);
            int max = Math.Max(nu1, Math.Max(nu3, nu2));
            int min = Math.Min(nu1, Math.Min(nu3, nu2));
            Console.WriteLine($"the max value is : {max}");
            Console.WriteLine($"the min value is : {min}");
            #endregion

            #region Q14.Write a program that allows the user to insert an integer number then check If a number is even or odd.

            int OddOrEven;
            do
            {
                Console.Write("Enter a number");
                flag = int.TryParse(Console.ReadLine(), out OddOrEven);
            } while (!flag);

            if (OddOrEven % 2 == 0)
                Console.WriteLine("Even ");
            else
                Console.WriteLine("odd");


            #endregion

            #region Q15.- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            Console.Write("Enter a char : ");
            char c = Console.ReadLine()[0];
            char cc = char.ToLower(c);


            if (cc == 'a' || cc == 'o' || cc == 'u' || cc == 'l' || cc == 'e')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
            #endregion

            #region Q16- Write a program to input the month number and print the number of days in that month
            int mm;
            do
            {
                Console.Write("Enter Month number : ");
                flag = int.TryParse(Console.ReadLine(), out mm);
            } while (!flag || mm > 12);

            if (mm % 2 == 0 && mm != 2)
                Console.WriteLine("Days in Month: 30");
            else if (mm == 2)
                Console.WriteLine("Days in Month:  28");
            else
                Console.WriteLine("Days in Month: 31");
            #endregion


            #region 17- Write a program to create a Simple Calculator
            int cal_n1, cal_n2;
            do
            {
                Console.Write("Enter the first number : ");
                flag = int.TryParse(Console.ReadLine(), out cal_n1);
            } while (!flag);

            do
            {
                Console.Write("Enter the first number : ");
                flag = int.TryParse(Console.ReadLine(), out cal_n2);
            } while (!flag);

            Console.WriteLine($"the sum is : {cal_n1 + cal_n2}");
            Console.WriteLine($"the subtraction is : {cal_n2 - cal_n1}");
            Console.WriteLine($"the multiply is : {cal_n1 * cal_n2}");
            Console.WriteLine($"the divide is :{cal_n2 / cal_n1}");
            #endregion


            #region 18.Write a program that allows the user to insert an integer then print all numbers between 1 to that number

            Console.WriteLine("Enter Number : ");
            int nnumber=int.Parse(Console.ReadLine());
            for(int i=1;i<=nnumber; i++)
            {
                Console.WriteLine(i);
            }   
            #endregion

            #region 19- Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            int requiredNumber;
            do
            {
                Console.Write("Enter the number : ");
                flag = int.TryParse(Console.ReadLine(), out requiredNumber);
            } while (!flag);

            for (int i = 1; i <= 12; i++)
            {
                Console.Write(i * requiredNumber);
            }
            Console.WriteLine();
            Console.WriteLine("========================");

            #endregion

            #region 20- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            int Number;
            do
            {
                Console.Write("Enter number");
                flag = int.TryParse(Console.ReadLine(), out Number);
            } while (!flag);

            for (int i = 1; i <= Number; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i);
            }
            Console.WriteLine();

            #endregion

            #region 21- Write a program that takes two integers then prints the power.
            int power, bas;
            int res = 1;
            Console.Write("Enter the base : ");
            bas = int.Parse(Console.ReadLine());
            Console.Write("Enter the power : ");
            power = int.Parse(Console.ReadLine());
            for (int i = 0; i < power; i++)
            {
                res = res * bas;
            }
            Console.WriteLine(res);
            #endregion


            #region Q22. Write a program to allow the user to enter int and print the REVERSED of it.

            Console.WriteLine("Enter the number you want to reverse : ");
           int _number=int.Parse(Console.ReadLine());
            int Ress = 0;
            while(_number>0)
            {
                Ress = Ress * 10 +_number%10;
                _number/=10;
            }
            Console.WriteLine(Ress);

            #endregion

            #region Q23. Write a program in C# Sharp to find prime numbers within a range of numbers.
            int prime;
            do
            {
                Console.Write("Enter number : ");
                flag = int.TryParse(Console.ReadLine(), out prime);
            } while (!flag);
            for (int i = 2; i < prime; i++)
            {
                int m = i / 2;
                bool f = true;
                for (int j = 2; j <= m; j++)
                {
                    if (i % j == 0) { f = false; break; }
                }
                if (f) Console.WriteLine(i);
            }

            #endregion

            #region Q24  . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //25%2 =>1
            //25/2  =>12
            // 12%2  => 0

            int dec_number;
            Console.WriteLine("Enter number ou want to convert to binary : ");
            dec_number = int.Parse(Console.ReadLine());
            StringBuilder binary = new StringBuilder();
            //int r=1;
            while (dec_number != 0)
            {
                binary.Append(dec_number % 2);
                dec_number = dec_number / 2;
            }
            string newbinary = new string(binary.ToString().Reverse().ToArray());
            Console.WriteLine(newbinary);
            #endregion

            #region Q25.Write a program in C# Sharp to find the sum of all elements of the array
            Console.Write("Enter the size of the array : ");
            int nSize = int.Parse(Console.ReadLine());
            int[] array = new int[nSize];
            for (int i = 0; i < nSize; i++)
            {
                Console.Write($"Enter the {i + 1} Element : ");
                int elemnet = int.Parse(Console.ReadLine());
                array[i] = elemnet;
            }
            int s = 0;
            for (int i = 0; i < nSize; i++)
                s += array[i];
            Console.WriteLine(s);
            #endregion
        }
    }
}