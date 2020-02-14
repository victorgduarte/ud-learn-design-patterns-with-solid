namespace _05_D_principio_da_inversao_de_dependencia
{
    class Funcionario : Pagavel
    {
        private string cargo;
        private double valorDoItem;
        private double comissao;

   
        public double GetComissao()
        {
            return this.comissao;
        }

        public string GetCargo()
        {
            return cargo;
        }

        public void SetValorASerPago(double valor)
        {
            this.valorDoItem = valor;
        }


        public double GetRemuneracao()
        {
            double remuneracao = this.valorDoItem;

            if (this.GetCargo() == "Representante")
                return remuneracao + comissao;

            return remuneracao;
        }

    }


    class Pagamento
    {
        private Funcionario funcionario;


        public double getSalario()
        {
            if(funcionario.GetCargo() == "Representante")
                return funcionario.GetComissao();
            
            return funcionario.getSalario();
        }







    }
}





