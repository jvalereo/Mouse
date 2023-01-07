using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula 11, Programação Orientação ao Objeto
            //Inserindo dados, tipo string , float
            //Programa, mouse
            //Jonas Valereo - Técnico em Informática 

            //declarando o objeto mouse da class mouse

            Mouse mouse = new Mouse();

            mouse.nome = "Mouse";
            mouse.cor = "Preto";
            mouse.esquerdo = "Esquerdo";
            mouse.direito = "Direitor";
            mouse.tamanho = 1.5f;
            mouse.peso = 5.0f;
            mouse.marca = "Multilaser";


            //imprimir saida de dados no console, e método WhriteLine, concatenação

            Console.WriteLine("Nome: " + mouse.nome);
            Console.WriteLine("Cor: " + mouse.cor);
            Console.WriteLine("Lado: " + mouse.esquerdo);
            Console.WriteLine("Lado: " + mouse.direito);
            Console.WriteLine("Tamanho: " + mouse.tamanho.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Peso: " + mouse.peso.ToString("F1", CultureInfo.InvariantCulture) + " Kg");
            Console.WriteLine("Marca: " + mouse.marca);
            Console.WriteLine("---------------------------");

            //imprimir saida de dados, chamando o  método da classe mouse

            mouse.Equerdo();
            mouse.Direito();

            //saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();

            //fim do programa


        }
    }
}
