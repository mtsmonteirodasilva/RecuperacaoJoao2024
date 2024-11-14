namespace CadastroSistema.Model
{
    public class Curso
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Coordenador { get; set; }
        public string Status { get; set; } // true = ativo, false = inativo
    }
}
