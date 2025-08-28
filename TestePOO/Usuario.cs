using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePOO
{
             /*
        Irá herdar da classe de pessoa
        recebendo sesi atriburos 
        Utilozando o sinal de : para realizar
        a herança de classe desejada
                */
    

    public class Usuario : Pessoa
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
