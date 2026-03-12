

namespace UserMenagerPOO
{
    public class UsuarioComun : Usuario
    {
        public UsuarioComun(string nome, string email, string senha) : base(nome, email, senha) { }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Usuario {Nome} = {Email}");
        }
    }
}
