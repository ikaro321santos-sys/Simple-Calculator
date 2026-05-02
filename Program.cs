namespace Simple_Calculator
{
    internal class Program
    {
        enum Operations
        {
            Plus,
            Minus,
            Division,
            Times
        }
        static void Main(string[] args)
        {
            bool DoAgain = true;
            do {
                Console.WriteLine("Number 1 : ");
                //double a = double.Parse(Console.ReadLine());
                if (double.TryParse(Console.ReadLine(), out double a)) { }
                else
                {
                    Console.WriteLine("Not Number.");
                    return;
                }
                Console.WriteLine("Number 2 : ");
                //double b = double.Parse(Console.ReadLine());
                if (double.TryParse(Console.ReadLine(), out double b)) { }
                else
                {
                    Console.WriteLine("Not Number.");
                    return;
                }
                Console.WriteLine("[+], [-], [*], [/]");
                string? Answer = Console.ReadLine();

                Operations Choice;
                if (Answer == "+") Choice = Operations.Plus;
                else if (Answer == "-") Choice = Operations.Minus;
                else if (Answer == "*") Choice = Operations.Times;
                else if (Answer == "/") Choice = Operations.Division;
                else
                {
                    Console.WriteLine("Invalid Input.");
                    return;
                }
                //Results
                Calculator Calc = new Calculator();
                if (Choice == Operations.Plus)
                {
                    double Result = Calc.Plus(a, b);
                    Console.WriteLine($"{a} + {b} = {Result}");
                }
                else if (Choice == Operations.Minus)
                {
                    double Result = Calc.Minus(a, b);
                    Console.WriteLine($"{a} - {b} = {Result}");
                }
                else if (Choice == Operations.Times)
                {
                    double Result = Calc.Times(a, b);
                    Console.WriteLine($"{a} * {b} = {Result}");
                }
                else if (Choice == Operations.Division)
                {
                    double Result = Calc.Division(a, b);
                    Console.WriteLine($"{a} / {b} = {Result}");
                }
                Console.WriteLine("Continue? [Y/N]");
                string? Continue = Console.ReadLine().ToUpper();
                if (Continue == "Y") DoAgain = true;
                else if (Continue == "N") DoAgain = false;
                else {
                    Console.WriteLine("Invalid Input.");
                    return;
                }
            } while (DoAgain);
            Console.WriteLine("Goodbye!");
        }
        private class Calculator{ 
            public double Plus(double a, double b){
                return a + b;
            }
            public double Minus(double a, double b){
                return a - b;
            }
            public double Division(double a, double b){
                return a / b;
            }
            public double Times(double a, double b){
                return a * b;
            }
        }

    }
}
