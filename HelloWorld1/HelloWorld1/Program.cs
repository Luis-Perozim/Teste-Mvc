using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld1
{
    internal class Program
    {
         enum escolha { Criar, Revisar, Atualizar, Deletar }
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("0-Criar\n1-Revisar\n2-atualizar\n3-Deletar");
            int index = int.Parse(Console.ReadLine());
            escolha escolhaFeita = (escolha)index;

            //Console.WriteLine("Esssa foi a sua escolha: " + escolhaFeita);
            switch (escolhaFeita) 
            {
                case escolha.Criar:
                    Console.WriteLine("Sua escolha foi: Criar!");
                    break;
                case escolha.Revisar:
                    Console.WriteLine("Sua escolha foi: Revisar!");
                    break;
                case escolha.Atualizar:
                    Console.WriteLine("Sua escolha foi: Atualizar!");
                    break;
                case escolha.Deletar:
                    Console.WriteLine("Sua escolha foi: Deletar!");
                    break;
                default: Console.WriteLine("ERRO REINICIE O PROGRAMA");
                    break;

            }





            Console.ReadLine();

        }
    }
}
