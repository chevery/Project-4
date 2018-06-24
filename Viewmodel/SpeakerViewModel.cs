using KillMyself.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KillMyself.Viewmodel
{
    public class SpeakerViewModel
    {
        public List<Speaker> Speakers { get; set; }

        public SpeakerViewModel()
        {
            Speakers = new Speaker().GetSpeakers();
        }
    }
}
