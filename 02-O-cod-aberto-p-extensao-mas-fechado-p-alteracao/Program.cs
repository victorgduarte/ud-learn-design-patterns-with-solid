using System;
using System.Collections.Generic;

namespace _02_O_cod_aberto_p_extensao_mas_fechado_p_alteracao
{
/*
O codigo deve ser aberto para extensao, e fechado para alteraçao.

Por esse motivo;
A classe ARquivo é abstrata, e é herdada pelas demais classes, que nao são publicas 

Dessa maneira eu sempre extendo o que eu ja tenho, nunca implemento nada...
*/

    class Program
    {
        static void Main(string[] args)
        {
            List<Arquivo> arquivos = new List<Arquivo>();
            ArquivoPdf x = new ArquivoPdf();
            ArquivoWord y = new ArquivoWord();
            ArquivoTxt z = new ArquivoTxt();

            arquivos.Add(x);
            arquivos.Add(y);
            arquivos.Add(z);
            GeradorDeARquivos g = new GeradorDeARquivos();
            g.GerarArquivos(arquivos);
            Console.Read();
        }
    }
}
