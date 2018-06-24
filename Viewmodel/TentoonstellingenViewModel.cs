using System;
using System.Collections.Generic;
using System.Text;

namespace KillMyself.Viewmodel
{
    public class TentoonstellingenViewModel
    {
        public List<Tentoonstellingenclass> Tentoonstellingenclasses { get; set;}

        public TentoonstellingenViewModel()
        {
            Tentoonstellingenclasses = new Tentoonstellingenclass().GetTentoonstellingenclasses();
        }
    }
}
