using System.Collections.Generic;
using App.Classes;

namespace App.Calculos
{
    public class CalculoTransfere
    {
        public static void Calculo(List<Produto>Produtos, List<Venda>Vendas, List<Transfere>Transferes)
        {
            //int necessidade;
            //int transferencia;

            foreach(var i in Produtos)
            {   
                int codigo = i.Codigo;
                int estoque = i.Estoque;
                int minimo = i.Minimo;
                int quantidadetotal = 0;
                int apos = 0;
                int necessidade = 0;
                int transferencia = 0;
                
                foreach(var j in Vendas)
                {
                    if(i.Codigo == j.Codigo && (j.Situacao == 100 || j.Situacao == 102))
                    {   
                        quantidadetotal = Vendasc(quantidadetotal, j.Quantidade);
                    }
                }
                apos = Apos(estoque, quantidadetotal);
                necessidade = Necessidade(minimo, apos);
                transferencia = Transferencia(necessidade);
                Transferes.Add(new Transfere(){Codigo = codigo, Estoque = estoque, Minimo = minimo, QuantidadeTotal = quantidadetotal, Apos = apos, Necessidade = necessidade, Transferencia = transferencia});
                quantidadetotal = 0;
                apos = 0;
                necessidade = 0;
                transferencia = 0;
            }
        }
        static int Vendasc(int quantidadetotal, int quantidade)
        {
            return quantidadetotal + quantidade;
        }
        static int Apos(int estoque, int quantidadetotal)
        {
            return estoque - quantidadetotal;
        }
        static int Necessidade(int minimo, int apos)
        {   
            int necessidade = minimo - apos;
            if(necessidade < 0)
            {
                necessidade = 0;
            }
            return necessidade;
        }
        static int Transferencia(int necessidade)
        {   
            int transferencia = 0;
            if(necessidade > 1 && necessidade < 10)
            {
                transferencia = 10;
            }
            else
            {
                transferencia = necessidade;
            }
            return transferencia;
        }
    }
}
