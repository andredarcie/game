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

            var oldState = new State();

            var workerState = new State();

            var adultState = new State();

            var adolenceState = new State();

            var schoolState = new State {
                Messages = new string[] { "'Estudar' muito ou se 'divertir'" },
                OptionOne = "estudar",
                NodeOne = adolenceState,
                OptionTwo = "divertir",
                NodeTwo = dieState
            };

            var childhoodState = new State {
                Messages = new string[]{ "'Brincar' com o palhaço ou andar de 'patinete'?" },
                OptionOne = "brincar",
                NodeOne = dieState,
                OptionTwo = "patinete",
                NodeTwo = schoolState
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