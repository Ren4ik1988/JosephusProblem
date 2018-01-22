using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JosephusProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWork d = new DoWork();
            d.Do();
        }
    }

    class DoWork
    {
        int input;
        int step;
        private int k;
        List<int> spisok;

        public void Do()
        {
            string[] temp = Console.ReadLine().Split(' ');
            int.TryParse(temp[0], out input);
            int.TryParse(temp[1], out step);
            spisok = new List<int>(input);
            stepByStep();
            Console.Write(spisok[0]);
        }

        void stepByStep()
        {
            for (int i = 1; i <= input; i++)
            {
                spisok.Add(i);
            }

            k = 1;

            while (spisok.Count > 1)
            {
                for (int i = 0; i < spisok.Count; i++)
                {
                    if (k % step == 0)
                    {
                        spisok.Remove(spisok[i]);
                        i--;
                    }

                    k++;
                }
            }

        }
    }
}
