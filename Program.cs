using System;
using System.Threading;

namespace Project_MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, op;
            int num, acertos = 0, erros = 0;

            Console.Title = "Jogo da Memória";
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("------Jogo da Memória------\n");

            Console.WriteLine("Seja Bem Vindo ao Jogo da memória!!!\n");

            Console.WriteLine("Existem 7 Nivéis\n1- Iniciante\n2- Básico\n3- Intermediário\n4- Dificil\n5- Avançado\n6- Super Avançado\n7- Impossível");

            Console.Write("Digite o nível desejado: ");
            op = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(600);
            Console.Clear();

            if (op == 1)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;

                Console.WriteLine("Nível 1");
                Console.WriteLine("São necessários 3 acertos para avançar!!!");
                Thread.Sleep(2000);
                Console.Clear();

                int[] vetor = new int[4];
                Random random = new Random();

                for (i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = random.Next(1, 50);
                }

                for (i = 0; i < vetor.Length; i++)
                {
                    Console.WriteLine(vetor[i]);
                    Thread.Sleep(2200);
                    Console.Clear();
                }

                Thread.Sleep(100);
                Console.Clear();

                for (i = 0; i < vetor.Length; i++)
                {
                    Console.WriteLine("Qual foi o " + (i + 1) + "° Número ?");
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == vetor[i])
                    {
                        Console.WriteLine("Correto!!!\n");
                        ++acertos;
                        Thread.Sleep(1200);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Incorreto\n");
                        ++erros;
                        Thread.Sleep(1200);
                        Console.Clear();
                    }
                }
                Console.WriteLine("Você teve {0} Acertos e {1} Erros", acertos, erros);

                if (acertos >= 3)
                {
                    Console.WriteLine("Proximo Nível!!!");
                    Thread.Sleep(5000);
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Fim de Jogo!!!!");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
            if (acertos >= 3 || op == 2)
            {
                acertos = 0;

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Blue;

                Console.WriteLine("Nível 2");
                Console.WriteLine("São necessários 4 acertos para avançar");
                Thread.Sleep(2000);
                Console.Clear();

                int[] vetor = new int[7];
                Random random = new Random();

                for (i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = random.Next(0, 120);
                }

                for (i = 0; i < vetor.Length; i++)
                {
                    Console.WriteLine(vetor[i]);
                    Thread.Sleep(2100);
                    Console.Clear();
                }

                Thread.Sleep(100);
                Console.Clear();

                for (i = 0; i < vetor.Length; i++)
                {
                    Console.WriteLine("Qual foi o " + (i + 1) + "° Número ?");
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == vetor[i])
                    {
                        Console.WriteLine("Correto!!!\n");
                        ++acertos;
                        Thread.Sleep(1200);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Incorreto\n");
                        ++erros;
                        Thread.Sleep(1200);
                        Console.Clear();
                    }
                }
                Console.WriteLine("Você teve {0} Acertos e {1} Erros", acertos, erros);

                if (acertos >= 4)
                {
                    Console.WriteLine("Proximo Nível!!!");
                    Thread.Sleep(4000);
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Fim de Jogo!!!!");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
            if (acertos >= 4 || op == 3)
            {
                acertos = 0;

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Nível 3");
                Console.WriteLine("São necessários 5 acertos para avançar");
                Thread.Sleep(2000);
                Console.Clear();

                int[] vetor = new int[9];
                Random random = new Random();

                for (i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = random.Next(0, 300);
                }

                for (i = 0; i < vetor.Length; i++)
                {
                    Console.WriteLine(vetor[i]);
                    Thread.Sleep(2000);
                    Console.Clear();
                }

                Thread.Sleep(100);
                Console.Clear();

                for (i = 0; i < vetor.Length; i++)
                {
                    Console.WriteLine("Qual foi o " + (i + 1) + "° Número ?");
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == vetor[i])
                    {
                        Console.WriteLine("Correto!!!\n");
                        ++acertos;
                        Thread.Sleep(1200);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Incorreto\n");
                        ++erros;
                        Thread.Sleep(1200);
                        Console.Clear();
                    }
                }
                Console.WriteLine("Você teve {0} Acertos e {1} Erros", acertos, erros);

                if (acertos >= 5)
                {
                    Console.WriteLine("Proximo Nível!!!");
                    Thread.Sleep(4000);
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Fim de Jogo!!!!");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
            if (acertos >= 5 || op == 4)
            {
                acertos = 0;

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Nível 4");
                Console.WriteLine("São necessários 6 acertos para avançar");
                Thread.Sleep(2000);
                Console.Clear();

                int[] vetor = new int[11];
                Random random = new Random();

                for (i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = random.Next(0, 1200);
                }

                for (i = 0; i < vetor.Length; i++)
                {
                    Console.WriteLine(vetor[i]);
                    Thread.Sleep(1900);
                    Console.Clear();
                }

                Thread.Sleep(100);
                Console.Clear();

                for (i = 0; i < vetor.Length; i++)
                {
                    Console.WriteLine("Qual foi o " + (i + 1) + "° Número ?");
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == vetor[i])
                    {
                        Console.WriteLine("Correto!!!\n");
                        ++acertos;
                        Thread.Sleep(1200);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Incorreto\n");
                        ++erros;
                        Thread.Sleep(1200);
                        Console.Clear();
                    }
                }
                Console.WriteLine("Você teve {0} Acertos e {1} Erros", acertos, erros);

                if (acertos >= 6)
                {
                    Console.WriteLine("Proximo Nível!!!");
                    Thread.Sleep(4000);
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Fim de Jogo!!!!");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
            if (acertos >= 6 || op == 5)
            {
                acertos = 0;

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Nível 5");
                Console.WriteLine("São necessários 7 acertos para avançar");
                Thread.Sleep(2000);
                Console.Clear();

                int[] vetor = new int[13];
                Random random = new Random();

                for (i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = random.Next(0, 9890);
                }

                for (i = 0; i < vetor.Length; i++)
                {
                    Console.WriteLine(vetor[i]);
                    Thread.Sleep(1800);
                    Console.Clear();
                }

                Thread.Sleep(100);
                Console.Clear();

                for (i = 0; i < vetor.Length; i++)
                {
                    Console.WriteLine("Qual foi o " + (i + 1) + "° Número ?");
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == vetor[i])
                    {
                        Console.WriteLine("Correto!!!\n");
                        ++acertos;
                        Thread.Sleep(1200);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Incorreto\n");
                        ++erros;
                        Thread.Sleep(1200);
                        Console.Clear();
                    }
                }
                Console.WriteLine("Você teve {0} Acertos e {1} Erros", acertos, erros);

                if (acertos >= 7)
                {
                    Console.WriteLine("Proximo Nível!!!");
                    Thread.Sleep(4000);
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Fim de Jogo!!!!");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
            if (acertos >= 7 || op == 6)
            {
                acertos = 0;

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Nível 6");
                Console.WriteLine("São necessários 9 acertos para avançar");
                Thread.Sleep(2000);
                Console.Clear();

                int[] vetor = new int[15];
                Random random = new Random();

                for (i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = random.Next(0, 12000);
                }

                for (i = 0; i < vetor.Length; i++)
                {
                    Console.WriteLine(vetor[i]);
                    Thread.Sleep(1700);
                    Console.Clear();
                }

                Thread.Sleep(100);
                Console.Clear();

                for (i = 0; i < vetor.Length; i++)
                {
                    Console.WriteLine("Qual foi o " + (i + 1) + "° Número ?");
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == vetor[i])
                    {
                        Console.WriteLine("Correto!!!\n");
                        ++acertos;
                        Thread.Sleep(1200);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Incorreto\n");
                        ++erros;
                        Thread.Sleep(1200);
                        Console.Clear();
                    }
                }
                Console.WriteLine("Você teve {0} Acertos e {1} Erros", acertos, erros);

                if (acertos >= 9)
                {
                    Console.WriteLine("Proximo Nível!!!");
                    Thread.Sleep(4000);
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Fim de Jogo!!!!");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
            if (acertos >= 9 || op == 7)
            {
                acertos = 0;

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Nível 7");
                Console.WriteLine("São necessários 11 acertos para Vencer");
                Thread.Sleep(2000);
                Console.Clear();

                int[] vetor = new int[17];
                Random random = new Random();

                for (i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = random.Next(30000, 990000);
                }

                for (i = 0; i < vetor.Length; i++)
                {
                    Console.WriteLine(vetor[i]);
                    Thread.Sleep(1500);
                    Console.Clear();
                }

                Thread.Sleep(100);
                Console.Clear();

                for (i = 0; i < vetor.Length; i++)
                {
                    Console.WriteLine("Qual foi o " + (i + 1) + "° Número ?");
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == vetor[i])
                    {
                        Console.WriteLine("Correto!!!\n");
                        ++acertos;
                        Thread.Sleep(1200);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Incorreto\n");
                        ++erros;
                        Thread.Sleep(1200);
                        Console.Clear();
                    }
                }
                Console.WriteLine("Você teve {0} Acertos e {1} Erros", acertos, erros);

                if (acertos >= 11)
                {
                    Console.WriteLine("Parabéns você concluiu o ultimo nível!!!!!");
                    Thread.Sleep(7000);
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Fim de Jogo!!!!");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
        }
    }
}