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
            var player = new Player();

            foreach (var state in gameStates){
                Console.WriteLine(state.Message);
                player.Name = Console.ReadLine();
                Console.WriteLine(":> " + player.Name);
            }
        }
    }
}
