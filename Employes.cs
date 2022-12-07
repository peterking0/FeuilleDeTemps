using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace FeuilleDeTemps
{


    public class Rootobject
    {
        public int numeroEmplyes { get; set; }
        public string nomEmplyes { get; set; }
        public Lundi[] Lundi { get; set; }
        public Mardi[] Mardi { get; set; }
        public Mercredi[] Mercredi { get; set; }
        public Jeudi[] Jeudi { get; set; }
        public Vendredi[] Vendredi { get; set; }
        public Samedi[] Samedi { get; set; }
        public Dimanche[] Dimanche { get; set; }
    }

    public class Lundi
    {
        public int code1 { get; set; }
        public int projet1 { get; set; }
    }

    public class Mardi
    {
        public int code2 { get; set; }
        public int projet2 { get; set; }
    }

    public class Mercredi
    {
        public int code3 { get; set; }
        public int projet3 { get; set; }
    }

    public class Jeudi
    {
        public int code4 { get; set; }
        public int projet4 { get; set; }
    }

    public class Vendredi
    {
        public int code5 { get; set; }
        public int projet5 { get; set; }
    }

    public class Samedi
    {
        public int code6 { get; set; }
        public int projet6 { get; set; }
    }

    public class Dimanche
    {
        public int code7 { get; set; }
        public int projet7 { get; set; }
    }


}
