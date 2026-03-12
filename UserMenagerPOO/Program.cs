namespace UserMenagerPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sistema sistema = new Sistema();

            UsuarioAdmin usuarioAdmin = new UsuarioAdmin("Guilherme", "guilhermeproenca0801@gmail.com", "123456789");
            UsuarioComun usuarioComun = new UsuarioComun("Maria", "Maria@gmail.com", "123456");
            sistema.AdicionarUsuario(usuarioAdmin);
            sistema.AdicionarUsuario(usuarioComun);


            usuarioAdmin.RedefinirSenha(usuarioComun);
            sistema.RemoverUsuario(usuarioComun.Email);

            sistema.ListarUsuarios();



        }
    }
}