using System;
using System.Collections.Generic;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            var stateRegister = new StateRegister();
            var player = new Player();

            var currentState = stateRegister.Register();
            while(currentState.NodeOne != null || currentState.NodeTwo != null)
            {
                foreach (var message in currentState.Messages){
                    Console.WriteLine(message);
                }

                if (currentState.End) return;

                currentState.Input();
                currentState = currentState.GetNext();
            }
        }
    }
}
