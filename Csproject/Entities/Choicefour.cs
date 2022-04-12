namespace Csproject.Entities
{
    public class Choicefour
    {
        public Choicefour()
        {
            Console.Write("[Y/N] - Do you send an unarmed shuttle across the Neutral Zone to save the ");
            char escolhaquatro = char.Parse(Console.ReadLine());
            if (escolhaquatro == 'Y' || escolhaquatro == 'y')
            {
                Console.WriteLine("The suttle is absorbed by a giant amoeba. ");
                YouFail vsf = new YouFail();
            }
            else if (escolhaquatro == 'N' || escolhaquatro == 'n')
            {
                Choicefive c5 = new Choicefive();
            }
            else
            {
                Console.WriteLine("Não seja burro capitão! Responda corretamente!");
                Choicefour c4 = new Choicefour();
            }
        }
    }
}