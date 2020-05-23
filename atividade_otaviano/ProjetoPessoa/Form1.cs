using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPessoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pessoa obj = new Pessoa();

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Nome = txtNome.Text;
                obj.DataNascimento = DateTime.Parse(txtDataNascimento.Text);
                obj.Altura = double.Parse(txtAltura.Text);
                MessageBox.Show("Dados armazenados.");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Erro de Divisão por Zero.\n" + ex.Message);
            }
            catch (FormatException ex)      //objeto ex armazena as informações geradas pela exceção
            {
                MessageBox.Show("Erro de execução.\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados obtidos: " + obj.ImprimeDados() + "\n\nIdade: " + obj.CalcularIdade().ToString("00"));
            txtImc.Text = obj.CalcularIdade().ToString();
        }
    }
}
