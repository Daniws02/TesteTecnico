using System;
using System.Collections.Generic;
using System.IO;

namespace App.Classes
{
    public class Divergencia : Master
    {
        public static void Escrever(List<Divergencia>Divergencias)
        {
            DirectoryInfo directory = new DirectoryInfo(Environment.CurrentDirectory);
            FileInfo file = new FileInfo("divergencias.txt");
            string fullfile = file.FullName;

            using(StreamWriter Arquivo = new StreamWriter(@fullfile))
            {   
                foreach(var i in Divergencias)
                {
                    if(i.Situacao == 135)
                    {
                        
                        Arquivo.WriteLine("Linha "+i.Linha+" - Venda cancelada");

                    } else if(i.Situacao == 190)
                    {
                        Arquivo.WriteLine("Linha "+i.Linha+" - Venda não finalizada");
                    } else if(i.Situacao == 999)
                    {
                        Arquivo.WriteLine("Linha "+i.Linha+" - Erro desconhecido. Acionar equipe de TI");
                    } else if(i.Naoencontrado != 0)
                    {
                        Arquivo.WriteLine("Linha "+i.Linha+" - Código de Produto não encontrado "+i.Naoencontrado);
                    }
                }
            }
        }
    }
}