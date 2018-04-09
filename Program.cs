using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            var stateRegister = new StateRegister();
            var player = new Player();

            var currentState = stateRegister.Register();
            while(currentState.States.Length != 0)
            {
                foreach (var message in currentState.Messages){
                    Console.WriteLine(message);
                }

                if (currentState.End) { Console.ReadKey(); return; };

                var newState = new State();
                do {
                    newState = currentState.GetNext(Console.ReadLine());
                    if (newState == null)
                    {
                        Console.WriteLine("Opção invalida! Digite novamente.");
                    }
                    else
                    {
                        currentState = newState;
                    }

                } while (newState == null);
            }
        }
    }
}
