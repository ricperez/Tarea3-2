using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3_2
{
    class Program
    {
        static int opcion = 0;

        static void Main(string[] args)
        {
            Random newRandom = new Random();
            
            string[] preguntas1 = new string[15];
            //de octal a binario
            preguntas1[0] = "Pase de octal a binario el numero 23 "; //10011
            preguntas1[1] = "Pase de octal a binario el numero 10 "; //01000
            preguntas1[2] = "Pase de octal a binario el numero 34 "; //11100
            preguntas1[3] = "Pase de octal a binario el numero 7 "; //00111
            preguntas1[4] = "Pase de octal a binario el numero 33 "; //11011
            preguntas1[5] = "Pase de octal a binario el numero 27 "; //10111
            preguntas1[6] = "Pase de octal a binario el numero 3 "; //00011
            //de binario a octal
            preguntas1[7] = "Pase de binario a octal el numero 01100 "; //14
            preguntas1[8] = "Pase de binario a octal el numero 00101 "; //5
            preguntas1[9] = "Pase de binario a octal el numero 100001 "; //41
            preguntas1[10] = "Pase de binario a octal el numero 10010 "; //22
            preguntas1[11] = "Pase de binario a octal el numero 01111 "; //17
            preguntas1[12] = "Pase de binario a octal el numero 00001 "; //1
            preguntas1[13] = "Pase de binario a octal el numero 10000 "; //20
            preguntas1[14] = "Pase de binario a octal el numero 01100 "; //14

            string[] preguntas2 = new string[15];
            //de hexadecimal a binario
            preguntas2[0] = "Pase de hexadecimal a binario el numero 1 "; //00001
            preguntas2[1] = "Pase de hexadecimal a binario el numero A "; //01010
            preguntas2[2] = "Pase de hexadecimal a binario el numero 1C "; //11100
            preguntas2[3] = "Pase de hexadecimal a binario el numero 7 "; //00111
            preguntas2[4] = "Pase de hexadecimal a binario el numero 1F "; //11111
            preguntas2[5] = "Pase de hexadecimal a binario el numero 1B "; //11011
            preguntas2[6] = "Pase de hexadecimal a binario el numero 21 "; //100001
            //de binario a hexadecimal
            preguntas2[7] = "Pase de binario a hexadecimal el numero 11101 "; //1D
            preguntas2[8] = "Pase de binario a hexadecimal el numero 10001 "; //11
            preguntas2[9] = "Pase de binario a hexadecimal el numero 00000 "; //0
            preguntas2[10] = "Pase de binario a hexadecimal el numero 11110 "; //1E
            preguntas2[11] = "Pase de binario a hexadecimal el numero 10111 "; //17
            preguntas2[12] = "Pase de binario a hexadecimal el numero 00001 "; //1
            preguntas2[13] = "Pase de binario a hexadecimal el numero 100000 "; //20
            preguntas2[14] = "Pase de binario a hexadecimal el numero 10100 "; //14

            for (int x = 0; x < 10;x++ )
            {
                

            }

            do{
                Console.Clear();
                Console.WriteLine("--Juego de agilida numerica--");
                Console.WriteLine("1.Binario - Octal o Octal - Binario");
                Console.WriteLine("2.Binario - Desimal o Desimal - Binario");
                Console.WriteLine("3.Ver notas");
                Console.WriteLine("4.No jugar");
                Console.WriteLine("Seleccion un clasificacion");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:
                        //Salir
                        break;

                    default:
                        Console.WriteLine("Ingrese un valor valido");
                        break;

                }            
            }while(opcion !=4);     
        }
    }
}
