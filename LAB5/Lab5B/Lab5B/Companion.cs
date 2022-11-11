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
    class Companion
    {
        public string Name { get; set; }
        public string Actor { get; set; }
        public int Doctor_ID { get; set; }
        public string Story_ID { get; set; }

        /// <summary>
        /// Create a new Companion
        /// </summary>
        /// <param name="name">name of the companion</param>
        /// <param name="actor"> actor name</param>
        /// <param name="doctor_id">id of the doctor</param>
        /// <param name="story_id"> storyid of firstone appeared</param>
        public Companion(string name, string actor, int doctor_id, string story_id)
        {
            Name = name;
            Actor = actor;
            Doctor_ID = doctor_id;
            Story_ID = story_id;
        }
    }
}
