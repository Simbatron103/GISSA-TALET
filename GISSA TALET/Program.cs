namespace GISSA_TALET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            bool svårtmedköraomgrej = true;

            while (svårtmedköraomgrej)
            {
                Console.WriteLine("Välj vilka tal det ska vara mellan:");
                int tal1 = Convert.ToInt32(Console.ReadLine());
                int tal2 = Convert.ToInt32(Console.ReadLine());

                int random = rng.Next(tal1, tal2 + 1); 
                int tries = 3;
                bool rättsvar = false;

                Console.WriteLine("Gissa talet mellan " + tal1 + " och " + tal2);

                for (int i = 0; i < tries; i++)
                {
                    int guess = Convert.ToInt32(Console.ReadLine());

                    if (random == guess)
                    {
                        Console.WriteLine("Wow du gissade rätt!");
                        rättsvar = true;
                        break;
                    }
                    else if (guess > random)
                    {
                        Console.WriteLine("Du gissade för högt");
                    }
                    else if (guess < random)
                    {
                        Console.WriteLine("Du gissade för lågt");
                    }

                    if (i == tries - 1 )
                    {
                        Console.WriteLine("Inga gissningar kvar, det rätta talet var: " + random);
                    }
                }

                Console.WriteLine("Vill du köra igen? 1 för ja och 2 för nej");
                int response = Convert.ToInt32(Console.ReadLine());

                if (response == 1)
                {
                  
                    continue;
                }
                else if (response == 2)
                {
                    Console.WriteLine("Iväg med dig då");
                        svårtmedköraomgrej = false;
                    
                }
            }   }
    }
}
