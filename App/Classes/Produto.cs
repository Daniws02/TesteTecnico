using System;
using System.IO;
using System.Collections.Generic;

namespace App.Classes
{
    public class Produto : Master
    {   
        public static void Ler(List<Produto>Produtos)
        {   
            string line;
            DirectoryInfo directory = new DirectoryInfo(Environment.CurrentDirectory);
            FileInfo file = new FileInfo("produtos.txt");
            string fullfile = file.FullName;

            using(StreamReader Arquivo = new StreamReader(@fullfile))
            {
                line = Arquivo.ReadLine();
                while(line!=null)
                {
                    string[] datas = line.Split(";");
                    int codigo = int.Parse(datas[0]);
                    int estoque = int.Parse(datas[1]);
                    int minimo = int.Parse(datas[2]);
                    Produtos.Add(new Produto() {Codigo = codigo, Estoque = estoque, Minimo = minimo});
                    line = Arquivo.ReadLine();
                }
                Arquivo.Close();
            }
        }
    }
}