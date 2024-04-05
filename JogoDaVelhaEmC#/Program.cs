namespace JogoDaVelhaEmC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };
            MostrarTabuleiro(arr);
            Random random = new Random();
            while (true)
            {
                int aux = 1;
                

                while (aux > 0)
                {
                    int aleatorio = random.Next(0, 8);


                    if (arr[aleatorio] == 'X')
                    {
                        continue;
                    }
                    else if (arr[aleatorio] == 'Y') { 
                        continue; 
                    }
                    else
                    {
                        arr[aleatorio] = 'Y';
                        MostrarTabuleiro(arr);
                        aux--;
                    }
                }
                aux++;
                while (aux >0)
                {
                    Console.WriteLine("Digito onde vai jogar o X:");
                    int alterarX = Convert.ToInt32(Console.ReadLine());
                    //arr[alterarX] = 'X';
                    if ( arr[alterarX] == 'Y')
                    {
                        continue;
                    }
                    else if(arr[alterarX] == 'X')
                    {
                        continue;
                    }
                    else
                    {
                        arr[alterarX] = 'X';
                        MostrarTabuleiro(arr);
                        aux--;
                    }
                    MostrarTabuleiro(arr);

                }






            }














        }

        private static void MostrarTabuleiro(char[] arr)
        {
           Console.Clear();
            Console.WriteLine("Jogo da Velha: \n" +
                arr[0] + "|" + arr[1] + "|" + arr[2] + "\n" +
            "-------\n" +
                arr[3] + "|" + arr[4] + "|" + arr[5] + "\n" +
                 "-------\n" +
                arr[6] + "|" + arr[7] + "|" + arr[8] + "\n");
        }
    }
}
