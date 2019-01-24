using System;

namespace s01
{
    class Program
    {
        // Declare and use a bool, int, double, char, string, and decimal type.
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
            var expe = 0.0;
            var name="";
            var income = 0.0M;
            var money = 1.0;
            var b = true;
            Char s = 'j';
            var i = 0;
            
        
            //Greet the user
            Console.WriteLine("Enter the name:");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");

            // Take the income of the household
            while (b)
            {
                Console.WriteLine("Enter the income");
                                        
                    Decimal inc = Decimal.Parse(Console.ReadLine());
                    income += inc;
                    Console.WriteLine("If you want to exit press q: or n to continue");
                     s = Char.Parse(Console.ReadLine());
                     if(s == 'q'){
                         break;
                     }
                
            }
            Console.WriteLine($"You have Earned {income} Dollars this month \n");
            Console.WriteLine("Enter the things on which you have spent money");
            String[] exp = new String[] { "vegetables", "fruits","Electronics" };
            for ( i = 0; i < exp.Length; i++)
            {
                Console.WriteLine($"{i}. \t {exp[i]}");
            }
            
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 0:
                    money = 20.0;
                    expe += money;
                    break;
                case 1:
                    money = 8.0;
                    expe += money;
                    break;
                case 2:
                    Console.WriteLine("How much did you spent on electronics");
                    money = double.Parse(Console.ReadLine());
                    expe += money;
                    break;
            }
            
            Console.WriteLine($"You have spent {expe} dollars");
            Console.WriteLine($"Your savings are: {totalSavings()}");


            Decimal totalSavings()
            {
                var sav = 0.0M;
                Decimal e = (Decimal)(expe);
                if (income > e)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Hola! You have savings for this month");
                    sav = income - e;
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
