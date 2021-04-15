using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            //Declarando button clique olá mundo
            //Jonas Valereo - Técnico em Informática

            //imprimir saida de dados no MessagemBox

            MessageBox.Show("Olá Mundo!!!", "Messagem", MessageBoxButtons.OK);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Declarando o codigo sair do programa

            Close();
        }

        //Fim do progarma

    }
}
