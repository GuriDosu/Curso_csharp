
namespace UserMenagerPOO
{
    public class UsuarioAdmin : Usuario
    {
        public UsuarioAdmin(string nome, string email, string senha) : base(nome, email, senha) { }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("Informações do Usuário Admin:");
        }
        public void RedefinirSenha(Usuario usuario)
        {
            Console.WriteLine($"Senha do Usuario {usuario.Nome}, redefinida pelo Admin {Nome}.");   
        }
    }
}
