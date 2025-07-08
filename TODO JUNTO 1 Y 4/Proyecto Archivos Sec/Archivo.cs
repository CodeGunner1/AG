using System;                      
using System.Collections.Generic;  
using System.Linq;                 
using System.Text;                
using System.Threading.Tasks;      
using System.IO;                   

namespace Proyecto_Archivos_Sec
{
    class Archivo
    {
       
        string narch;          
        FileStream stream;      
        BinaryWriter writer1;   
        BinaryReader reader1;   

        
        public Archivo()
        {
            narch = ""; 
        }

         
        public void Abrir_Grab(string narch1)
        {
            narch = narch1; 
           
            stream = new FileStream(narch, FileMode.CreateNew, FileAccess.Write);
           
            writer1 = new BinaryWriter(stream);
        }

       
        public void Grabar(int n)
        {
            writer1.Write(n); 
        }

        
        public void Cerrar_Grab()
        {
            writer1.Close(); 
            stream.Close();  
        }

        
        public void Abrir_Leer(string narch1)
        {
            narch = narch1; 
          
            stream = new FileStream(narch, FileMode.Open, FileAccess.Read);
            
            reader1 = new BinaryReader(stream);
        }

        
        public int leer()
        {
            int n; 
            n = reader1.ReadInt32(); 
            return n; 
        }

  
        public void Cerrar_Leer()
        {
            reader1.Close(); 
            stream.Close(); 
        }


        public bool Verif_Fin()
        {
        
            return stream.Position == stream.Length;
        }

        //------------------------------------------------------------------------------------
       

     
        public void Ejer1(string narch1, string narch2, Archivo a2)
        {
            entero na = new entero(); 
            Abrir_Leer(narch1);       
            a2.Abrir_Grab(narch2);    

          
            while (!Verif_Fin())
            {
                na.cargar(leer()); 
                if (na.VerifPri()) 
                    a2.Grabar(na.descargar()); 
            }

            Cerrar_Leer();   
            a2.Cerrar_Grab(); 
        }





        public void Ejercicio2(string archEntrada, string archSalida, int n1, int n2)
        {
            entero na = new entero();
            Abrir_Leer(archEntrada);       
            Archivo aux = new Archivo();   
            aux.Abrir_Grab(archSalida);    

            while (!Verif_Fin())
            {
                na.cargar(leer());             
                if (na.descargar() == n1)      
                    aux.Grabar(n2);
                else
                    aux.Grabar(na.descargar()); 
            }

            Cerrar_Leer();
            aux.Cerrar_Grab();
        }

        
        public void Ejer3(string narch1, string narch2, string narch3, Archivo a2, Archivo a3)
        {
          
            Abrir_Leer(narch1);
        
            a2.Abrir_Leer(narch2);
   
            a3.Abrir_Grab(narch3);

       
            entero na1 = new entero();
           
            entero na2 = new entero();

          
            int i = 0, j = 0;
      
            bool b1 = true, b2 = true;

   
            if (!Verif_Fin())
            {
                na1.cargar(leer()); 
                i = na1.descargar(); 
            }
            else
            {
                b1 = false; 
            }

          
            if (!a2.Verif_Fin())
            {
                na2.cargar(a2.leer()); 
                j = na2.descargar(); 
            }
            else
            {
                b2 = false;
            }

         
            while (b1 || b2) 
            {
                if (b1 && (!b2 || i <= j)) 
                {
                    a3.Grabar(i); 
                    if (!Verif_Fin())
                    {
                        na1.cargar(leer());
                        i = na1.descargar(); 
                    }
                    else
                    {
                        b1 = false; 
                    }
                }
                else if (b2) 
                {
                    a3.Grabar(j); 
                    if (!a2.Verif_Fin())
                    {
                        na2.cargar(a2.leer()); 
                        j = na2.descargar(); 
                    }
                    else
                    {
                        b2 = false; 
                    }
                }
            }

          
            Cerrar_Leer();
            a2.Cerrar_Leer(); 
            a3.Cerrar_Grab(); 
        }

        //examen

        // Ejercicio: Seleccionar elementos capicúas
        public void SeleccionarCapicuas(string narch1, string narch2, Archivo a2)
        {
            entero na = new entero();
            Abrir_Leer(narch1);
            a2.Abrir_Grab(narch2);

            while (!Verif_Fin())
            {
                na.cargar(leer());
                int x = na.descargar();
                if (EsCapicua(x))
                    a2.Grabar(x);
            }

            Cerrar_Leer();
            a2.Cerrar_Grab();
        }

        // Método auxiliar para verificar si un número es capicúa
        private bool EsCapicua(int num)
        {
            int original = num, invertido = 0;
            while (num > 0)
            {
                int dig = num % 10;
                invertido = invertido * 10 + dig;
                num = num / 10;
            }
            return original == invertido;
        }


    }
}
