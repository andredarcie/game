using System.Collections.Generic;

namespace game 
{
    public class StateRegister 
    {
        public List<State> Register(){

            var gameStates = new List<State>();

            gameStates.Add(new State { Message = "Digite seu nome: " });

            return gameStates;
        }
    }
}