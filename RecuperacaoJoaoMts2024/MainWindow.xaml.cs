using System.Windows;

namespace CadastroSistema
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Método para abrir a janela de cadastro de escola
        private void AbrirCadastroEscola(object sender, RoutedEventArgs e)
        {
            var escolaCadastro = new EscolaCadastro();
            escolaCadastro.Show();
        }

        // Método para abrir a janela de listagem de escola
        private void AbrirListagemEscola(object sender, RoutedEventArgs e)
        {
            var escolaListagem = new EscolaListagem();
            escolaListagem.Show();
        }

        // Outros métodos para abrir cadastro e listagem de curso e aluno
        private void AbrirCadastroCurso(object sender, RoutedEventArgs e)
        {
            var cursoCadastro = new CursoCadastro();
            cursoCadastro.Show();
        }

        private void AbrirListagemCurso(object sender, RoutedEventArgs e)
        {
            var cursoListagem = new CursoListagem();
            cursoListagem.Show();
        }

        private void AbrirCadastroAluno(object sender, RoutedEventArgs e)
        {
            var alunoCadastro = new AlunoCadastro();
            alunoCadastro.Show();
        }

        private void AbrirListagemAluno(object sender, RoutedEventArgs e)
        {
            var alunoListagem = new AlunoListagem();
            alunoListagem.Show();
        }
    }
}