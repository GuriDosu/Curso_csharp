namespace POO
{

    public class Mouse
    {
        public string Cor { get; set; }
        public int Botoes { get; set; }
        public string Tipo { get; set; }

        public Mouse(string cor, int botoes, string tipo)
        {
            Cor = cor;
            Botoes = botoes;
            Tipo = tipo;
        }
        public void Clicar()
        {
            Console.WriteLine("O mouse foi clicado");
        }
        public void Rolar()
        {
            Console.WriteLine("O mouse foi rolado");
        }
        public void corMouse()
        {
            Console.WriteLine($"A cor do mouse é: {Cor}");

            //Mouse mouseBranco = new Mouse("Mouse branco", 3, "Sem fio");
            //Console.WriteLine($"Cor do Mouse: {mouseBranco.Cor}");
            //mouseBranco.Clicar();
            //mouseBranco.Rolar();

            //Mouse mousePreto = new Mouse("Mouse preto", 2, "Com fio");
            //mousePreto.corMouse();
        }
    }
}