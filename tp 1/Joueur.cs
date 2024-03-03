using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_1
{
    internal class Joueur
    {
        public string _Nom { get; set; }
        public int nombreWin { get; set; }
        Grille _jGrille = new Grille();

        public Joueur(string nom) 
        {
            _Nom = nom;
        }
    }
}
