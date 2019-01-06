using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulMatrices
{
    class Program
    {
        int[,] matriz1;
        int[,] matriz2;
        int[,] m;
        int f1;
        int f2;
        int c1;
        int c2;
        static void Main(string[] args)
        {
            Program ma = new Program();
            ma.cargarmatriz();
            ma.imprimirMatriz();
            ma.multiplicarmatriz();
            ma.imprimirmultiplicacion();
            Console.ReadKey();
        }
        public void cargarmatriz()
        {
           //int f1, f2, c1, c2;
            Console.WriteLine("***INGRESE EL TAMAÑO DE LA PRIMERA MATRIZ*** ");
            Console.Write("Ingrese la cantidad de FILAS\n");
            f1 = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese la candida de COLUMNAS\n");
            c1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine();           
            Console.WriteLine("***INGRESE EL TAMAÑO DE LA SEGUNDA MATRIZ*** ");
            Console.Write("Ingrese la cantidad de FILAS\n");
            f2 = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese la candida de COLUMNAS\n");
            c2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
           matriz1 = new int[f1 + 1, c1 + 1];
            matriz2 = new int[f2 + 1, c2 + 1]; //Matriz 2
            m = new int[f1 + 1, c2 + 1];//Matriz para la multiplicacion      
            Random r1 = new Random();
            //CONDICIONES 
            //Si la columna de la matriz 1 es igual al numero de filas de la matriz 2 
                //LLENAR MATRIZ 1 
                for (int i = 1; i < matriz1.GetLength(0); i++)
                {
                    for (int j = 1; j < matriz1.GetLength(1); j++)
                    {
                        int num1 = r1.Next(1, 10);//número entre 1 y 1000
                        matriz1[i, j] = num1;
                    }
                }
                //LLENAR MATRIZ 2 
                for (int i = 1; i < matriz2.GetLength(0); i++)
                {
                    for (int j = 1; j < matriz2.GetLength(1); j++)
                    {
                        int num1 = r1.Next(1, 10);//número entre 1 y 1000
                        matriz2[i, j] = num1;
                    }
                }
            Console.WriteLine();
        }
            
        
        public void imprimirMatriz()
        {            
                Console.WriteLine("ELEMENTOS DE LA MATRIZ Nº1 ");
            for (int i = 1; i < matriz1.GetLength(0); i++)
            {
                for (int j = 1; j < matriz1.GetLength(1); j++)
                {
                    Console.Write(matriz1[i, j] + " ");
                }
                Console.WriteLine();
            }
         
            Console.WriteLine("ELEMENTOS DE LA MATRIZ Nº2 ");
            for (int i = 1; i < matriz2.GetLength(0); i++)
            {
                for (int j = 1; j < matriz2.GetLength(1); j++)
                {
                    Console.Write(matriz2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }    
        
        public void multiplicarmatriz()
        {
            if (c1 == f2)
            {
                // Multiplicando las 2 matrices
                for (int i = 1; i <= f1; i++)
                {
                    for (int j = 1; j <= c2; j++)
                    {
                        m[i, j] = 0;
                        for (int z = 1; z <= c1; z++)
                        {
                            m[i, j] = matriz1[i, z] * matriz2[z, j] + m[i, j];
                        }
                        //Console.WriteLine(m[i, j] + " ");
                    }
                }
            }
           
        }

        public void imprimirmultiplicacion()
        {
           
            if (c1 == f2)
            {
                Console.WriteLine();
                Console.WriteLine("***RESULATDO DE LA MULTIPLICACION DE LAS 2 MATRICES***\n");
                for (int i = 1; i <= f1; i++)
                {
                    for (int j = 1; j <= c2; j++)
                    {
                        //Console.WriteLine(m[i, j] + " ");
                        Console.Write("{0} ", m[i, j]);
                        //Muestra el resultado total 
                    }
                    Console.WriteLine();
                    //Si la columna de la matriz 1 no es igual al numero de filasde la matriz 2 no se puede multiplicar
                }
            }
            else
            {
                Console.WriteLine("Error: No se puede multiplicar las matrices"+"  Columnas: {0}!= Filas: {1}",c1,f2);
            }
            
        }
            /*
                } else {
                Console. WriteLine ( "Error: No se puede multiplicar las matrices" + " Columnas: {0}! = Filas: {1}" , c1, f2 ) ;
             
            }


           
        }
 */
    }
}

