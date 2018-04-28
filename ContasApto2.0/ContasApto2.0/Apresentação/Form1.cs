using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ContasApto2._0
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle(txbAluguel.Text, txbCondominio.Text, txbEnergia.Text, txbGas.Text, txbTelefone.Text, txbOutros.Text, cmbQtdMoradores.Text);

            if ((controle.respostaTotal == "") || (controle.respostaPessoa == ""))
            {
                MessageBox.Show("Verifique se todos os campos estão preenchidos", "Desenvolvido por Marcos Duarte");
                
            }
            else
            {
                
                MessageBox.Show("O total das despesas é R$ " + controle.respostaTotal + " e o valor por pessoa é R$ " + controle.respostaPessoa , "Desenvolvido por Marcos Duarte");
            }
        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txbAluguel.Text = "";
            txbCondominio.Text = "";
            txbEnergia.Text = "";
            txbGas.Text = "";
            txbTelefone.Text = "";
            txbOutros.Text = "";

            MessageBox.Show("Dados apagados", "Desenvolvido por Marcos Duarte");

        }

        private void sobreOAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão utilizada para exercício de programação orientada a objeto", "Desenvolvido por Marcos Duarte");
        }

        private void sobreODesenvolvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sou o Marcos Duarte, aluno do curso de Análise e Desenvolvimento da UNIP Sorocaba", "Desenvolvido por Marcos Duarte");
        }
    }
}
