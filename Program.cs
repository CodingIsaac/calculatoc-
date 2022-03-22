using thirdproject.Maths;

namespace ThirdProject
{

    class Program
    {
        static void Main(string[] args)
        {
            string restart_calculator = "no";
            string[] operator_array = new string[5] { "+", "-", "/", "%", "*" };
            int number1;
            int number2;

            do
            {
                Console.WriteLine("What do you want to calculate? (+, -, *, %, /)");
                string type_of_calculation = Console.ReadLine();

                while (!operator_array.Contains(type_of_calculation))
                {
                    Console.WriteLine("choose a valid operator!");
                    type_of_calculation = Console.ReadLine();
                    Console.WriteLine("Enter your first number");

                    string input = Console.ReadLine();
                    while (int.TryParse(input, out number1) == false)
                    {
                        Console.WriteLine("Ohh! an error occured, try again!");
                        input = Console.ReadLine();
                    }
                    number1 = Int32.Parse(input);
                    Console.WriteLine("Enter your second number");
                    input = Console.ReadLine();
                    while (int.TryParse(input, out number2) == false)
                    {
                        Console.WriteLine("An error occured, try again with a number :P");
                        input = Console.ReadLine();
                    }
                    number2 = Int32.Parse(input);

                    if (type_of_calculation == "+")
                    {
                        Console.WriteLine("The Answer is " + Calculator.Add(number1, number2));
                        Console.WriteLine("type 'yes' to restart the calculation ");
                        restart_calculator = Console.ReadLine();
                    }
                    if (type_of_calculation == "-") ;
                    {
                        Console.WriteLine("The Answer is " + Calculator.Substraction(number1, number2));
                        Console.WriteLine("type 'yes' to restart the calculation ");
                        restart_calculator = Console.ReadLine();
                    }
                    if (type_of_calculation == "*")
                    {
                        Console.WriteLine("The Answer is " + Calculator.Multiplication(number1, number2));
                        Console.WriteLine("type 'yes' to restart the calculation ");
                        restart_calculator = Console.ReadLine();
                    }
                    if (type_of_calculation == "/")
                    {
                        Console.WriteLine("The Answer is " + Calculator.Division(number1, number2));
                        Console.WriteLine("type 'yes' to restart the calculation ");
                        restart_calculator = Console.ReadLine();
                    }
                    else if (type_of_calculation == "%")
                    {
                        Console.WriteLine("The Answer is " + Calculator.equoficient(number1, number2));
                        Console.WriteLine("type 'yes' to restart the calculation ");
                        restart_calculator = Console.ReadLine();
                    }
                }

            } while (restart_calculator != null);
        }
    }
}         



                    /*
                    Console.WriteLine("How old are you?");
                    string age = Console.ReadLine();
                    var sum = Int32.Parse(age);
                    var sum2 = int.Parse(age);
                    int newAge = sum + 10;
                    Console.WriteLine("Your age is 10 years will be " + newAge);


                   var name = new Person();
                    name.firstName = "Andrew";
                    name.lastName = "Wassers";
                    name.Introduce();
                }

              Calculator sums = new Calculator();
            var problem = sums.Add(300, 7);
            Console.WriteLine(problem);
            Calculator volume = new Calculator();
            var solution = volume.Multiplication(400, 3);
            Console.WriteLine(solution);
                    */
