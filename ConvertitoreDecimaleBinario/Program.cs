using System;

namespace ConvertitoreDecimaleBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            int resto, decimale;
            string numbinario="";
            Console.WriteLine("inserisci il numero che vuoi convertire");
            decimale = Convert.ToInt32(Console.ReadLine());
            while(decimale>0)
            {
                resto = decimale % 2;
                decimale = decimale / 2;
                numbinario = Convert.ToString(resto) + numbinario;
            }
            Console.WriteLine($"il numero binario è {numbinario} ");
        }
    }
}
