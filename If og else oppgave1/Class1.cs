using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_og_else_oppgave1
{
    internal class Oppgave1
    {
        int numb1 = 3;
        int numb2 = 3;
        bool isEqual = false;
        public void Run() 
        {
            if (numb1 == numb2)
            {
                isEqual = true;
                Console.WriteLine("Is equal");
            }
            else
            {
                isEqual = false;
                Console.WriteLine("Is not equal");
            }



        }
       


    }
}
