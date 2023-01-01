using System;
using System.Collections.Generic;
using App.Classes;
using App.Calculos;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Project();
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception" + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        static void Project()
        {
            List<Produto>Produtos = new List<Produto>();

            List<Venda>Vendas = new List<Venda>();

            List<Transfere>Transferes = new List<Transfere>();

            List<Divergencia>Divergencias = new List<Divergencia>();

            int[] TotCanais = new int[4];

            // Leitura

            Produto.Ler(Produtos);

            Venda.Ler(Vendas);

            // Calculo

            CalculoTransfere.Calculo(Produtos, Vendas, Transferes);

            CalculoDivergencia.Calculo(Produtos, Vendas, Divergencias);

            CalculoTotCanal.Calculo(Vendas, TotCanais);

            // Impressão

            Transfere.Escrever(Transferes);

            Divergencia.Escrever(Divergencias);

            TotCanal.Escrever(TotCanais);

            // Teste

        }
    }
}
