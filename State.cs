using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace game 
{
    public class State 
    {
        public List<string> Messages { get; set; }
        public string[] Options { get; set; }
        public State[] States { get; set; }
        public bool End { get; set; }

        public State(List<string> messages, State[] states, bool end = false){
            Messages = messages;
            SetOptions();
            States = states;
            End = end;
        }

        public State(){
        }

        public void Input(){
            GetNext(Console.ReadLine());
        }

        public State GetNext(string chosenOption){
            chosenOption = RemoveAccent(chosenOption).ToLower();
            for (int i = 0; i < Options.Length; i++){
                if(Options[i] == chosenOption){
                    return States[i];
                }
            }
            return null;
        }

        public void SetOptions(){

            Options = new string[100];

            bool getWord = false;
            string word = "";
            var optionIndex = 0;

            foreach(var message in Messages){
                for(int i = 0; i < message.Length; i++){
                    char c = message[i];
                    if(c == '\''){
                        getWord = !getWord;
                        if(!getWord){
                            Options[optionIndex] = RemoveAccent(word).ToLower();
                            optionIndex++;
                            word = "";
                        }
                        continue;
                    }
                    if (getWord){
                        word += c;
                    }
                }
            }
        }

        public string RemoveAccent(string text)
        {
            return new string(text
                .Normalize(NormalizationForm.FormD)
                .Where(ch => char.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                .ToArray());
        }
    }
}