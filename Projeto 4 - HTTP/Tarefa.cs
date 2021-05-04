using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_4___HTTP
{
    class Tarefa
    {
        public int userId;
        public int id;
        public string title;
        public bool completed;

        public void Exibir()
        {
            Console.WriteLine("Objeto Tarefa");
            Console.WriteLine($"User id: {userId}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Titulo: {title}");
            Console.WriteLine($"Finalizou?: {completed}");
            Console.WriteLine(" ");
            Console.WriteLine("===========================");
        }

    }
}
