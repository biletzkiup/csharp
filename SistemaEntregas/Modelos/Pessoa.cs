﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Pessoa
    {
        public int PessoaID { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int EnderecoID { get; set; }
        public Endereco _Endereco { get; set; } //Criando relacionamento Pessoa e Endereco





    }
}
