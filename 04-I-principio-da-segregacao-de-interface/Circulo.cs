using System;

namespace _04_I_principio_da_segregacao_de_interface
{
    class Circulo : Redondo
    {
        public void Area()
        {
            Console.WriteLine("A área é de: ");
        }


        public void Circunferencia()
        {
            Console.WriteLine("A circunferencia é de: ");
        }

        

        
        public void Raio()
        {
            Console.WriteLine("O Raio é de: ");
        }


    }
}