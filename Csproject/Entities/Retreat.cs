namespace Csproject.Entities
{
    public class Retreat
    {
        public Retreat()
        {
            Console.WriteLine("After a long pursuit into an uncharted soltar system. you and the Klingons are captured by Metrons, and they force both ships captains into a trial by combat.");
            Console.WriteLine("[Y or N] - You outsmart your enemy. Do you show mercy? ");
            char rt = char.Parse(Console.ReadLine());
            if(rt == 'Y' || rt == 'y')
            {
                Console.WriteLine("Your enemy exploits your moment of weakness. ");
                YouFail vsf = new YouFail();
            }
            else if(rt == 'N' || rt == 'n')
            {
                Console.WriteLine("The Metrons think you are savage and kill you. ");
                YouFail vsf = new YouFail();
            }
            else
            {
                Console.WriteLine("Não seja burro capitão! Responda corretamente!");
                Retreat r = new Retreat();
            }            
        }
    }
}