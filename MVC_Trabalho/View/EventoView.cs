using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Trabalho.Model;

namespace MVC_Trabalho.View
{
    public class EventoView
    {

        public void Listar(List<Evento> Evento)
        {
            foreach (var item in Evento)
            {
                Console.WriteLine($"Data: {item.Data}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Descricao: {item.Descricao}");
            }
        }
        public Evento Cadastrar()
        {
            Evento novoEvento = new Evento();

            Console.WriteLine($"Informe a Data:");
            novoEvento.Data = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o Nome:");
            novoEvento.Nome = Console.ReadLine();

            Console.WriteLine($"Informe a Descricao ");
            novoEvento.Descricao = Console.ReadLine();

            return novoEvento;

        }
    }
}