using System;

namespace s01
{
    class Program
    {
        //         Declare and use a bool, int, double, char, string, and decimal type.
        // Implement at least one loop
        // Implement at least one if or if-else branch with conditions
        // Implement a switch statement
        // Implement a simple function calculation (e.g. totalCost or hasEnough)
        // Use Console.WriteLine and Console.ReadLine
        // Use string interpolation ($"") and \n or \t
        // Code must compile and run.
        // It's more important to practice all the basic programming concepts - if the app is useful or fun, that's great, but not required. 
        // Do not start with any existing application - build it from scratch, on your own, as you will demonstrate throughout the class.
        static void Main(string[] args)
        {
            var expe = 0.0M;
            
            var income = 0.0M;
            var name = "";
            var money = 1.0M;
            var str = "" ;
            //Greet the user
            Console.WriteLine("Hello World!");

            // Take the income of the household
            while (true)
            {
                Console.WriteLine("Enter the income of the household or q: to quit");
                var s = Console.ReadLine();
                if (s == "q")
                {
                    Console.WriteLine("You can exit and enter the expenditures");
                    break;
                }

                else
                {
                    Decimal inc = Decimal.Parse(Console.ReadLine());
                    income += inc;
                    break;
                }
            }
            String[] exp = new String[] { "vegetables", "fruits" };
            for (int i = 0; i < exp.Length; i++)
            {
                Console.WriteLine($"{i}. {exp[i]}");
            }
            int select = int.Parse(Console.ReadLine());
            Console.WriteLine("Different kinds of expenditures");
            switch (select)
            {
                case 0:
                    money = 20.0m;
                    expe += money;
                    break;
                case 1:
                    money = 8.0m;
                    expe += money;
                    break;
            }
            Console.WriteLine($"Expenditures are {expe}");
            Console.WriteLine($"Total savings are: {totalSavings()}");


            Decimal totalSavings()
            {
                var sav = 0.0M;
                if (income > expe)
                {
                    Console.WriteLine("You have savings");
                    sav = income - expe;
                    Console.WriteLine($"The savings are {sav}");
                }
                else
                {
                    Console.WriteLine("No savings");
                }
                return sav;
            }




        }
    }
}
