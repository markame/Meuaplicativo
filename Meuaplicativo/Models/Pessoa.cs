﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meuaplicativo.Models
{
    public class Pessoa
    {
        private string nome;
        private string endereco;
        private string cpf;

        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Cpf { get => cpf; set => cpf = value; }
    }
}
