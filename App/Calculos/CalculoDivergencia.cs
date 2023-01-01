using System;
using System.Collections.Generic;
using App.Classes;

namespace App.Calculos
{
    public class CalculoDivergencia
    {
        public static void Calculo(List<Produto>Produtos, List<Venda>Vendas, List<Divergencia>Divergencias)
        {   
            int linha = 1;
            foreach(var i in Vendas)
            {   
                int situacao = 0;
                int limite = 0;
                int naoencontrado = 0;

                foreach(var j in Produtos)
                {
                    if(i.Codigo != j.Codigo)
                    {
                    limite++;
                    }
                    if(i.Situacao == 135 || i.Situacao == 190 || i.Situacao == 999)
                    {
                        situacao = i.Situacao;
                    }
                }
                if(limite == Produtos.Count)
                {
                    naoencontrado = i.Codigo;
                }

                Divergencias.Add(new Divergencia(){Linha = linha, Situacao = situacao, Naoencontrado = naoencontrado});
                situacao = 0;
                limite = 0;
                naoencontrado = 0;
                linha++;
            }
        }
    }
}