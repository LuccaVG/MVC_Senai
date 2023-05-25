using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Trabalho.Model;
using MVC_Trabalho.View;

namespace MVC_Trabalho.Controller
{
    public class EventoController
    {
       
        Evento EventoModel = new Evento();
        EventoView EventoView = new EventoView();

        public void ListarEventos()
        {
            List<Evento> Eventos = EventoModel.Ler();

            EventoView.Listar(Eventos);
        }

    

        public void Cadastrar()
        {
            
            Evento novoEvento = EventoView.Cadastrar();

            EventoModel.Inserir(novoEvento);


        }



    }
    }
