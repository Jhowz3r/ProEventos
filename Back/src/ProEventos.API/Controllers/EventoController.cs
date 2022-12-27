﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEvento.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {   
        public IEnumerable<Evento> _evento = new Evento[] {
                    new Evento(){
                    EventoId = 1,
                    Tema = "Angular 11 e .NET 5",
                    Local = "Belo Horizonte",
                    Lote = "1º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto.png"
                },
                new Evento() {
                    EventoId = 2,
                    Tema = "Angular e Suas Novidades",
                    Local = "São Paulo",
                    Lote = "2º Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto1.png"
                }
        };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

         [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

          [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

            [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        
    }
}