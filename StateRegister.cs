using System.Collections.Generic;

namespace game 
{
    public class StateRegister 
    {
        public State Register(){

            var dieState = new State {
                Messages = new string[]{ "Você morreu!" },
                NodeOne = new State(),
                End = true
            };

            var childhoodState = new State {
                Messages = new string[]{ "'Brincar' com o palhaço ou andar de 'patinete'?" },
                OptionOne = "brincar",
                NodeOne = dieState,
            };

            var initalState = new State { 
                Messages = new string[]{ ":: Livre arbitrio :: ", "'Sair' da barriga ou 'ficar'?" }, 
                OptionOne = "sair",
                NodeOne = childhoodState,
                OptionTwo = "ficar",
                NodeTwo = dieState
            };

            return initalState;
        }
    }
}