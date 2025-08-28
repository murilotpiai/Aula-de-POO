using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePOO
{
    public class Pessoa
    {
       
            /*
    Atributo 
    é composto por 
    Nivel de acesso: Public
    Tipo de dados: string
    Nome do atributo: Nome
    Configuração
    get: leitura
    set: gravação 
            */
            public string Nome { get; set; }
            public string CPF { get; set; }
            public DateTime DtNascimento { get; set; }
      
            /*
        Metodo para exibir o CPF contatenado com o Nome
        EX: CPF - Nome
        Obrigatoriamente para eu acessar o método fora 
        da classe, ele precisa ser PUBLIC
             */

        public void MsgCPFNome()
        {
            MessageBox.Show(CPF + " - " + Nome);    
        }


    }
}
