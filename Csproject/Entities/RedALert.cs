namespace Csproject.Entities
{
    public class RedALert
    {
        public RedALert()
        {
            Console.WriteLine("Rede ALert! Klingons ship emerges from deep space.What do you do?" );   
            Console.WriteLine("[1] = Try Diplomacy ");
            Console.WriteLine("[2] = Retreat");
            Console.WriteLine("[3] = Preemptive strike");

            int ev = int.Parse(Console.ReadLine()); 
            switch (ev)
            {
                case 1:
                    Diplomacy d = new Diplomacy();  
                break;
                case 2:
                    Retreat r = new Retreat();                    
                break;
                case 3:
                    PreemptiveStrike ps = new PreemptiveStrike();                    
                break;
            }
        }
    }
}