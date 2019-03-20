using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_3
{
    public class PuzzleEquation
    {
        private string version;
        private int num1;
        private int num2;
        private int answer;
        private int timeOut;
        private DateTime started = new DateTime();

        public override string ToString()
        {
            return ($"{num1} + {num2} = ?");
        }

        public PuzzleEquation()
        {
            Random ran = new Random();
            num1 = ran.Next(0, 9);
            num2 = ran.Next(0, 9);
            answer = num1 + num2;
            started = DateTime.Now;
            timeOut = 10;
            version = "1.2";
        }

        public string checkAnswer(string input)
        {
            if (answer.ToString() == input)
            {
                return ("correct");
            }
            else
            {
                return ("Invalid number(must be a number)");
            }
        }

        public string About()
        {
            return (version);
        }
    }
}
