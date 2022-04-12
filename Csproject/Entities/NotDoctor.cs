namespace Csproject.Entities
{
    public class NotDoctor
    {
        public NotDoctor()
        {
            Console.WriteLine("I'm a doctor, not a _____! ");
            Console.WriteLine("[1] → Miracle worker ");
            Console.WriteLine("[2] → Mind reader ");
            Console.WriteLine("[3] → Diplomant ");
            int nt = int.Parse(Console.ReadLine());
            switch (nt)
            {
                case 1:
                    Console.WriteLine("Klingons are an aggressive species. You whould have needed a miracle.");
                    YouFail vf = new YouFail();
                break;
                case 2:
                    Console.WriteLine("The Klingons had ulterior motives, wich Bones failed failed to deduce.");
                    YouFail vsf = new YouFail();
                break;
                case 3: 
                    Console.WriteLine("McCoy  was propably the worst choice for a diplomatic mission.");
                    YouFail vsfd = new YouFail();
                break;
            }
        }
    }
}