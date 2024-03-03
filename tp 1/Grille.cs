using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_1
{
    internal class Grille
    {
        const int NB_COLONNES = 7;
        public const int NB_RANGEES = 6;   


        Colonne[] _colonnes = new Colonne[NB_COLONNES] ;
        public Grille() 
        {
            for(int i = 0; i < NB_COLONNES; i++)
            {
                _colonnes[i] = new Colonne(i);
            }
            
        }
        public void Afficher()
        {
            Console.SetCursorPosition(0, 5);
            Console.WriteLine(" A   B   C   D   E   F   G");
            for(int i = 0; i < NB_COLONNES; i++)
            {
                _colonnes[i].Afficher();
            }
        }
        public void InsererJeton(char col, char joueur,int comp)
        {
            string choix = col.ToString().ToUpper();
            switch (choix)
            {
                case "A":
                    _colonnes[0].InsererJeton(joueur,comp);
                    break;
                case "B":
                    _colonnes[1].InsererJeton(joueur,comp);
                    break;
                case "C":
                    _colonnes[2].InsererJeton(joueur,comp);
                    break;
                case "D":
                    _colonnes[3].InsererJeton(joueur,comp);
                    break;
                case "E":
                    _colonnes[4].InsererJeton(joueur, comp);
                    break;
                case "F":
                    _colonnes[5].InsererJeton(joueur, comp);
                    break;
                case "G":
                    _colonnes[6].InsererJeton(joueur, comp);
                    break;
            }
        }

        public bool ValideCol(char col, char joueur)
        {
            string choix = col.ToString().ToUpper();
            switch (choix)
            {
                case "A":
                    if (_colonnes[0].WinCol(joueur))
                        return true;
                    break;
                case "B":
                    if (_colonnes[1].WinCol(joueur))
                        return true;
                    break;
                case "C":
                    if (_colonnes[2].WinCol(joueur))
                        return true;
                    break;
                case "D":
                    if (_colonnes[3].WinCol(joueur))
                        return true;
                    break;
                case "E":
                    if (_colonnes[4].WinCol(joueur))
                        return true;
                    break;
                case "F":
                    if (_colonnes[5].WinCol(joueur))
                        return true;
                    break;
                case "G":
                    if (_colonnes[6].WinCol(joueur))
                        return true;
                    break;
            }
            return false;
        }

        public bool ValideRow(char joueur,int compt)
        {
            
            if (joueur == _colonnes[0].ValCase(compt))
            {
                if (joueur == _colonnes[1].ValCase(compt))
                    if (joueur == _colonnes[2].ValCase(compt))
                        if (joueur == _colonnes[3].ValCase(compt))
                            return true;
                
            }
            else if (joueur == _colonnes[1].ValCase(compt))
            {
                if (joueur == _colonnes[2].ValCase(compt))
                    if (joueur == _colonnes[3].ValCase(compt))
                        if (joueur == _colonnes[4].ValCase(compt))
                            return true;
            }
            else if (joueur == _colonnes[2].ValCase(compt))
            {
                if (joueur == _colonnes[3].ValCase(compt))
                    if (joueur == _colonnes[4].ValCase(compt))
                        if (joueur == _colonnes[5].ValCase(compt))
                            return true;
            }
            else if (joueur == _colonnes[3].ValCase(compt))
            {
                if (joueur == _colonnes[4].ValCase(compt))
                    if (joueur == _colonnes[5].ValCase(compt))
                        if (joueur == _colonnes[6].ValCase(compt))
                            return true;
            }

            return false;
            
        }
        public bool ValideDiago(char joueur)
        
        {
            for (int i = 0; i <= 3; i++)
            {
                if (joueur == _colonnes[i].ValUneCase(0))
                {
                    if (joueur == _colonnes[i+1].ValUneCase(1))
                        if (joueur == _colonnes[i+2].ValUneCase(2))
                            if (joueur == _colonnes[i+3].ValUneCase(3))
                                return true;
                }
                if (joueur == _colonnes[i].ValUneCase(1))
                {
                    if (joueur == _colonnes[i+1].ValUneCase(2))
                        if (joueur == _colonnes[i+2].ValUneCase(3))
                            if (joueur == _colonnes[i+3].ValUneCase(4))
                                return true;
                }
                if (joueur == _colonnes[i].ValUneCase(2))
                {
                    if (joueur == _colonnes[i+1].ValUneCase(3))
                        if (joueur == _colonnes[i+2].ValUneCase(4))
                            if (joueur == _colonnes[i + 3].ValUneCase(5))
                                return true;
                }
            }
            for (int i = 6; i >= 3; i--)
            {
                if (joueur == _colonnes[i].ValUneCase(0))
                {
                    if (joueur == _colonnes[i - 1].ValUneCase(1))
                        if (joueur == _colonnes[i - 2].ValUneCase(2))
                            if (joueur == _colonnes[i - 3].ValUneCase(3))
                                return true;
                }
                if (joueur == _colonnes[i].ValUneCase(1))
                {
                    if (joueur == _colonnes[i - 1].ValUneCase(2))
                        if (joueur == _colonnes[i - 2].ValUneCase(3))
                            if (joueur == _colonnes[i - 3].ValUneCase(4))
                                return true;
                }
                if (joueur == _colonnes[i].ValUneCase(2))
                {
                    if (joueur == _colonnes[i - 1].ValUneCase(3))
                        if (joueur == _colonnes[i - 2].ValUneCase(4))
                            if (joueur == _colonnes[i - 3].ValUneCase(5))
                                return true;
                }

            }
            return false;
        }

    } 
}
