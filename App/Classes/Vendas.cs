using System;
using System.Collections.Generic;
using System.IO;

namespace App.Classes
{
    public class Venda : Master
    {   
        public static void Ler(List<Venda>Vendas)
        {
            string line;
            DirectoryInfo directory = new DirectoryInfo(Environment.CurrentDirectory);
            FileInfo file = new FileInfo("vendas.txt");
            string fullfile = file.FullName;

            using(StreamReader Arquivo = new StreamReader(@fullfile)){
                line = Arquivo.ReadLine();
                while(line!=null)
                {
                    string[] dados = line.Split(";");
                    int codigo = int.Parse(dados[0]);
                    int quantidade = int.Parse(dados[1]);
                    int situacao = int.Parse(dados[2]);
                    int canal = int.Parse(dados[3]);

                    Vendas.Add(new Venda(){Codigo = codigo, Quantidade = quantidade, Situacao = situacao, Canal = canal});

                    line = Arquivo.ReadLine();
                }
                Arquivo.Close();
            }
        }
    }
}