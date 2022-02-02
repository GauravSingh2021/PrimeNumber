using System; 

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number:");
            int num=int.Parse(Console.ReadLine());
            int count=0;

            for (int i = 1 ; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                    
                }
            }
            if (count == 2)
            {
                Console.WriteLine(num + " is Prime Number");
            }
            else
            {
                Console.WriteLine(num + " is Not prime Number");

            }
            Console.ReadLine();

        }
    }
}
