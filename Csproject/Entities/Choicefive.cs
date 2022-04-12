namespace Csproject.Entities
{
    public class Choicefive
    {
        public Choicefive()
        {
            Console.Write("[Y/N] - Do you have a bizarre desire to sword fight everone on the ship? ");
            char e5 = char.Parse(Console.ReadLine());
            if(e5 == 'Y' || e5 == 'y')
            {
                Console.WriteLine("Looks like you drank the water on Pi 2000-your tipsy crew won't be much help today.");
                YouFail yf = new YouFail();
            }
            else if(e5 == 'N' || e5 == 'n')
            {
                Choicesix c6 = new Choicesix();
            }
            else
            {
                Console.WriteLine("Não seja burro capitão! Responda corretamente!");
                Choicefive c5 = new Choicefive();
            }
        }
    }
}