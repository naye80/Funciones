using System; 

namespace Funciones
{
class Program
{
    static void Main (string[]args)
    {
        float pi = 3.14f; 
        while (true)
        {
            for (int i=0;i<50;i++)
            {
                System.Console.Write("*");
            }
               System.Console.WriteLine("\nPROGRAMA PARA GEOMETRIA");
               for (int i=0;i<50;i++)
               {
                   System.Console.Write("*");
               }
                System.Console.WriteLine("\n ¿QUE AREA DESEA CALCULAR? \n (c) CIRCULO \n (r) RECTANGULO \n (t) TRIANGULO \n (s) SALIR"); 
                 string Opcion = Console.ReadLine();
                  if(Opcion == "s")   
                  {
                      break;
                  }
                  float resultado = 0f; 
                   if (Opcion == "c")
                  {
                      System.Console.WriteLine("INGRESE EL RADIO: ");
                      int vradio = Int16.Parse(Console.ReadLine());
                      resultado = pi*( vradio*vradio );
                  }
                  else if (Opcion == "r")
                  {
                      System.Console.WriteLine("INGRESE LA BASE: "); 
                      int vbase = Int16.Parse(Console.ReadLine());
                      System.Console.WriteLine("INGRESE LA ALTURA: "); 
                      int valtura = Int16.Parse(Console.ReadLine());
                     resultado = vbase*valtura; 
                  }
                  else
                  {
                      System.Console.WriteLine("INGRESE LA BASE: "); 
                      int vbase = Int16.Parse(Console.ReadLine()); 
                      System.Console.WriteLine("INGRESE LA ALTURA: "); 
                      int valtura = Int16.Parse(Console.ReadLine()); 
                      resultado= (vbase*valtura)/2; 
                  }
                  System.Console.WriteLine("EL RESULTADO ES: "+resultado);
               } 
               System.Console.WriteLine("GRACIAS POR USAR EL PROGRAMA DE CALCULO GEOMETRICO");
            }
        }
    

     
    }

