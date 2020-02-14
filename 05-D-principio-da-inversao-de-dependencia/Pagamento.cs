namespace _05_D_principio_da_inversao_de_dependencia
{
    class Pagamento : Pagador
    {
        private Pagavel pagavel;

        public double getSalario()
        {
            return pagavel.getRemuneracao();
        }


        public void setPagavel(Pagavel pagavel)
        {
            this.pagavel = pagavel;
        }
    }
}