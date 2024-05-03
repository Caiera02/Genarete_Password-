using System;
using System.Text;
using System.Windows.Forms;


namespace Gerador_de_Senha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int tamanho;
            if (!int.TryParse(txtPwd.Text, out tamanho) || tamanho <= 0)
            {
                MessageBox.Show("Por favor, insira um tamanho válido para a senha.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string senha = GerarSenha(tamanho);
            label1.Text = senha;

        }

        private string GerarSenha(int tamanho)
        {
            const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=+";
            StringBuilder senha = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < tamanho; i++)
            {
                int index = random.Next(caracteres.Length);
                senha.Append(caracteres[index]);
            }

            return senha.ToString();
        }
    }
}