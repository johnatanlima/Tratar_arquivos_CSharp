﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace FilesText
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            List<string> sobrenome = new List<string>();


            using (StreamReader leitor = new StreamReader("arquivo.txt"))
            {
                while (!leitor.EndOfStream)
                {
                    string linha = leitor.ReadLine();

                    string[] linhaNova = linha.Split(",");

                    nomes.Add(linhaNova[0]);
                    sobrenome.Add(linhaNova[1]);
                }
            }

            for(int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine($" Nome: { nomes[i] } Sobrenome: {sobrenome[i]}" );
            }
        
        }

    }
}
