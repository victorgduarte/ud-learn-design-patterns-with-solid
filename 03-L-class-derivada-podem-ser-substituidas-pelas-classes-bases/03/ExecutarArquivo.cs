namespace _03
{
    class ExecutarArquivo
    {
        public void Executar(Arquivo arq)
        {
            if(arq is IArquivoEscrever)
            {
                ((IArquivoEscrever)arq).Escrever();
            }
            if( arq is IArquivoLer)
            {
                ((IArquivoLer)arq).Ler();
            }
        } 
    }
}