using System;

namespace ConvertitoreDecimaleBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            int resto, decimale, ottale, restoottale;
            string numbinario = "", nbottale = "";
            Console.WriteLine("inserisci il numero decimale che vuoi convertire");
            decimale = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisci il numero ottale che vuoi convertire");
            ottale = Convert.ToInt32(Console.ReadLine());
            while (decimale > 0)
            {
                resto = decimale % 2;
                decimale = decimale / 2;
                numbinario = Convert.ToString(resto) + numbinario;
                restoottale = ottale % 2;
                ottale = ottale / 2;
                nbottale=Convert.ToString

            }
            Console.WriteLine($"il numero binario  è  {numbinario} ");
        }
    }
}
