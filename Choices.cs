using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure
{
    class Choices
    {
        // create dictionary of choices
        List<KeyValuePair<string, string>> choices = new List<KeyValuePair<string, string>>();

        public Choices()
        {
            choices.Add(new KeyValuePair<string, string>("1.1", "choice1 Dict"));
            choices.Add("1.b", "choice2 Dict");
            choices.Add("1.c", "choice3 Dict");
        }
    }
}
