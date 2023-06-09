﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubeDaLeitura.ConsoleApp.Compartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloRevista;

namespace ClubeDaLeitura.ConsoleApp.ModuloCaixa
{
    public class Caixa : Entidade
    {
        public string Cor;
        public string Etiqueta;
        public int Numero;
        public List<Revista> ListaRevistasNasCaixas = new List<Revista>();

        public Caixa(int id, string cor, string etiqueta, int numero)
        {
            Id = id;
            Cor = cor;
            Etiqueta = etiqueta;
            Numero = numero;
        }
    }
}
