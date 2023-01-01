using System;
using System.Collections.Generic;
using System.IO;

namespace App.Classes
{
    public class TotCanal
    {
        public static void Escrever(int[] TotCanais)
        {
            DirectoryInfo directory = new DirectoryInfo(Environment.CurrentDirectory);
            FileInfo file = new FileInfo("totcanal.txt");
            string fullfile = file.FullName;

            using(StreamWriter Arquivo = new StreamWriter(@fullfile))
            {
                    Arquivo.WriteLine("Quantidades de Vendas por canal");
                    Arquivo.WriteLine("");
                    Arquivo.WriteLine("Canal                  QtVendas");
                    Arquivo.WriteLine("1 - Representantes     "+TotCanais[0]);
                    Arquivo.WriteLine("2 - Website            "+TotCanais[1]);
                    Arquivo.WriteLine("3 - App móvel Android  "+TotCanais[2]);
                    Arquivo.WriteLine("4 - App móvel iPhone   "+TotCanais[3]);
            }
        }
    }
}