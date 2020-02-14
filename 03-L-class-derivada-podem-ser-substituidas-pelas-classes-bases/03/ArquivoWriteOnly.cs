using System;

namespace _03
{
    public class ArquivoWriteOnly : IArquivoEscrever
    {
        

        public void Escrever()
        {
            Console.WriteLine("Escrevendo");
        }

    }
}