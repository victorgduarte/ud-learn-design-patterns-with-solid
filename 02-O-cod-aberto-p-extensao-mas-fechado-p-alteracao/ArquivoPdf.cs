using System;

namespace _02_O_cod_aberto_p_extensao_mas_fechado_p_alteracao
{
    class ArquivoPdf : Arquivo
    {
        public override void Gerar()
        {
            Console.WriteLine("Gerei o PDF");
        }
    }
}