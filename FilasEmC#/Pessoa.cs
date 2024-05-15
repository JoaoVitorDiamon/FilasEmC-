using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilasEmC_
{
    public class Pessoa
    {
        public string nome;
        public bool prioridade;

    
    
    public Pessoa(string nome, bool prioridade = false)
        {
            this.nome = nome;
            this.prioridade = prioridade;
        }
    
    }



}
