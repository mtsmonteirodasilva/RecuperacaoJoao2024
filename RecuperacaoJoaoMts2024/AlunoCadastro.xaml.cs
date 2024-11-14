using System;
using System.IO;
using System.Windows;
using CadastroSistema.Model;

namespace CadastroSistema
{
    public partial class AlunoCadastro : Window
    {
        public AlunoCadastro()
        {
            InitializeComponent();
        }

        private void SalvarAluno_Click(object sender, RoutedEventArgs e)
        {
            var aluno = new Aluno
            {
                Nome = txtNome.Text,
                Cpf = txtCpf.Text,
                DataNascimento = txtDataNascimento.Text,
                Telefone = txtTelefone.Text,
                Email = txtEmail.Text
            };

            string linha = $"{aluno.Nome};{aluno.Cpf};{aluno.DataNascimento};{aluno.Telefone};{aluno.Email}";
            File.AppendAllText("Alunos.txt", linha + Environment.NewLine);

            MessageBox.Show("Aluno cadastrado com sucesso!");
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtDataNascimento.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
        }
    }
}