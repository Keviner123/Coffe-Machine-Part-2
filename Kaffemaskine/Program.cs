using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    class Program
    {
        static void Main(string[] args)
        {
            //We create a new coffemachine 
            CoffeeMachine MyCoffeeMachine = new CoffeeMachine();

            //We fill both compartments up
            MyCoffeeMachine.Water.Fill();
            MyCoffeeMachine.Department.Fill(new CoffeePowder());

            //We brew the coffee and check the status
            Console.WriteLine(MyCoffeeMachine.Brew());

            MyCoffeeMachine.Water.Fill();
            MyCoffeeMachine.Department.Fill(new TeaPowder());

            //And check if we can brew a cup more
            Console.WriteLine(MyCoffeeMachine.Brew());
            Console.ReadKey();
        }
    }
}
