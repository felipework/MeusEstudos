namespace Csproject.Entities
{
    public class ShieldFail
    {
        public ShieldFail()
        {
            Console.WriteLine("Your shields fail. Now what? ");
            Console.WriteLine("[1] → Figth on");
            Console.WriteLine("[2] → Run!");
            int sh = int.Parse(Console.ReadLine());
            switch(sh)
            {
                case 1 :
                    PreemptiveStrike weapon = new PreemptiveStrike();
                break;
                case 2:
                    Console.WriteLine("Your ship is taking heavy damege, forcing you to crashland on Ceti Alpha VI. Or wait, is this Ceti Alpha V? ");
                    Console.WriteLine("KHAAAAAN!");
                    YouFail yf = new YouFail();
                break;
            }
        }
    }
}