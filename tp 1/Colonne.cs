using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_1
{
    internal class Colonne
    {
        int _numero;
        Case[] _cases = new Case[Grille.NB_RANGEES];
        public Colonne(int numColonne) 
        {
            _numero = numColonne;
            for(int i=0; i<Grille.NB_RANGEES; i++) 
            {
                _cases[i] = new Case(_numero, i); 
            }
        } 
        
        public void Afficher() 
        {
            for(int i= 0; i<Grille.NB_RANGEES;i++)
            {
                _cases[i].Afficher();
            }
        }

        public void InsererJeton(char joueur,int comp)
        {
            int pCase = Grille.NB_RANGEES - comp;
            _cases[pCase]._Contenu = joueur;
            
        }
        public bool WinCol(char joueur)
        {
            int compteur = 0;
            bool continu = true;
            if (continu)
            {
                for (int i = Grille.NB_RANGEES-1; i >= 2;i--)
                {
                    if (joueur == _cases[i]._Contenu)
                    {
                        compteur++;
                        continu = true;
                    }
                    else
                    {
                        continu = false;
                        break;
                    }
                    
                }
                if(compteur==4) 
                { return true;}
                
            }
            compteur = 0;
            continu = true;
            if (continu)
            {
                for (int i = Grille.NB_RANGEES-2; i >= 1; i--)
                {
                    if (joueur == _cases[i]._Contenu)
                    {
                        compteur++;
                        continu = true;
                    }
                    else
                    {
                        continu = false;
                        break;
                    }

                }
                if (compteur == 4)
                { return true; }
            }
            compteur = 0;
            continu = true;
            if (continu)
            {
                for (int i = Grille.NB_RANGEES-3; i >= 0; i--)
                {
                    if (joueur == _cases[i]._Contenu)
                    {
                        compteur++;
                        continu = true;
                    }
                    else
                    {
                        continu = false;
                        break;
                    }

                }
                if (compteur == 4)
                { return true; }
            }
            return false;
        }
        public char ValCase(int comp)
        {
            int pCase = Grille.NB_RANGEES - comp;
            return _cases[pCase]._Contenu;
        }
        public char ValUneCase(int val)
        {
            return _cases[val]._Contenu;
        }

    }
}
