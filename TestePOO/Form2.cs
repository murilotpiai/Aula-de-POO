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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tentar instanciar a classe pessoa 
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Form2";
            pessoa.CPF = "123.123.123-22";

            pessoa.MsgCPFNome();
        }
    }
}
