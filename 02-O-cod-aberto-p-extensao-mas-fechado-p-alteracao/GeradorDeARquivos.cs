using System;
using System.Collections.Generic;

namespace _02_O_cod_aberto_p_extensao_mas_fechado_p_alteracao
{
    class GeradorDeARquivos
    {
        public void GerarArquivos(IList<Arquivo> arquivos)
        {
            foreach (var arquivo in arquivos)
            {
                arquivo.Gerar();
            }  
        }        
    }
}