using System;
using System.Collections.Generic;
using System.Text;

namespace KillMyself.Viewmodel
{
    public class HomeViewModel
    {
        public List<Homeclass> Homeclasses { get; set; }
        public List<Homeclass> Homeclasses2 { get; set; }
        public List<Homeclass> Homeclasses3 { get; set; }

        public List<Homeclass> Homeclasses4 { get; set; }
        public List<Homeclass> Homeclasses5 { get; set; }

        public List<Homeclass> Homeclasses6 { get; set; }

        public List<Homeclass> Homeclasses7 { get; set; }

        public List<Homeclass> Homeclasses8 { get; set; }

        public List<Homeclass> Homeclasses9 { get; set; }


        public HomeViewModel()
        {
            Homeclasses = new Homeclass().GetHomeclasses();
            Homeclasses2 = new Homeclass().GetHomeclasses2();
            Homeclasses3 = new Homeclass().GetHomeclasses3();
            Homeclasses4 = new Homeclass().GetHomeclasses4();
            Homeclasses5 = new Homeclass().GetHomeclasses5();
            Homeclasses6 = new Homeclass().GetHomeclasses6();
            Homeclasses7 = new Homeclass().GetHomeclasses7();
            Homeclasses8 = new Homeclass().GetHomeclasses8();
            Homeclasses9 = new Homeclass().GetHomeclasses9();

        }
    }
}