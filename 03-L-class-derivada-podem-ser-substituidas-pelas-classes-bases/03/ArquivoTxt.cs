using System; 

namespace _03
{
    class ArquivoTxt:IArquivoEscrever, IArquivoLer
    {
        
        public void Escrever()
        {
            Console.WriteLine("Escrevendo");
        }

        public void Ler()
        {
            Console.WriteLine("Lendo");
        }

    }
}   