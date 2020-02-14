using System;

namespace _04_I_principio_da_segregacao_de_interface
{
    class Program
    {
        /*
        I - Principio da segregação da interface - Uma classe abstrata ou uma interface, deve utilizar todos os 
        métodos herdados por esta abstração

        Nesse exemplo, não precisamos incluir 20 funções uma só interface para apenas nao altera-la futuramente.
        Da maneira que foi implementada estamos respeitando todos as exigencias do SOLID incluise a I
        
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
