namespace Csproject.Entities
{
    public class EscritaBlue : Escrita
    {
        public EscritaBlue(string texto) : base(texto)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }

    }
}



