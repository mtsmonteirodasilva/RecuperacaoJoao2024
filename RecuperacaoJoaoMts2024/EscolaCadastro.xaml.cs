using System;
using System.IO;
using System.Windows;
using CadastroSistema.Model;

namespace CadastroSistema
{
    public partial class EscolaCadastro : Window
    {
        public EscolaCadastro()
        {
            InitializeComponent();
        }

        private void SalvarEscola_Click(object sender, RoutedEventArgs e)
        {
            var escola = new Escola
            {
                NomeFantasia = txtNomeFantasia.Text,
                RazaoSocial = txtRazaoSocial.Text,
                Cnpj = txtCnpj.Text,
                Rua = txtRua.Text,
                Numero = txtNumero.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Estado = txtEstado.Text
            };

            string linha = $"{escola.NomeFantasia};{escola.RazaoSocial};{escola.Cnpj};{escola.Rua};{escola.Numero};{escola.Bairro};{escola.Cidade};{escola.Estado}";
            File.AppendAllText("Escolas.txt", linha + Environment.NewLine);

            MessageBox.Show("Escola cadastrada com sucesso!");
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNomeFantasia.Clear();
            txtRazaoSocial.Clear();
            txtCnpj.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
        }
    }
}