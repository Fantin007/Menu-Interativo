using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        MenuPrincipal();
    }

    static void MenuPrincipal()
    {
        bool sair = false;
        while (!sair)
        {
            Console.Clear();
            Console.WriteLine("=== MENU PRINCIPAL ===");
            Console.WriteLine("1. Vetores");
            Console.WriteLine("2. Matrizes");
            Console.WriteLine("3. Trabalhar com Lista");
            Console.WriteLine("4. Trabalhar com Fila");
            Console.WriteLine("5. Trabalhar com Pilha");
            Console.WriteLine("6. Algoritmos de Pesquisa");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1": MenuVetores(); break;
                case "2": MenuMatrizes(); break;
                case "3": MenuLista(); break;
                case "4": MenuFila(); break;
                case "5": MenuPilha(); break;
                case "6": MenuPesquisa(); break;
                case "0": sair = true; break;
                default: Console.WriteLine("Opção inválida."); Pausar(); break;
            }
        }
    }

    static void Pausar()
    {
        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
    }

    // === VETORES ===
    static void MenuVetores()
    {
        int[] vetor = new int[10];
        int count = 0;
        bool sair = false;

        while (!sair)
        {
            Console.Clear();
            Console.WriteLine("=== MENU VETORES ===");
            Console.WriteLine("1. Inserir elemento");
            Console.WriteLine("2. Remover último elemento");
            Console.WriteLine("3. Exibir todos os elementos");
            Console.WriteLine("4. Buscar elemento");
            Console.WriteLine("0. Voltar");

            switch (Console.ReadLine())
            {
                case "1":
                    if (count < vetor.Length)
                    {
                        Console.Write("Digite um número: ");
                        vetor[count++] = int.Parse(Console.ReadLine());
                    }
                    else Console.WriteLine("Vetor cheio!");
                    break;
                case "2":
                    if (count > 0)
                    {
                        vetor[--count] = 0;
                        Console.WriteLine("Removido.");
                    }
                    else Console.WriteLine("Vetor vazio!");
                    break;
                case "3":
                    for (int i = 0; i < count; i++)
                        Console.WriteLine($"[{i}] = {vetor[i]}");
                    break;
                case "4":
                    Console.Write("Digite o valor a buscar: ");
                    int valor = int.Parse(Console.ReadLine());
                    bool achou = false;
                    for (int i = 0; i < count; i++)
                        if (vetor[i] == valor)
                        {
                            Console.WriteLine($"Encontrado na posição {i}");
                            achou = true;
                        }
                    if (!achou) Console.WriteLine("Não encontrado.");
                    break;
                case "0": sair = true; break;
                default: Console.WriteLine("Opção inválida."); break;
            }
            Pausar();
        }
    }

    // === MATRIZES ===
    static void MenuMatrizes()
    {
        int[,] matriz = new int[2, 2];
        bool sair = false;

        while (!sair)
        {
            Console.Clear();
            Console.WriteLine("=== MENU MATRIZES ===");
            Console.WriteLine("1. Inserir elementos");
            Console.WriteLine("2. Exibir todos os elementos");
            Console.WriteLine("0. Voltar");

            switch (Console.ReadLine())
            {
                case "1":
                    for (int i = 0; i < 2; i++)
                        for (int j = 0; j < 2; j++)
                        {
                            Console.Write($"Elemento [{i},{j}]: ");
                            matriz[i, j] = int.Parse(Console.ReadLine());
                        }
                    break;
                case "2":
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                            Console.Write($"{matriz[i, j]}\t");
                        Console.WriteLine();
                    }
                    break;
                case "0": sair = true; break;
                default: Console.WriteLine("Opção inválida."); break;
            }
            Pausar();
        }
    }

    // === LISTA ===
    static void MenuLista()
    {
        List<int> lista = new List<int>();
        bool sair = false;

        while (!sair)
        {
            Console.Clear();
            Console.WriteLine("=== MENU LISTA ===");
            Console.WriteLine("1. Inserir");
            Console.WriteLine("2. Remover");
            Console.WriteLine("3. Exibir");
            Console.WriteLine("4. Buscar");
            Console.WriteLine("0. Voltar");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Valor: ");
                    lista.Add(int.Parse(Console.ReadLine()));
                    break;
                case "2":
                    Console.Write("Valor a remover: ");
                    int v = int.Parse(Console.ReadLine());
                    if (!lista.Remove(v))
                        Console.WriteLine("Valor não encontrado.");
                    break;
                case "3":
                    lista.ForEach(i => Console.WriteLine(i));
                    break;
                case "4":
                    Console.Write("Valor a buscar: ");
                    int b = int.Parse(Console.ReadLine());
                    int pos = lista.IndexOf(b);
                    Console.WriteLine(pos >= 0 ? $"Encontrado na posição {pos}" : "Não encontrado.");
                    break;
                case "0": sair = true; break;
                default: Console.WriteLine("Opção inválida."); break;
            }
            Pausar();
        }
    }

    // === FILA ===
    static void MenuFila()
    {
        Queue<int> fila = new Queue<int>();
        bool sair = false;

        while (!sair)
        {
            Console.Clear();
            Console.WriteLine("=== MENU FILA ===");
            Console.WriteLine("1. Inserir");
            Console.WriteLine("2. Remover");
            Console.WriteLine("3. Exibir");
            Console.WriteLine("0. Voltar");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Valor: ");
                    fila.Enqueue(int.Parse(Console.ReadLine()));
                    break;
                case "2":
                    if (fila.Count > 0)
                        Console.WriteLine($"Removido: {fila.Dequeue()}");
                    else Console.WriteLine("Fila vazia!");
                    break;
                case "3":
                    foreach (var i in fila)
                        Console.WriteLine(i);
                    break;
                case "0": sair = true; break;
                default: Console.WriteLine("Opção inválida."); break;
            }
            Pausar();
        }
    }

    // === PILHA ===
    static void MenuPilha()
    {
        Stack<int> pilha = new Stack<int>();
        bool sair = false;

        while (!sair)
        {
            Console.Clear();
            Console.WriteLine("=== MENU PILHA ===");
            Console.WriteLine("1. Empilhar");
            Console.WriteLine("2. Desempilhar");
            Console.WriteLine("3. Exibir");
            Console.WriteLine("0. Voltar");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Valor: ");
                    pilha.Push(int.Parse(Console.ReadLine()));
                    break;
                case "2":
                    if (pilha.Count > 0)
                        Console.WriteLine($"Removido: {pilha.Pop()}");
                    else Console.WriteLine("Pilha vazia!");
                    break;
                case "3":
                    foreach (var i in pilha)
                        Console.WriteLine(i);
                    break;
                case "0": sair = true; break;
                default: Console.WriteLine("Opção inválida."); break;
            }
            Pausar();
        }
    }

    // === PESQUISA ===
    static void MenuPesquisa()
    {
        int[] dados = { 5, 10, 15, 20, 25, 30 };
        Console.Clear();
        Console.WriteLine("=== MENU PESQUISA ===");
        Console.Write("Buscar valor: ");
        int alvo = int.Parse(Console.ReadLine());

        int pos = Array.IndexOf(dados, alvo);
        if (pos >= 0)
            Console.WriteLine($"Encontrado na posição {pos}");
        else
            Console.WriteLine("Valor não encontrado.");
        Pausar();
    }
}
