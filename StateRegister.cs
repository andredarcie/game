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

            var oldState = new State {
                Messages = new string[] { "'Esperar' a morte tentar ser 'feliz'" },
                OptionOne = "esperar",
                NodeOne = dieState,
                OptionTwo = "feliz",
                NodeTwo = dieState
            };

            var workerState = new State {
                Messages = new string[] { "'Trabalhar' muito pedir 'demissão'" },
                OptionOne = "trabalhar",
                NodeOne = oldState,
                OptionTwo = "demissao",
                NodeTwo = dieState
            };

            var adultState = new State {
                Messages = new string[] { "'Trabalhar' muito entrar em 'hospicio'" },
                OptionOne = "trabalhar",
                NodeOne = workerState,
                OptionTwo = "hospicio",
                NodeTwo = dieState
            };

            var adolenceState = new State {
                Messages = new string[] { "Usar 'drogas' ou se tornar 'depressivo'" },
                OptionOne = "drogas",
                NodeOne = dieState,
                OptionTwo = "depressivo",
                NodeTwo = adultState
            };

            var schoolState = new State {
                Messages = new string[] { "'Estudar' muito ou se 'divertir'" },
                OptionOne = "estudar",
                NodeOne = adolenceState,
                OptionTwo = "divertir",
                NodeTwo = dieState
            };

            var childhoodState = new State {
                Messages = new string[]{ "'Brincar' com o palhaço ou andar de 'patinete'" },
                OptionOne = "brincar",
                NodeOne = dieState,
                OptionTwo = "patinete",
                NodeTwo = schoolState
            };

            var initalState = new State { 
                Messages = new string[]{ ":: Livre arbitrio :: ", "'Sair' da barriga ou 'ficar'" }, 
                OptionOne = "sair",
                NodeOne = childhoodState,
                OptionTwo = "ficar",
                NodeTwo = dieState
            };

            return initalState;
        }
    }
}