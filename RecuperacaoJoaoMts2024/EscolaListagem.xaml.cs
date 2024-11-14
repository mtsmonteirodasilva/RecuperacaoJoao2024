using System.IO;
using System.Windows;

namespace CadastroSistema
{
    public partial class EscolaListagem : Window
    {
        public EscolaListagem()
        {
            InitializeComponent();
        }

        private void CarregarEscolas_Click(object sender, RoutedEventArgs e)
        {
            listaEscolas.Items.Clear();

            if (File.Exists("Escolas.txt"))
            {
                string[] linhas = File.ReadAllLines("Escolas.txt");
                foreach (var linha in linhas)
                {
                    listaEscolas.Items.Add(linha);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma escola cadastrada.");
            }
        }
    }
}
