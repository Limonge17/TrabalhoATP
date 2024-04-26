using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //Declaração de variáveis
        int N, i, NumTeo, NumGildo, voto, VtsTeo = 0, VtsGildo = 0, VtsNulo = 0, VtsBranco = 0;


        //Entrada de dados
        do
        {
        Console.WriteLine("Informe o número de eleitores:(Eles devem ser pelo menos 10!)");
        N = int.Parse(Console.ReadLine());
        }
        while (N <= 9);
        
        //Registrando o número de eleição dos candidatos
        Console.WriteLine("Digite o número do candidato Teobaldo");
        NumTeo = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o número do candidato Astrogildo");
        NumGildo = int.Parse(Console.ReadLine());

        //Estrutura de repetição
        {
            for (i = 1; i <= N; i++)
            {
                Console.WriteLine($"Eleitor {i}/{N} em qual candidato deseja votar? Para votar em branco digite 0!");
                voto = int.Parse(Console.ReadLine());

                if (voto == NumTeo)
                {
                    Console.WriteLine("Voto confirmado em Teobaldo!");
                    VtsTeo++;
                }
                else if (voto == NumGildo)
                {
                    Console.WriteLine("Voto confirmado em Astrogildo!");
                    VtsGildo++;
                }
                else if (voto == 0)
                {
                    Console.WriteLine("Voto em branco!");
                    VtsBranco++;
                }
                else
                {
                    Console.WriteLine("Voto anulado");
                    VtsNulo++;
                }
            }

                //Resultado das eleições
                if (VtsTeo > VtsGildo)
                {
                    Console.WriteLine($"Teobaldo ganhador da eleição com {VtsTeo} votos!");
                }
                else if (VtsGildo > VtsTeo)
                {
                    Console.WriteLine($"Astrogildo ganhador da eleição com {VtsGildo} votos!");
                }
                else
                {
                    Console.WriteLine("Eleição empatada!");
                }
            
        }
    }
}