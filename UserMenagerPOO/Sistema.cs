

namespace UserMenagerPOO
{
    public class Sistema
    {
        private List<Usuario> Usuarios = new List<Usuario>();

        public void AdicionarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
            Console.WriteLine($"Usuário {usuario.Nome} adicionado no Sistema");

        }
        public Usuario BuscarUsuario(string email)
        {
            foreach (var usuario in Usuarios)
            {
                if (usuario.Email == email)
                {
                    return usuario;
                }
            }
            return null;
        }
        public void RemoverUsuario(string email)
        {
            Usuario usuario = BuscarUsuario(email);
            if (usuario != null)
            {
                Usuarios.Remove(usuario);
                Console.WriteLine($"Usuário {usuario.Nome} removido do Sistema");
            }
            else
            {
                Console.WriteLine($"Usuário com email {email} não encontrado.");
            }
        }
        public void ListarUsuarios()
        {
            foreach (var usuario in Usuarios)
            {
                usuario.ExibirInformacoes();
            }
        }
    }
}
