using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_POO2_20240313
{
    internal class Professor
    {
        public string nome { get; set; }
        public string matricula { get; set; }

        public Professor(string nome, string matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
        }
    }
}
