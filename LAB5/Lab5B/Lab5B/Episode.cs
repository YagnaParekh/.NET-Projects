using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * I, Yagna Parekh, 000846481 certify that this material is my original work.  
 * * No other person's work has been used without due acknowledgement.
 */

namespace Lab5B
{
    class Episode
    {
        public string StoryID { get; set; }
        public int Season { get; set; }
        public int Season_Year { get; set; }
        public string Title { get; set; }

        /// <summary>
        /// Create a new Episode
        /// </summary>
        /// <param name="storyid"> id of the episode</param>
        /// <param name="season">season number</param>
        /// <param name="seasonyear">season yaer of the episode</param>
        /// <param name="title"> title of the episode</param>
        public Episode(string storyid, int season, int seasonyear, string title)
        {
            StoryID = storyid;
            Season = season;
            Season_Year = seasonyear;
            Title = title;
        }
    }
}
