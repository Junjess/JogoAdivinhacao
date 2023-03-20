namespace JogoAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numAleatorio = new Random();
            int valorInteiro = numAleatorio.Next(1, 21);
            double valorpontuacao=numAleatorio.NextDouble();
            double pontuacao = 1000;

            Console.WriteLine("BEM-VINDO AO JOGO DA ADIVINHAÇÃO");
            Console.WriteLine("Escolha o nível de dificuldade: ");
            Console.WriteLine("( 1 )-FÁCIL  ( 2 )-MÉDIO  ( 3 )-DIFÍCIL");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    for (int i = 0; i < 15; i++)
                    {
                        Console.WriteLine("Qual o seu chute? ");
                        float numDigitado = float.Parse(Console.ReadLine());
                        if (numDigitado != valorInteiro)
                        {
                            if (numDigitado > valorInteiro)
                            {
                                Console.WriteLine("O número que você digitou é maior que o número secreto.");
                                pontuacao = 1000 - (numDigitado - valorpontuacao) / 2;
                                if (1000 - (numDigitado - valorpontuacao) / 2 < 0)
                                    pontuacao = Math.Abs(pontuacao);
                                Console.WriteLine("Sua pontuação é de : " + Math.Round(pontuacao));
                            }
                            else
                            {
                                Console.WriteLine("O número que você digitou é menor que o número secreto.");
                                pontuacao = 1000 - (numDigitado - valorpontuacao) / 2;
                                if (1000 - (numDigitado - valorpontuacao) / 2 < 0)
                                    pontuacao = Math.Abs(pontuacao);
                                Console.WriteLine("Sua pontuação é de : " + Math.Round(pontuacao));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Você acertou!!");
                            Console.WriteLine("Sua pontuação é de : " + Math.Round(pontuacao));
                            break;
                        }
                    }

                    break;   
                case 2:
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("Qual o seu chute? ");
                        float numDigitado = float.Parse(Console.ReadLine());
                        if (numDigitado != valorInteiro)
                        {
                            if (numDigitado > valorInteiro)
                            {
                                Console.WriteLine("O número que você digitou é maior que o número secreto.");
                                pontuacao = 1000 - (numDigitado - valorpontuacao) / 2;
                                if (1000 - (numDigitado - valorpontuacao) / 2 < 0)
                                    pontuacao = Math.Abs(pontuacao);
                                Console.WriteLine("Sua pontuação é de : " + Math.Round(pontuacao));
                            }
                            else
                            {
                                Console.WriteLine("O número que você digitou é menor que o número secreto.");
                                pontuacao = 1000 - (numDigitado - valorpontuacao) / 2;
                                if (1000 - (numDigitado - valorpontuacao) / 2 < 0)
                                    pontuacao = Math.Abs(pontuacao);
                                Console.WriteLine("Sua pontuação é de : " + Math.Round(pontuacao));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Você acertou!!");
                            Console.WriteLine("Sua pontuação é de : " + Math.Round(pontuacao));
                            break;
                        }
                    }

                    break;
                case 3:
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Qual o seu chute? ");
                        float numDigitado = float.Parse(Console.ReadLine());
                        if (numDigitado != valorInteiro)
                        {
                            if (numDigitado > valorInteiro)
                            {
                                Console.WriteLine("O número que você digitou é maior que o número secreto.");
                                pontuacao = 1000 - (numDigitado - valorpontuacao) / 2;
                                if (1000 - (numDigitado - valorpontuacao) / 2 < 0)
                                    pontuacao = Math.Abs(pontuacao);
                                Console.WriteLine("Sua pontuação é de : " + Math.Round(pontuacao));
                            }
                            else
                            {
                                Console.WriteLine("O número que você digitou é menor que o número secreto.");
                                pontuacao = 1000 - (numDigitado - valorpontuacao) / 2;
                                if (1000 - (numDigitado - valorpontuacao) / 2 < 0)
                                    pontuacao = Math.Abs(pontuacao);
                                Console.WriteLine("Sua pontuação é de : " + Math.Round(pontuacao));
                            }
                        }
                        else
                        {
                            Console.WriteLine("Você acertou!!");
                            Console.WriteLine("Sua pontuação é de : " + Math.Round(pontuacao));
                            break;
                        }
                    }
                    break;
            }
        }
    }
}