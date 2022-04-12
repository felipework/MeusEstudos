namespace Csproject.Entities
{
    public class EscritaRed : Escrita
    {
        public EscritaRed(string texto) : base(texto)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            EscritaTela();
            Console.ResetColor();
        }

    }
}
