using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Mouse
    {

        //Treinamento - Aula 11, Programação Orientação ao Objeto
        //Inserindo dados, tipo string , float
        //Programa, mouse
        //Jonas Valereo - Técnico em Informática 

        //declarando os atributos, campos,variaveis da class mouse

        public string nome;
        public string cor;
        public string esquerdo;
        public string direito;
        public float tamanho;
        public float peso;
        public string marca;


        //declarando os métodos da classe do pessoa

        public void Equerdo()
        {
            Console.WriteLine("Mouse: Clique lado esquerdo");
        }

        public void Direito()
        {

            Console.WriteLine("Mouse: Clique lado direito");
        }

        //fim da classa mouse

    }
}
