using System;
using System.Collections.Generic;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            var stateRegister = new StateRegister();
            var gameStates = stateRegister.Register();

            foreach (var state in gameStates){
                Console.WriteLine(state.Message);
                var input = Console.ReadLine();
                Console.WriteLine(":> " + input);
            }
        }
    }
}
