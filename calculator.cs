using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdproject.Maths
{
    public class Calculator
    {
        public static int Add( int a, int b)
        {
            int number1 = a;
            int number2 = b;
            int answer = number1 + number2;
            return a + b;
        }
        public static int Substraction(int a , int b)
        {
            int number1 = a;
            int number2 = b;
            int answer = number1 - number2;
            return a - b; 
        }
        public static float Division(int a, int b)
        {
            float number1 = a;
            float number2 = b;
            float answer = number1 / number2;
            return answer; 
        }
        public static int Multiplication(int a, int b)
        {
            int number1 = a;
            int number2 = b;
            int answer = number1 * number2;
            return a * b;
        }
        public static int equoficient(int a, int b)
        {
            int number1 = a;
            int number2 = b;
            int answer = number1 % number2;
            return a * b;
        }
    }
}
