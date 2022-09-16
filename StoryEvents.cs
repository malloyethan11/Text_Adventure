using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure
{
    class StoryEvents
    {

        // define dictionary of story events
        Dictionary<string, string> storyEvents = new Dictionary<string, string>();

        public StoryEvents()
        {
            storyEvents.Add("1", "It worked!!! :D :D :D");
        }
    }
}
