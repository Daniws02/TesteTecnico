using System;
using System.Collections.Generic;
using System.IO;

namespace App.Classes
{
    public class Transfere : Master
    {
        public static void Escrever(List<Transfere> Transferes)
        {   
            DirectoryInfo directory = new DirectoryInfo(Environment.CurrentDirectory);
            FileInfo file = new FileInfo("transfere.txt");
            string fullfile = file.FullName;

            using(StreamWriter Arquivo = new StreamWriter(@fullfile))
            {
                Arquivo.WriteLine("Necessidade de Transferência Armazém para CO");
                Arquivo.WriteLine("");
                Arquivo.WriteLine("Produto     QtCO        QtMin       QtVendas    Estq.após   Necess.     Transf. de");
                Arquivo.WriteLine("                                                Vendas                  Arm p/ CO");

                string es_codigo = "";
                string es_estoque = "";
                string es_minimo = "";
                string es_quantidadetotal = "";
                string es_apos = "";
                string es_necessidade = "";

                foreach(var i in Transferes)
                {   
                    es_codigo = Espaco(i.Codigo);
                    es_estoque = Espaco(i.Estoque);
                    es_minimo = Espaco(i.Minimo);
                    es_quantidadetotal = Espaco(i.QuantidadeTotal);
                    es_apos = Espaco(i.Apos);
                    es_necessidade = Espaco(i.Necessidade);

                    Arquivo.WriteLine(i.Codigo + es_codigo + i.Estoque + es_estoque + i.Minimo + es_minimo + i.QuantidadeTotal + es_quantidadetotal + i.Apos + es_apos + i.Necessidade + es_necessidade + i.Transferencia);

                    es_codigo = "";
                    es_estoque = "";
                    es_minimo = "";
                    es_quantidadetotal = "";
                    es_apos = "";
                    es_necessidade = "";
                }
                Arquivo.Close();
            }
        }
        public static string Espaco(int numero)
        {   
            string retorno = "";
            int maximo = 12;
            string letras = numero.ToString();
            int tamanho = letras.Length;
            int total = maximo - tamanho;

            for(int i = 1; i <= total; i++)
            {
                retorno = retorno + " ";
            }

            return retorno;
        }
    }
}