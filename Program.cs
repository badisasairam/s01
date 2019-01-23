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
            
            var things = 0;
            var bool;
            var income = 0.0;
            var c = 'p';
            var name = "";
            var money = 1.0M;
            var string = "";
            //Greet the user
            Console.WriteLine("Hello World!");

            // Take the income of the household
            while(true){
            Console.WriteLine("Enter the income of the household or q: to quit");
            var s = Console.WriteLine();
            if ( s=='q'){
                Console.WriteLine("You can exit and enter the expenditures");
            }
            else{
               var inc = Console.ReadLine(); 
               income+= inc;
            }
            
            }
            Console.WriteLine("Enter the expenditures");
            

            public double totalSum(){
                var sum ;
                sum +=sum;
                return sum;
            }

            switch(string){
                case "vegetables": money = 20.0m;
                                   break;
                case "fruits": money = 8.0m;
                               break;
            }



            
            

        }
    }
}
