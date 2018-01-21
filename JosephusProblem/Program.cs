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

        }
    }

    class DoWork
    {
        int input;
        int step;
        List<int> spisok;

        public void Do()
        {
            int.TryParse(Console.ReadLine().Split(' ')[0], out input);
            int.TryParse(Console.ReadLine().Split(' ')[1], out step);
            spisok = new List<int>(input);
        }

        void stepByStep()
        {
            for (int i = 1; i <= input; i++)
            {
                spisok.Add(i);
            }

            
        }
    }
}
