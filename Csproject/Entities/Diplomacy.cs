namespace Csproject.Entities
{
    public class Diplomacy
    {
        public Diplomacy()
        {
            Console.WriteLine("´´Kligons do not listen to petaQ, this is war!´´ What now?");
            Console.WriteLine("[1] → Beam over Kirk to negotiate ");
            Console.WriteLine("[2] → Beam over Spock to negotiate ");
            Console.WriteLine("[3] → Beam over McCoy to negotiate");
            Console.WriteLine("[4] → Diplomacy failed, attack! ");
            int d = int.Parse(Console.ReadLine());
            switch(d)
            {
                case 1:
                    Console.WriteLine("The Klingons greet Kirk with a troupe of Orion Slave Girls, and he loses track of time. ");
                    YouFail yf = new YouFail();
                break;

                case 2:
                    Console.WriteLine("A sudden ion storm causes a transporter malfunction, sending Evil Spock to negotiate instead.");
                    Console.WriteLine("Led by Evil Spock, the Klingons launch a planet killer at you ( Evil Spock logically chose the winning team ).");
                    YouFail yff = new YouFail();
                break;

                case 3:
                    NotDoctor nt = new NotDoctor();

                break;

                case 4: 
                    ShieldFail sh = new ShieldFail();
                break;
            }
        }
    }
}