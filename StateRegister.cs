using System.Collections.Generic;

namespace game 
{
    public class StateRegister 
    {
        public State Register(){

            var gameStates = new List<State>();

            gameStates.Add(new State { 
                Messages = new string[]{ ":: Livre arbitrio :: ", "'Sair' da barriga ou 'ficar'?" }, 
                OptionOne = "sair",
                NodeOne = new State {
                    Messages = new string[]{ "" },
                    OptionOne = ""
                },
                OptionTwo = "ficar",
                NodeTwo = new State {
                    Messages = new string[]{ "Você morreu!" },
                    NodeOne = new State(),
                    End = true
                }
            });

            return gameStates[0];
        }
    }
}