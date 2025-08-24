using System;

class Program
{
    static List<string> itens = new List<string>();
    static void Main()
    {
        bool active = true;
        int option = 0;

        while (active)
        {
            Menu();
            Console.WriteLine("\nSelecione uma opção:");
            Console.Write("\n>> ");
            int.TryParse(Console.ReadLine(), out option);
            Console.WriteLine();
            switch (option)
            {
                case 1:
                    AddItem();
                    break;
                case 2:
                    RemoveItem();
                    break;
                case 3:
                    ShowList();
                    break;
                case 4:
                    Console.WriteLine("Programa fechado.");
                    active = false;
                    break;
            }            
        }

    }
    static void Menu()
    {
        Console.WriteLine("Lista de compras:");
        Console.WriteLine("1. Adicionar item");
        Console.WriteLine("2. Remover item");
        Console.WriteLine("3. Listar item");
        Console.WriteLine("4. Sair");
        Console.WriteLine();
    }
    static void AddItem()
    {
        Console.WriteLine("\nAdicione um item:");
        Console.Write("\n>> ");
        string item = Console.ReadLine();
        itens.Add(item);
        Console.WriteLine();
        ShowList();
    }
    static void RemoveItem()
    {
        int index;
        Console.WriteLine("\nDigite o índice do item para ser removido:");
        Console.WriteLine();
        ShowList();
        Console.Write("\n>> ");
        int.TryParse(Console.ReadLine(), out index);
        if (index < 0 || index >= itens.Count + 1)
        {
            Console.WriteLine($"Index inválido, por favor, entre um número entre 1 e {itens.Count}");
        }
        else
        {
            itens.RemoveAt(index);
        }

    }
    static void ShowList()
    {
        Console.WriteLine("Lista de itens:");
        if (itens.Count > 0)
        {
          for (int i = 0; i < itens.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {itens[i]}");
            }
        }
        else
        {
            Console.WriteLine("Lista vazia. Quando um item for adicionado, será mostrado aqui.");
        }
    }
}