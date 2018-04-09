using System.Collections.Generic;

namespace game 
{
    public class StateRegister 
    {
        public State Register(){

            var dieState = new State(new List<string>{ "Você morreu!" }, new State[]{ new State() }, true);

            var oldState = new State(new List<string>{ "'Esperar' a morte tentar ser 'feliz'" }, new State[]{ dieState, dieState });

            var workerState = new State(new List<string>{ "'Trabalhar' muito pedir 'demissão'" }, new State[]{ oldState, dieState });

            var adultState = new State(new List<string>{ "'Trabalhar' muito entrar em 'hospicio'" }, new State[]{workerState, dieState});

            var adolenceState = new State(new List<string>{ "Usar 'drogas' ou se tornar 'depressivo'" }, new State[]{dieState, adultState});

            var schoolState = new State(new List<string>{ "'Estudar' muito ou se 'divertir'" }, new State[]{adolenceState, dieState});

            var childhoodState = new State(new List<string>{ "'Brincar' com o palhaço ou andar de 'patinete'" }, new State[]{dieState, schoolState});

            var initalState = new State(new List<string>{ ":: Life is undefined :: ", "'Sair' da barriga ou 'ficar'" }, new State[]{childhoodState, dieState});

            return initalState;
        }
    }
}