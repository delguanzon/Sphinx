using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sphinx.Models
{
    public class Riddles
    {

        private Dictionary<string, string> _riddlePairs = new Dictionary<string, string>() {
            { "What gets wet while drying?", "towel" },
            { "What can you catch, but not throw?", "cold" },
            { "What is red and smells like blue paint?", "red paint" },
            { "What runs, but never walks. Murmurs, but never talks. Has a bed, but never sleeps. And has a mouth, but never eats" , "river" }
        };

        private string _currentAnswer;

        public string GetRiddle()
        {
            return RandomRiddle();
        }

        public void AddRiddle(string question, string answer)
        {
            _riddlePairs[question] = answer;
        }

        private string RandomRiddle() 
        {
            Random rnd = new Random();
            int i = rnd.Next(0, _riddlePairs.Count - 1);
            string riddle = _riddlePairs.ElementAt(i).Key;
            _currentAnswer = _riddlePairs.ElementAt(i).Value;

            return riddle;
        }
        public bool checkAnswer(string answer)
        {
            bool check = answer.ToLower().Trim().Contains(_currentAnswer);
            return check;
        }
    }
}
