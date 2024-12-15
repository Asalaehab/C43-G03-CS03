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
            string word=Console.ReadLine();
            StringBuilder sb= new StringBuilder();
            foreach(char c in word ) {
                if(char.IsDigit(c)) 
                    sb.Append(c);
            }
            long num=long.Parse(sb.ToString());
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
          
            #endregion
        }
    }
}