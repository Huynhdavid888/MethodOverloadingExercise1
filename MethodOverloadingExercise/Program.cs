using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = num1 + num2;

            if (isTrue == true && sum > 1)
            {
                return $"{sum} dollars";
            }

            else if (isTrue == true && sum == 1)
            {
                return $"{sum} dollar";
            }

            else if (isTrue == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
        static void Main(string[] args)
        {
            var x = 12;
            var y = 35;

            var answer = Add(x, y);

            var a = 27.0m;
            var b = 15.0m;

            var decimalAnswer = Add(a, b);

            var thirdAnswer = Add(0, 0, true);

            Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
            Console.WriteLine(thirdAnswer);


        }
    }
}
