namespace Csproject.Entities
{
    public class EscritaYellow : Escrita
    {

        public EscritaYellow(String texto) : base(texto)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            EscritaTela();
            Console.ResetColor();
        }


    }
}