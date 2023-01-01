using System;

namespace App.Classes
{
    public class Master
    {
    private int codigo;
    public int Codigo{
        get{
            return codigo;
        }
        set{
            if(value > 9999 && value < 100000)
            {
                codigo = value;
            } else
            {
                Console.WriteLine("Codigo de Produto inválido");
            }
        }
    }
    
    public int Estoque;
    public int Minimo;
    public int Quantidade;
    public int QuantidadeTotal;
    public int Situacao;
    public int Canal;
    public int Apos;
    public int Necessidade;
    public int Transferencia;
    public int Linha;
    public int Naoencontrado;
    public int VendasPorCanal;
    }
}