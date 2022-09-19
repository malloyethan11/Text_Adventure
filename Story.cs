using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure
{
    class Story
    {
        public int CurrentStoryEvent { get; set; }
        public string UsersChoice { get; set; }



        public Story()
        {
            CurrentStoryEvent = 1;
            UsersChoice = string.Empty;
        }

    }
}

