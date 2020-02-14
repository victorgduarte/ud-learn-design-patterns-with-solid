using System;

namespace _05_D_principio_da_inversao_de_dependencia
{
    class ServicoDePagamento
    {
        private Pagavel quemRecebe;
        private Pagador quemPaga;

        public ServicoDePagamento(Pagavel quemRecebe, Pagador quemPaga)
        {
            this.quemPaga = quemPaga;
            this.quemRecebe = quemRecebe;       
            this.quemPaga.setPagavel(quemRecebe);
        }

        public double Pagar()
        {
            double valor = this.quemPaga.getSalario();
            Console.WriteLine("EStou pagando um valor: "+ valor);
            return valor;
        }
    }
}