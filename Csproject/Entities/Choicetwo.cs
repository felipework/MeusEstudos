namespace Csproject.Entities
{
    public class Choicetwo
    {        
        public Choicetwo()
        { 
            Console.Write("[Y/N] - Do you ignore the distress call? ");
            char escolhadois =  char.Parse(Console.ReadLine());
            if(escolhadois == 'Y' || escolhadois == 'y')
            {
                Console.WriteLine("You crew turns mutinous due to your disgustion lack of morals. ");
                YouFail VocePerdeu = new YouFail();
            }
            else if(escolhadois == 'N' || escolhadois == 'n')
            {
                Choicethree c = new Choicethree();
            }
            else
            {
                Console.WriteLine("Não seja burro capitão! Responda corretamente!");
                Choicetwo c2 = new Choicetwo();
            }            
        }         
    }
}