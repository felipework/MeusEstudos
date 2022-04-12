namespace Csproject.Entities
{
    public class Choicethree
    {
        public Choicethree()
        {
            Console.Write("[Y/N] - Do you enter the Klingon Neutral Zone Zone to rescue the ship? ");
            char escolhatres = char.Parse(Console.ReadLine());
            if (escolhatres == 'Y' || escolhatres == 'y')
            {
                RedALert AlertaVermelho = new RedALert();
            }
            else if (escolhatres == 'N' || escolhatres == 'n')
            {
                Choicefour c = new Choicefour();
            }
            else
            {
                Console.WriteLine("Não seja burro capitão! Responda corretamente!");
                Choicethree c3 = new Choicethree();
            }
        }
    }
}