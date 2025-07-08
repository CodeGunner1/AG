using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Archivos_Sec
{
    class Arreglo3D
    {

        private int[,,] Y;
        private int f, c, p;
        const int MAXF = 30;
        const int MAXC = 30;
        const int MAXP = 30;


        public Arreglo3D()
        {
            Y = new int[MAXF, MAXC, MAXP];
            f = 0;
            c = 0;
            p = 0;
        }


        public void Cargar(int nf, int nc, int np, int a, int b)
        {
            int f1, c1, p1;
            f = nf; c = nc; p = np;

            Random r = new Random();
            for (p1 = 1; p1 <= p; p1++)
            {
                for (f1 = 1; f1 <= f; f1++)
                {
                    for (c1 = 1; c1 <= c; c1++)
                    {
                        Y[f1, c1, p1] = r.Next(a, b + 1);
                    }
                }
            }

        }
        public string Descargar()
        {
            string s = "";
            int f1, c1, p1;

            for (p1 = 1; p1 <= p; p1++)
            {
                for (f1 = 1; f1 <= f; f1++)
                {
                    for (c1 = 1; c1 <= c; c1++)
                    {
                        s = s + Y[f1, c1, p1] + "\x09";
                    }

                    s = s + "\r\n";

                }
                s = s + "\r\n\n";
            }
            return s;
        }



        //4.
        public string MayorConPosicion()
        {
            int f1, c1, p1;
            int mayor = Y[1, 1, 1];
            int posF = 1, posC = 1, posP = 1;

            for (p1 = 1; p1 <= p; p1++)
            {
                for (f1 = 1; f1 <= f; f1++)
                {
                    for (c1 = 1; c1 <= c; c1++)
                    {
                        if (Y[f1, c1, p1] > mayor)
                        {
                            mayor = Y[f1, c1, p1];
                            posF = f1;
                            posC = c1;
                            posP = p1;
                        }
                    }
                }
            }

            return "Mayor elemento: " + mayor + "\r\n" +
                   "Fila: " + posF + "\r\n" +
                   "Columna: " + posC + "\r\n" +
                   "Profundidad: " + posP;
        }

        //5. 
        public void SumarTodoYGuardarEnNuevaProfundidad()
        {
            int f1, c1, p1;

            int nuevaP = p + 1;


            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    Y[f1, c1, nuevaP] = 0;
                }
            }


            for (p1 = 1; p1 <= p; p1++)
            {
                for (f1 = 1; f1 <= f; f1++)
                {
                    for (c1 = 1; c1 <= c; c1++)
                    {
                        Y[f1, c1, nuevaP] += Y[f1, c1, p1];
                    }
                }
            }

            
            p = nuevaP;
        }


        //6. 


        public void OrdenarPorFilasSeparadas()
        {
            int[] aux = new int[f * c * p];
            int f1, c1, p1, i = 0;


            for (f1 = 1; f1 <= f; f1++)
            {
                for (p1 = 1; p1 <= p; p1++)
                {
                    for (c1 = 1; c1 <= c; c1++)
                    {
                        aux[i++] = Y[f1, c1, p1];
                    }
                }
            }


            int n = aux.Length;
            for (int j = 0; j < n - 1; j++)
            {
                for (int k = 0; k < n - 1 - j; k++)
                {
                    if (aux[k] > aux[k + 1])
                    {
                        int temp = aux[k];
                        aux[k] = aux[k + 1];
                        aux[k + 1] = temp;
                    }
                }
            }


            i = 0;
            for (f1 = 1; f1 <= f; f1++)
            {
                for (p1 = 1; p1 <= p; p1++)
                {
                    for (c1 = 1; c1 <= c; c1++)
                    {
                        Y[f1, c1, p1] = aux[i++];
                    }
                }
            }
        }

        public void OrdenarPorFilasSeparadas1()
        {
            for (int p1 = 1; p1 <= p; p1++)
                for (int f1 = 1; f1 <= f; f1++)
                    for (int c1 = 1; c1 <= c; c1++)
                        for (int p2 = 1; p2 <= p; p2++)
                            for (int f2 = 1; f2 <= f; f2++)
                                for (int c2 = 1; c2 <= c; c2++)
                                {
                                    if (Y[f2, c2, p2] < Y[f1, c1, p1])
                                    {

                                        int temp = Y[f1, c1, p1];
                                        Y[f1, c1, p1] = Y[f2, c2, p2];
                                        Y[f2, c2, p2] = temp;
                                    }
                                }
        }

    }
}
