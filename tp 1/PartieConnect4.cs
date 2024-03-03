using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_1
{
    internal class PartieConnect4
    {
        Grille _grille;
        bool _partieEnCours;
        int _compteur = 0;
        int _comptA = 0;
        int _comptB = 0;
        int _comptC = 0;
        int _comptD = 0;
        int _comptE = 0;
        int _comptF = 0;
        int _comptG = 0;

        public void Jouer()
        {
            string? nom = "";

            Util.Titrer($"Joueur 1");
            nom = DemanderNom();
            Joueur Player1 = new Joueur(nom);
            Util.Titrer($"Joueur 2");
            nom = DemanderNom();
            Joueur Player2 = new Joueur(nom);

            Util.Titrer($" CONNECT 4\n {Player1._Nom} ");
            
            _partieEnCours = true;
            _grille = new Grille();
            _grille.Afficher();
            

            while (_partieEnCours)
            {
                char dec = SaisirDecision();

                if (Valider(dec))
                {
                    InsererJeton(dec);
                    _compteur++;
                    if (BQuelleJoeur(_compteur))
                    {
                        Util.Titrer($" CONNECT 4\n {Player1._Nom} ");
                    }
                    else
                    {
                        Util.Titrer($" CONNECT 4\n {Player2._Nom} ");
                    }
                    _grille.Afficher();
                }
                if (CoupGagnant(dec, QuelleJoeur(_compteur-1)) ) 
                {
                    if(QuelleJoeur(_compteur - 1) == 'X')
                    {
                        Console.WriteLine($"\n\n----- Le gagnant est {Player1._Nom} ({QuelleJoeur(_compteur-1)}) -----");
                    }
                    else 
                    { 
                        Console.WriteLine($"\n\n----- Le gagnant est {Player2._Nom} ({QuelleJoeur(_compteur - 1)}) -----"); 
                    }
                    _partieEnCours = false;
                }
            }
        }

        static string DemanderNom()
        {
            string? nom = " ";
            Console.WriteLine("Veuillez choisir le nom du joueur");
            nom = Console.ReadLine();
            return nom;
        }

        void InsererJeton(char col)
        {
            string choix = col.ToString().ToUpper();
            char joueur = QuelleJoeur(_compteur);
            switch(choix)
            {
                case ("A"):
                    _grille.InsererJeton(col, joueur, _comptA);
                    break;
                case ("B"):
                    _grille.InsererJeton(col, joueur, _comptB);
                    break;
                case ("C"):
                    _grille.InsererJeton(col, joueur, _comptC);
                    break;
                case ("D"):
                    _grille.InsererJeton(col, joueur, _comptD);
                    break;
                case ("E"):
                    _grille.InsererJeton(col, joueur, _comptE);
                    break;
                case ("F"):
                    _grille.InsererJeton(col, joueur, _comptF);
                    break;
                case ("G"):
                    _grille.InsererJeton(col, joueur, _comptG);
                    break;
                default:
                    break;
            }
                
        }

        char SaisirDecision()
        {
            if(BQuelleJoeur(_compteur))
            {
                Console.WriteLine($"\nJoueur 1\nDans quelle colonne voulez vous mettre le jeton");
                char x = Util.SaisirChar();
                
                return x;
            }
            else
            {
                Console.WriteLine("\nJoueur 2\nDans quelle colonne voulez vous mettre le jeton");
                char x = Util.SaisirChar();
                return x;
            }
            
        }

        char QuelleJoeur(int comp)
        {
            if (comp % 2 == 0)
            {
                return 'X';
            }
            return 'O';
            
        }
        bool BQuelleJoeur(int comp)
        {
            if (comp % 2 == 0)
            {
                return true;
            }
            return false;
        }

        bool Valider(char dec) 
        {
            
            string choix = dec.ToString().ToUpper();
            switch (choix)
            {
                case ("A"):
                    if (_comptA == Grille.NB_RANGEES)
                    {
                        Console.WriteLine("-----La colonne choisie est pleine-----");
                        return false;
                    }
                    _comptA++;
                    return true;
                case ("B"):
                    if (_comptB == Grille.NB_RANGEES)
                    {
                        Console.WriteLine("-----La colonne choisie est pleine-----");
                        return false;
                    }
                    _comptB++;
                    return true;
                case ("C"):
                    if (_comptC == Grille.NB_RANGEES)
                    {
                        Console.WriteLine("-----La colonne choisie est pleine-----");
                        return false;
                    }
                    _comptC++;
                    return true;
                case ("D"):
                    if (_comptD == Grille.NB_RANGEES)
                    {
                        Console.WriteLine("-----La colonne choisie est pleine-----");
                        return false;
                    }
                    _comptD++;
                    return true;
                case ("E"):
                    if (_comptE == Grille.NB_RANGEES)
                    {
                        Console.WriteLine("-----La colonne choisie est pleine-----");
                        return false;
                    }
                    _comptE++;
                    return true;
                case ("F"):
                    if (_comptF == Grille.NB_RANGEES)
                    {
                        Console.WriteLine("-----La colonne choisie est pleine-----");
                        return false;
                    }
                    _comptF++;
                    return true;
                case("G"):
                    if (_comptG == Grille.NB_RANGEES)
                    {
                        Console.WriteLine("-----La colonne choisie est pleine-----");
                        return false;
                    }
                    _comptG++;
                    return true;
                default:
                    Console.WriteLine("-----La touche choisie n’est pas une colonne-----");
                    return false;
            }
        }

        bool CoupGagnant(char dec,char joueur) {

            if (_grille.ValideCol(dec, joueur))
            {
                return true;
            }
            if (ValidRow(dec, joueur))
            {
                return true;
            }
            if (ValidDiago(joueur,dec))
            {
                return true;
            }

            return false;    
        }
        bool ValidRow(char dec, char joueur)
        {
            string choix = dec.ToString().ToUpper();
            switch (choix)
            {
                case ("A"):
                    return _grille.ValideRow(joueur, _comptA);
                case ("B"):
                    return _grille.ValideRow(joueur, _comptB);
                case ("C"):
                    return _grille.ValideRow(joueur, _comptC);
                case ("D"):
                    return _grille.ValideRow(joueur, _comptD);
                case ("E"):
                    return _grille.ValideRow(joueur, _comptE);
                case ("F"):
                    return _grille.ValideRow(joueur, _comptF);
                case ("G"):
                    return _grille.ValideRow(joueur, _comptG);
                default:
                    return false;
            }
        }
        bool ValidDiago(char joueur,char dec)
        {
            string choix = dec.ToString().ToUpper();
            switch (choix)
            {
                case ("A"):
                    return _grille.ValideDiago(joueur);
                case ("B"):
                    return _grille.ValideDiago(joueur);
                case ("C"):
                    return _grille.ValideDiago(joueur);
                case ("D"):
                    return _grille.ValideDiago(joueur);
                case ("E"):
                    return _grille.ValideDiago(joueur);
                case ("F"):
                    return _grille.ValideDiago(joueur);
                case ("G"):
                    return _grille.ValideDiago(joueur);
                default:
                    return false;
            }
            
            return false;
        }
    }

    
}
