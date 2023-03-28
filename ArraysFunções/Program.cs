using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace ArraysFunções
{
    internal class Program
    {

        static void Main(string[] args)
        {



            int[] NumerosImputados = new int[10];
            Console.WriteLine("Digite a sequencia desejada: ");
            NumerosImputados[0] = Convert.ToInt32(Console.ReadLine());





            for (int i = 0; i < NumerosImputados.Length; i++)
            {

                Console.Write(NumerosImputados[i]);

                if (i != NumerosImputados.Length - 1) 
                    Console.Write(", ");
            }

            
            int maiorValor = NumerosImputados[0];

            for (int i = 0; i < NumerosImputados.Length; i++)
            {
                if (NumerosImputados[i] > maiorValor)
                {
                    maiorValor = NumerosImputados[i];
                }
            }

            Console.WriteLine();

            Console.WriteLine("Maior Valor: " + maiorValor);

            
            int menorValor = NumerosImputados[0];

            for (int i = 0; i < NumerosImputados.Length; i++)
            {
                if (NumerosImputados[i] < menorValor)
                {
                    menorValor = NumerosImputados[i];
                }
            }

            Console.WriteLine();

            Console.WriteLine("Menor Valor: " + menorValor);

            

            int valorTotal = 0;

            for (int i = 0; i < NumerosImputados.Length; i++)
            {
                valorTotal = valorTotal + NumerosImputados[i];
            }

            decimal valorMedio = valorTotal / NumerosImputados.Length; 

            Console.WriteLine();

            Console.WriteLine("Valor Médio: " + valorMedio);

            //Encontrar os 3 maiores

            Array.Sort(NumerosImputados);

            Array.Reverse(NumerosImputados);

            int[] tresMaiores = new int[3];

            for (int i = 0; i < tresMaiores.Length; i++)
            {
                tresMaiores[i] = NumerosImputados[i];
            }

            Console.WriteLine();

            Console.Write("Três Maiores: ");

            for (int i = 0; i < tresMaiores.Length; i++)
            {
                Console.Write(tresMaiores[i]);

                if (i != tresMaiores.Length - 1) 
                    Console.Write(", ");
            }

            Console.WriteLine();

            Array.Reverse(NumerosImputados);

            int qtdNumerosNegativos = 0;

            for (int i = 0; i < NumerosImputados.Length; i++)
            {
                if (NumerosImputados[i] < 0)
                    qtdNumerosNegativos++;
            }

            int[] valoresNegativos = new int[qtdNumerosNegativos]; 

            for (int i = 0; i < NumerosImputados.Length; i++)
            {
                if (NumerosImputados[i] < 0)
                {
                    valoresNegativos[i] = NumerosImputados[i];
                }
            }

            Console.WriteLine();

            Console.Write("Valores Negativos: ");

            for (int i = 0; i < valoresNegativos.Length; i++)
            {
                Console.Write(valoresNegativos[i]);

                if (i != valoresNegativos.Length - 1) 
                    Console.Write(", ");
            }

           
            Console.WriteLine();
            Console.Write("Digite o número para remover: ");
            int numeroParaRemover = Convert.ToInt32(Console.ReadLine()); 

            int qtdNumerosParaRemover = 0;

            for (int i = 0; i < NumerosImputados.Length; i++)
            {
                if (NumerosImputados[i] == numeroParaRemover)
                {
                    qtdNumerosParaRemover++;
                }
            }

            int[] NewSequencia = new int[NumerosImputados.Length - qtdNumerosParaRemover];

            int j = 0;
            for (int i = 0; i < NumerosImputados.Length; i++)
            {
                if (NumerosImputados[i] != numeroParaRemover)
                {
                    NewSequencia[j] = NumerosImputados[i];
                    j++;
                }
            }

            for (int i = 0; i < NewSequencia.Length; i++)
            {
                Console.Write(NewSequencia[i]);

                if (i != NewSequencia.Length - 1) 
                    Console.Write(", ");
            }

            Console.ReadLine();









        }


        }
    } 