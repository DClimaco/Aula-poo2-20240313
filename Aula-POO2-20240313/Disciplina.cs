using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_POO2_20240313
{
    internal class Disciplina
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public Professor professor { get; set; }
        public List<int> requisitos { get; set; }

        public Disciplina(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
            
        }
        public void addRequisito(Disciplina d)
        {
            requisitos.Add(d.codigo);
        }
    }
}
