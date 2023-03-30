using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  1- Conteúdos da stack podem ser acedidos em qualquer altura 
                2- A stack mantém as variáveis locais 
                3- Os conteúdos de um tipo de valor podem estar na heap 
                4- Os conteúdos de um tipo de valor são sempre colocados na heap 
                5- Os conteúdos de um tipo de referência são sempre colocados na heap 
                6- O garbage collector (gc) limpa memória tanto na stack como na heap 
                7- Podemos atribuir null a tipos de valor 
                8- Sendo a e b tipos de referência, referenciando o mesmo objeto, então modificar os conteúdos de a vai alterar também os conteúdos de b 
                9- Sendo a e b tipos de valor, com o mesmo valor, então modificar a vai alterar b também 
            */
            Console.WriteLine("-- Exercício resolvido em código! --");

            Console.WriteLine("1- Conteúdos da stack podem ser acedidos em qualquer altura?");
            Console.WriteLine("\nPressiona qualquer tecla para saber a resposta...");
            Console.ReadKey();
            Console.Write("Falso");
            
            Console.WriteLine("\n\n2- A stack mantém as variáveis locais");
            Console.WriteLine("\nPressiona qualquer tecla para saber a resposta...");
            Console.ReadKey();
            Console.Write("Verdadeiro");
            
            Console.WriteLine("\n\n3- Conteúdos da stack podem ser acedidos em qualquer altura?");
            Console.WriteLine("\nPressiona qualquer tecla para saber a resposta...");
            Console.ReadKey();
            Console.Write("Verdadeiro");
            
            Console.WriteLine("\n\n4- Os conteúdos de um tipo de valor são sempre colocados na heap?");
            Console.WriteLine("\nPressiona qualquer tecla para saber a resposta...");
            Console.ReadKey();
            Console.Write("Falso");
            
            Console.WriteLine("\n\n5- Os conteúdos de um tipo de referência são sempre colocados na heap?");
            Console.WriteLine("\nPressiona qualquer tecla para saber a resposta...");
            Console.ReadKey();
            Console.Write("Verdadeiro");

            
            Console.WriteLine("\n\n6- O garbage collector (gc) limpa memória tanto na stack como na heap?");
            Console.WriteLine("\nPressiona qualquer tecla para saber a resposta...");
            Console.ReadKey();
            Console.Write("Falso");
            
            Console.WriteLine("\n\n7- Podemos atribuir null a tipos de valor?");
            Console.WriteLine("\nPressiona qualquer tecla para saber a resposta...");
            Console.ReadKey();
            Console.Write("Falso");
            
            Console.WriteLine("\n\n8- Sendo a e b tipos de referência, referenciando"
            + "o mesmo objeto, então modificar os conteúdos de a vai alterar também os conteúdos de b?");
            Console.WriteLine("\nPressiona qualquer tecla para saber a resposta...");
            Console.ReadKey();
            Console.Write("Verdadeiro");
            
            Console.WriteLine("\n\n9- Sendo a e b tipos de valor, com o mesmo valor, então modificar a vai alterar b também?");
            Console.WriteLine("\nPressiona qualquer tecla para saber a resposta...");
            Console.ReadKey();
            Console.Write("Falso");
        }
    }
}
