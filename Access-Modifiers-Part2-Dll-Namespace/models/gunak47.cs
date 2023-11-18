
namespace Access_Modifiers_Part2_Dll_Namespace.models
{
    internal class gunak47
    {
        public int gunquantity = 45;
        private object consoleKey;

        public void GunSingleShot()
        {
            int GunCharger = 45;
            gunquantity--;
            Console.WriteLine($" 1 eded mermi azalir {gunquantity} /{GunCharger}");


            if (gunquantity == 0)
            {
                Console.WriteLine(" gulle sayi azalir..");
                Reload();
                return;
            }
        }
        public void Reload()
        {
            if (gunquantity == 45)
            {
                Console.WriteLine("Darağı tam doludur..");
                return;
            }
            gunquantity = 32;
        }
        public void threeshot()
        {
            int Daraq = 45;
            gunquantity = gunquantity - 3;
            Console.WriteLine($"Gulle atildigca uc-uc azalir {gunquantity} /{Daraq}");

            if (gunquantity == 0)
            {
                Console.WriteLine("Daraqdaki gulle sayi azalir..");
                Reload();
                return;
            }
        }
        public void RunMethod()
        {
            while (true)
            {
                ConsoleKeyInfo Metodinfo = Console.ReadKey();
                switch (Metodinfo.Key)
                {
                    case ConsoleKey.S:
                        GunSingleShot();
                        break;
                    case ConsoleKey.M:
                        threeshot();
                        break;
                    case ConsoleKey.R:
                        Reload  ();
                        break;
                }
            }
        }
        public void RunGun()
        {
            RunMethod();
        }
    }
}
    

