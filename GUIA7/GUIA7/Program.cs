using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIA7
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (setInt("ejercicio:"))
            {
                case 1:
                    eje1();
                    break;
                case 2:
                    eje2();
                    break;
                case 3:
                    eje3();
                    break;
                case 4:
                    eje4();
                    break;
                case 5:
                    eje5();
                    break;
                case 6:
                    eje6();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }


        static void eje1()
        {
            int mayor=0, menor=0;
            
            int[] edades =new int[setInt("numero de personas")];
            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine("{0}.edad:",i+1);
                edades[i] = setInt();
                if (edades[i]>=18)
                {
                    mayor++;
                }
                else
                {
                    menor++;
                }
            }
            Console.WriteLine("hay {0} mayores de edad",mayor);
            Console.WriteLine("hay {0} menores de edad",menor);

        }


        static void eje2()
        {
            int par = 0, impar = 0;
            int[] numeros = new int[setInt("cantidad de numeros")];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("{0}.ingrese un numero:", i + 1);
                numeros[i] = setInt();
                if (numeros[i] % 2==0)
                {
                    par++;
                }
                else
                {
                    impar++; ;
                }
            }
            Console.WriteLine("hay {0} numeros pares ",par);
            Console.WriteLine("hay {0} numeros impares ",impar);
        }

        static void eje3()
        {int algo,algo2;
            string[][] equipos=new string[setInt("numero de equipos")][];
            for (int i = 0; i < equipos.GetLength(0); i++)
            {
                Console.WriteLine("equipo {0}",i+1);
                algo=setInt("numero de jugadores");
                equipos[i]=new string[algo];
                for (int j = 0; j < algo; j++)
                {
                    Console.WriteLine("nombre de jugador {0}", j + 1);
                    equipos[i][j] = Console.ReadLine();
                }
            }
            for (int m = 0; m < equipos.GetLength(0); m++)
            {
                Console.WriteLine("equipo {0}",m+1);
                Console.WriteLine("nombres de los jugadores");
                algo2=equipos[m].Length;
                for (int c    = 0; c< algo2 ; c  ++)
                {
                    Console.WriteLine(equipos[m][c]);
                }
                Console.WriteLine("-------------------------------------------------------");
            }
        }


        static int setInt(string mensaje="ingrese un entero")
        {
            int num;
            do
            {
                Console.WriteLine(mensaje);
                if (int.TryParse(Console.ReadLine(),out num) && num>0)
                {
                    return num;
                }
            } while (true);
        }

        static void eje4()
        {
            Random gato = new Random();
            int[,] arreglo = new int[5, 5];
            int[,] arreglo2=new int[arreglo.GetLength(1),arreglo.GetLength(0)];
            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                for (int j   = 0; j   < arreglo.GetLength(1); j  ++)
                {
                    arreglo[i, j] = gato.Next(0,10);
                    Console.Write(arreglo[i,j]+" " );

                }
                Console.WriteLine();
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("matriz transpuesta-----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            arreglo2 = matrizTranspuesta(arreglo);
            for (int m   = 0; m < arreglo2.GetLength(0); m++)
            {
                for (int r = 0; r < arreglo2.GetLength(1); r++)
                {
                    Console.Write(arreglo2[m, r] + " ");

                }
                Console.WriteLine();
            }


        }

        static int[,] matrizTranspuesta(int[,] matriz){

            int[,] matriz2 = new int[matriz.GetLength(1), matriz.GetLength(0)];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j   = 0; j   < matriz.GetLength(1); j  ++)
                {
                    matriz2[j, i] = matriz[i, j];
                    
                }
                
            }



            return matriz2;
        }


        static void eje5()
        {
            int[,] arreglo1 = new int[3, 3];
            int[,] arreglo2 = new int[3, 3];

            for (int i = 0; i < arreglo1.GetLength(0); i++)
            {
                for (int j   = 0; j   < arreglo1.GetLength(1); j  ++)
                {
                    arreglo1[i, j] = setInt();
                }
            }
            for (int i = 0; i < arreglo1.GetLength(0); i++)
            {
                for (int j = 0; j < arreglo1.GetLength(1); j++)
                {
                    arreglo2[i, j] = setInt();
                }
            }
            Console.WriteLine(sumArray(arreglo1,arreglo2));


        }


        static int sumArray(int[,] array1,int[,] array2)
        {
            int sum=0;
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j   = 0; j   < array1.GetLength(1); j  ++)
                {
                    sum=sum+(array1[i,j]+array2[i,j]);
                }
                
            }

            return sum;
        }

      static void eje6()
        { int n,cont=0;
            Random num = new Random();
            int[,] arreglo = new int[6, 6];
            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                for (int j   = 0; j   < arreglo.GetLength(1); j  ++)
                {
                    cont = 0;
                    if (i==0 && j==0)
                    {
                        arreglo[i,j] = num.Next(10,100);
                    }
                    else
                    {
                       
                        do
                        {
                            n = num.Next(10, 100);
                            //Console.WriteLine(n);
                            if (i==0 && j!= 0)
                            {
                                for (int m = 0; m < j-1; m++)
                                {
                                    
                                        if (n == arreglo[0, m])
                                        {
                                            cont++;
                                        }
                                    
                                }
                            }
                            else if (j==0 && i !=0)
                            {
                                for (int nn = 0; nn < i - 1; nn++)
                                {

                                    if (n == arreglo[nn, 0])
                                    {
                                        cont++;
                                    }

                                }
                            }
                            else
                            {
                                for (int a = 0; a <i-1; a++)
                                {
                                    for (int b   = 0; b   < j-1; b ++)
                                    {
                                        if (n == arreglo[a, b])
                                        {
                                            cont++;
                                        }
                                    }
                                }
                            }
                        
                        } while (cont>0);
                        arreglo[i, j] = n;
                    }
                    Console.Write(arreglo[i,j]+"  ");
                }
                Console.WriteLine("");
            }
        }




    }
}
