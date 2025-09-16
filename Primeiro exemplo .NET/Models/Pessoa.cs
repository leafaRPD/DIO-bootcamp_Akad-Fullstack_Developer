using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeiro_exemplo_.NET.Models // isso não significa que está na pasta de mesmo nome, mas é bom manter uma organização, uma padronização para não se perder. Evite deixar o código confuso. Esse caminho <Primeiro_exemplo_.NET.Models> deverá ser passado lá no 'Program.cs' para que o programa ache essa função Pessoa e rode.
{
    public class Pessoa // definição, criação da classe Pessoa. Sempre começar Classe com letra maiúscula (PascalCase).
    // No C# usa-se o PascalCase e o camelCase. 
    {
        public string Nome { get; set; } // propriedade 'Nome' em PascaCase
        public int Idade { get; set; }

        public void Apresentar() // Método, ou função, sempre em PascaCase
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos."); //não esquecer do ponto e vírgula ;
                                                                                //'Console' é uma Classe e 'WriteLine' é um Método. O que está entre parênteses são os parâmetros, ou argumentos.   
        }
    }
}