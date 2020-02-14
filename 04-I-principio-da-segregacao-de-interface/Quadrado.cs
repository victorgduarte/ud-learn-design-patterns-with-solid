using System;

namespace _04_I_principio_da_segregacao_de_interface
{
    class Quadrado : NaoRedondo
    {
        
        public void Area()
        {
            Console.WriteLine("A área é de: ");
        }


        
        public void Perimetro()
        {
            Console.WriteLine("O perimetro é de: ");
        }

        


    }
}