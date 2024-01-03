using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dice("", 3);
            diceRet("", 4);
            diceFace("", 5, 3);
        }
        static void dice(string p, int target)
        {
            if (target == 0)
            {
                Console.WriteLine(p);
                return;
            }

            for (int i = 1; i <= 6 && i <= target; i++)
            {
                dice(p + i, target - i);
            }
        }

        static ArrayList diceRet(string p, int target)
        {
            if (target == 0)
            {
                ArrayList lista = new ArrayList();
                lista.Add(p);
                return lista;
            }
            ArrayList list = new ArrayList();
            for (int i = 1; i <= 6 && i <= target; i++)
            {
                list.AddRange(diceRet(p + i, target - i));
            }
            return list;
        }

        static void diceFace(string p, int target, int face)
        {
            if (target == 0)
            {
                Console.WriteLine(p);
                return;
            }

            for (int i = 1; i <= face && i <= target; i++)
            {
                diceFace(p + i, target - i, face);
            }
        }

        static ArrayList diceFaceRet(string p, int target, int face)
        {
            if (target == 0)
            {
                ArrayList lista = new ArrayList();
                lista.Add(p);
                return lista;
            }
            ArrayList list = new ArrayList();
            for (int i = 1; i <= face && i <= target; i++)
            {
                list.AddRange(diceFaceRet(p + i, target - i, face));
            }
            return list;
        }
    }
}
