using System;

class Program
{
    static List<string> itens = new List<string>();
    static void Main()
    {
        Menu();
        bool active = true;
        int option = 0;

        while (true)
        {
            Console.WriteLine("\nSelecione uma opção:");
            Console.Write("\n>> ");
            int.TryParse(Console.ReadLine(), out option);
            Console.WriteLine();
            switch (option)
            {
                case 1:
                    AddItem();
                    break;
                case 3:
                    ShowList();
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