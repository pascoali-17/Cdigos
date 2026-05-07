using System;
using System.Windows.Forms;

namespace CadastroProdutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtDescricao.Text) ||
                string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            if (!decimal.TryParse(txtValor.Text, out decimal valor))
            {
                MessageBox.Show("Valor inválido!");
                return;
            }

            MessageBox.Show("Produto salvo com sucesso!");

            txtCodigo.Clear();
            txtDescricao.Clear();
            txtValor.Clear();
            txtCodigo.Focus();
        }
    }
}