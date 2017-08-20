using System;
using ArgenSearch;

namespace ArgenSearchCoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for(var i=31000000; i < 31000010; i++)
            {
                var result = ArgenSearchClient.Search(i).Result;
                if(result.Success)
                {
                    var persona = ArgenSearchClient.Detail(result.Data[0]).Result;
                    Console.WriteLine(result.Data[0] + " - " + persona.Data.Nombre);
                }

            }
        }
    }
}
