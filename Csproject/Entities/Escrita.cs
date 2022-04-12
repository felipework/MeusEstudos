namespace Csproject.Entities
{
    public abstract class Escrita
    {
        public string Texto { get; set; }

        public Escrita()
        {

        }

        public Escrita(string texto)
        {
            Texto = texto;


        }

        public void EscritaTela()
        {

            char[] arrayText = Texto.ToCharArray();

            foreach (char letra in arrayText)
            {
                Thread.Sleep(80);
                Console.Write(letra);
            }
        }
    }




}
