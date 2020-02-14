using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
           IArquivoEscrever escrita = new ArquivoWriteOnly();
           IArquivoLer leitura = new ArquivoReadOnly();
           ExecutarArquivo exec = new ExecutarArquivo();

            Arquivo arquivo = new ArquivoTxt();

            exec.Executar(arquivo);

            Console.ReadLine();
        }
    }
}
