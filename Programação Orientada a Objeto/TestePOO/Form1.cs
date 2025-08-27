using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        private void button1_Click(object sender, EventArgs e)
        {
            /*
Instanciar a nossa classe Pessoa 

Apenas instanciando (ou seja alocando à classe pessoa em memoria)
Composto por
tipo de Dados: Pessoa (Do mesmo tipo da classe)
Variavel: pessoa (Geralmente mesmo nome da classe)
=: atribuir o ponteiro da memoria a variavel
new: ação de alocar na memoria 
Construtor da classe: Pessoa() (o mesmo nome do tipo de dados)
Pessoa pessoa = new Pessoa();
            */
            Pessoa pessoa = new Pessoa();

            /*
Após instanciado, consegue acessar 
o conteudo da classe q é permitido (public)
seguindo o exemplo vamos definir um vvalor para o atributo Nome
Para isso, é preciso usar a variavel com a instancia 
utilizar o sinal de ponto . para acessar as informações 
disponiveis, e utilizar o atributo ou metodo desejado
            */
            pessoa.Nome = "Murilo";
            pessoa.CPF = "000.111.222-33";
            pessoa.DtNascimento = DateTime.Now.Date; //Data atual


            //Criar ou classe pessoa
            Pessoa aluno = new Pessoa();
            aluno.Nome = "Roberto";
            aluno.CPF = "101.101.202-44";
            aluno.DtNascimento = DateTime.Now.Date;

            //Exibir os dados usando o método
            ExibirClasse(pessoa);
            ExibirClasse(aluno);

            pessoa.MsgCPFNome();
            aluno.MsgCPFNome();
        }

        //Criar um metodo para exibir dados da classe Pessoa 
        void ExibirClasse(Pessoa classe)
        {
            MessageBox.Show(
                  "Nome: " + classe.Nome + Environment.NewLine +
                  "CPF: " + classe.CPF + Environment.NewLine +
                  "DtNascimento: " + classe.DtNascimento.ToShortDateString());


        }
    }
}