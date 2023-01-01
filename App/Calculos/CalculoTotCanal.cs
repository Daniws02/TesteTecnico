using System.Collections.Generic;
using App.Classes;

namespace App.Calculos
{
    public class CalculoTotCanal
    {
        public static void Calculo(List<Venda>Vendas, int[] TotCanais)
        {   
            int numero = 1;
            foreach(var i in TotCanais)
            {   
                foreach(var j in Vendas)
                {   
                    if(j.Canal == numero && (j.Situacao == 100 || j.Situacao == 102))
                    {
                        TotCanais[numero-1] = TotCanais[numero-1] + j.Quantidade;
                    }
                }
                numero++;
            }
            
        }
    }
}