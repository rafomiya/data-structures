using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {

        static void Main(string[] args)
        {
            Node<string> node = new Node<string>("test");
            LinkedList<string> myList = new LinkedList<string>("a", "b", "c", "d", "e");
            char choice;

            do
            {
                Console.Clear();
                choice = GetOption();
                Manage(choice, myList);
                Console.ReadKey();
            } while (choice != 'L');
        }

        static char GetOption()
        {
            char option;

            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("[I] Imprimir.");
            Console.WriteLine("[A] Adicionar um valor.");
            Console.WriteLine("[D] Deletar um valor.");
            Console.WriteLine("[S] Pesquisar um valor.");
            Console.WriteLine("[C] Verificar a quantidade de itens.");
            Console.WriteLine("[F] Verificar se está cheia.");
            Console.WriteLine("[E] Verificar se está vazia.");
            Console.WriteLine("[G] Obter um item da lista.");
            Console.WriteLine("[P] Adicionar no fim da lista.");
            Console.WriteLine("[R] Inverter a lista.");
            Console.WriteLine("[L] Sair.");
            Console.WriteLine();
            Console.Write(">>> ");

            string options = "IADSCFEGPRL";

            while (!char.TryParse(Console.ReadLine().ToUpper(), out option) || (!options.Contains(option)))
                Console.Write(">>> ");

            Console.WriteLine();

            return option;
        }

        static void Manage(char option, LinkedList<string> list)
        {
            switch (option)
            {
                case 'I':
                    list.Display();
                    break;

                case 'A':
                    string value;
                    int index;

                    Console.Write("Insira o valor para adicionar: ");
                    value = Console.ReadLine();

                    Console.Write("Insira o index: ");
                    while (!int.TryParse(Console.ReadLine(), out index))
                        Console.Write(">>> ");

                    try
                    {
                        list.Insert(value, index);
                        Console.WriteLine("\nItem inserido!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nErro: item não inserido.");
                        Console.WriteLine($"Mensagem de erro: {e.Message}");
                    }
                    break;

                case 'D':
                    string item;
                    int inputIndex;

                    Console.Write("Insira o valor para deletar: ");
                    item = Console.ReadLine();

                    if (int.TryParse(item, out inputIndex))
                    {
                        try
                        {
                            list.Delete(inputIndex);
                            Console.WriteLine("\nItem deletado!");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\nErro: item não deletado.");
                            Console.WriteLine($"Mensagem de erro: {e.Message}");
                        }
                        break;
                    }

                    try
                    {
                        list.Delete(item);
                        Console.WriteLine("\nItem deletado!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nErro: item não deletado.");
                        Console.WriteLine($"Mensagem de erro: {e.Message}");
                    }
                    break;

                case 'S':
                    int foundIndex;
                    try
                    {
                        Console.Write("Insira o valor para procurar: ");
                        item = Console.ReadLine();
                        foundIndex = list.Search(item);

                        Console.WriteLine($"\nO item está no {foundIndex}º index da lista.");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nItem não encontrado!");
                        Console.WriteLine($"Mensagem de erro: {e.Message}");
                    }
                    break;

                case 'C':
                    Console.WriteLine(list.Count());
                    break;

                case 'F':
                    Console.WriteLine(!list.IsFull() ? "A lista não está cheia." : "A lista está cheia.");
                    break;


                case 'E':
                    Console.WriteLine(list.IsEmpty() ? "A lista está vazia." : "A lista não está vazia.");
                    break;

                case 'L':
                    Console.WriteLine("Tchau!");
                    break;

                case 'G':
                    int indexx;

                    try
                    {
                        Console.WriteLine("Insira o index do item: ");
                        indexx = int.Parse(Console.ReadLine());

                        Console.WriteLine($"\nO item do {indexx}º index da lista é \"{list.Search(indexx)}\".");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nItem não encontrado!");
                        Console.WriteLine($"Mensagem de erro: {e.Message}");
                    }
                    break;

                case 'R':
                    list.Reverse();
                    Console.WriteLine("\nA lista foi invertida com sucesso!");
                    break;

                case 'P':
                    string toBeInserted;

                    try
                    {
                        Console.WriteLine("Insira o item para inserir: ");
                        toBeInserted = Console.ReadLine();

                        list.Push(toBeInserted);
                        Console.WriteLine($"Item inserido com sucesso!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nErro ao inserir!");
                        Console.WriteLine($"Mensagem de erro: {e.Message}");
                    }
                    break;
            }
        }
    }
}
