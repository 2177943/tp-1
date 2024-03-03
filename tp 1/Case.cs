using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_1
{
    internal class Case
    {
        int _numCol { get; set; }
        int _numRangee { get; set; }
        public char _Contenu { get; set; }
        
        public Case(int col, int rang) 
        { 
            _numCol = col;  
            _numRangee = rang;
            _Contenu = '_';
        }
        
        public void Afficher() 
        {
            Console.SetCursorPosition(_numCol * 4, _numRangee + 6);
            Console.Write($"_{_Contenu}_|");
        }

        public int XOuO()
        {
            if (_Contenu=='X')
            {
                return 1;
            }
            if (_Contenu == 'O')
            {
                return 2;
            }
            return 0;
        }
    }
}
