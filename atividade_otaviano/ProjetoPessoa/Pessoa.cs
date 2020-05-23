using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProjetoPessoa
{
    class Pessoa
    {
        private string nome;
        private DateTime dataNascimento;
        private double altura;

        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O nome deve ser obrigatoriamente preenchido.");
                }
            }
            get { return this.nome; }
        }

        public DateTime DataNascimento
        {
            set { this.dataNascimento = value; }
            get { return this.dataNascimento; }
        }

        public double Altura
        {
            set 
            {
              if (value >= 1)
                {
                    this.altura = value;
                }
              else
                {
                    throw new Exception("A altura deverá ser maior que 1 metro.");
                }
              
            }
            get { return this.altura; }
        }

        public string ImprimeDados()
        {
            return "Dados da pessoa: \n\nNome: " + 
                    this.nome + "\nData de Nascimento: " +
                    this.dataNascimento.ToString("dd/MM/yyyy") + 
                    "\nAltura: " + this.altura.ToString("0.00") + "m.";
        }

        public int CalcularIdade()
        {
            return DateTime.Now.Year - this.dataNascimento.Year;
        }
    }
}
