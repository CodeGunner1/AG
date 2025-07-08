using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Archivos_Sec
{
    class Matriz
    {
        private int MAXF = 50;
        private int MAXC = 50;
        private int[,] x;
        private int f, c;
        public Matriz()
        {
            x = new int[MAXF, MAXC];
            f = 0;
            c = 0;
        }
        public void Cargar(int fil, int col, int a, int b)
        {
            Random r = new Random();
            f = fil; c = col;
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = 1; c1 <= c; c1++)
                {
                    x[f1, c1] = r.Next(a, b + 1);
                }
            }
        }
        public string Descargar()
        {
            string s = "";
            for (int f1 = 1; f1 <= f; f1++)
            {
                for (int c1 = 1; c1 <= c; c1++)
                {
                    s = s + x[f1, c1] + "\x0009";
                }
                s = s + "\x000d" + "\x000a";
            }
            return s;
        }
        public int frecCOl(int ele, int c1)
        {
            int fr = 0;
            for (int f1 = 1; f1 <= f; f1++)
            {
                if (x[f1, c1] == ele)
                {
                    fr++;
                }
            }
            return fr;
        }
        public void EleYFrec()
        {
            int fr = 0, Ele = 0;
            for (int c1 = 1; c1 <= c; c1++)
            {
                for (int f1 = 1; f1 <= c; f1++)
                {
                    if (frecCOl(x[f1, c1], c1) > fr)
                    {
                        fr = frecCOl(x[f1, c1], c1);
                        Ele = x[f1, c1];
                    }
                }
                x[f + 1, c1] = Ele;
                x[f + 2, c1] = fr;
                fr = 0;
            }
            f = f + 2;
        }
        public void InterEle(int f1, int c1, int f2, int c2)
        {
            int aux = x[f1, c1];
            x[f1, c1] = x[f2, c2];
            x[f2, c2] = aux;
        }
    }
}
