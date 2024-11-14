using System;
using System.IO;
using System.Windows;

namespace CadastroSistema
{
    public partial class AlunoListagem : Window
    {
        public AlunoListagem()
        {
            InitializeComponent();
        }

        private void CarregarAlunos_Click(object sender, RoutedEventArgs e)
        {
            lstAlunos.Items.Clear();

            if (File.Exists("Alunos.txt"))
            {
                var linhas = File.ReadAllLines("Alunos.txt");
                foreach (var linha in linhas)
                {
                    lstAlunos.Items.Add(linha);
                }
            }
            else
            {
                MessageBox.Show("Nenhum aluno cadastrado ainda.");
            }
        }
    }
}