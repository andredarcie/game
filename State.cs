using System;

namespace game 
{
    public class State 
    {
        public string[] Messages { get; set; }
        private string ChosenOption { get; set; }
        public string OptionOne { get; set; }
        public State NodeOne { get; set; }
        public string OptionTwo { get; set; }
        public State NodeTwo { get; set; } 

        public void Input(){
            ChosenOption = Console.ReadLine(); 
            GetNext();
        }
        public State GetNext(){
            if (ChosenOption == OptionOne){
                return NodeOne;
            } else if (ChosenOption == OptionTwo){
                return NodeTwo;
            } else {
                return null;
            }
        }
    }
}