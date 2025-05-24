using System;

class Program
{
    static void Main()
    {
        ToDoListManager manager = new ToDoListManager();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== TO DO LIST ====");
            manager.ShowTasks();

            Console.WriteLine("\nOpções:");
            Console.WriteLine("1. Adicionar tarefa");
            Console.WriteLine("2. Remover tarefa");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha: ");
            string opcao = Console.ReadLine();


            // Usar switch case para as ações
            // ao invés de chamar o código, chamar funções/métodos para cada ação
            if (opcao == "1")
            {
                Console.Write("Descrição: ");
                string desc = Console.ReadLine();
                manager.AddTask(desc);
            }
            else if (opcao == "2")
            {
                Console.Write("Índice da tarefa a remover: ");
                if (int.TryParse(Console.ReadLine(), out int index))
                {
                    manager.RemoveTask(index);
                }
            }
            else if (opcao == "3")
            {
                break;
            }
        }

        Console.WriteLine("Até mais!");
    }
}
