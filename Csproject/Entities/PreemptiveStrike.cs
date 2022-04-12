namespace Csproject.Entities
{
    public class PreemptiveStrike
    {
        public PreemptiveStrike()
        {
            Console.WriteLine("Choose your weapon. ");
            Console.WriteLine("[1] → Photon torpedos ");
            Console.WriteLine("[2] → Beam tribbles aboard the enemy ship ");
            Console.WriteLine("[3] → Phasers ");
            int weapon = int.Parse(Console.ReadLine());
            switch(weapon)
            {
                case 1:
                    System.Console.WriteLine("You handily defeat the Klingons and are able to beam the survivors of The Kobashi Maru aboard... only to be beamed to Apollo´s planet to worshimp him.");
                    YouFail vs = new YouFail();
                    break;
                case 2:
                    System.Console.WriteLine("A single tribble is left behind on your ship and both ships suffocate in a sea of adorable tribble offspring");
                    YouFail vsf = new YouFail();
                    break;
                case 3:
                    System.Console.WriteLine("Enemy shields still at 100%. ");
                    YouFail vsfd = new YouFail();
                    break;
            }
        }
    }
}