using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> eventos = new Evento[] {
                new Evento() { 
                    EventoId = 1,
                    Tema = "Angular 11 e .NET Core 5",
                    Local = "São Paulo",
                    Lote = "1º Lote",
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    QtdPessoas = 200,
                    ImagemURL = "foto1.jpg"
                },
                new Evento() { 
                    EventoId = 2,
                    Tema = "React",
                    Local = "Mogi das Cruzes",
                    Lote = "2º Lote",
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    QtdPessoas = 300,
                    ImagemURL = "foto2.jpg"
                }
            };
        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return eventos.Where(x => x.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post()";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put({id})";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete({id})";
        }

    }
}
