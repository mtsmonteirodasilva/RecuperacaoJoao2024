using System;
using System.IO;
using System.Windows;

namespace CadastroSistema
{
    public partial class CursoListagem : Window
    {
        public CursoListagem()
        {
            InitializeComponent();
        }

        private void CarregarCursos_Click(object sender, RoutedEventArgs e)
        {
            lstCursos.Items.Clear();

            if (File.Exists("Cursos.txt"))
            {
                var linhas = File.ReadAllLines("Cursos.txt");
                foreach (var linha in linhas)
                {
                    lstCursos.Items.Add(linha);
                }
            }
            else
            {
                MessageBox.Show("Nenhum curso cadastrado ainda.");
            }
        }
    }
}