using Primeiro_exemplo_.NET.Models;

Pessoa pessoa1 = new Pessoa(); // A classe Pessoa chamará uma variável chamada 'pessoa1', que receberá o valor de new Pessoa(). As variáveis são em camelCase.

pessoa1.Nome = "Ze";
pessoa1.Idade = 19;
pessoa1.Apresentar();

/* 
então a convenção do C# é: 
camelCase para variáveis;
PascalCase para Classes, Métodos e Propriedades.
Jamais abreviar os nomes das propriedades. Ex: NomeRepLegalPessoa ao invés de NomeRepresentanteLegalDaPessoa
O nome do arquivo (Pessoa.cs) deve ter o mesmo nome da Classe definida. Ou seja, o exemplo feito estava fora da convenção (estava PessoaFisica.cs).
O único caractere especial aceito é o underline _. Os demais darão erro, incluindo o  traço  - .
*/


//  Operadores condicionais. Exemplos
            //if, else if, else
int quantidadeEmEstoque = 3;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;


if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada");
}
else
{
    Console.WriteLine("Desculpe, a quantidade pedida é maior que nosso estoque.");
}

//usando uma série de opções no mesmo if:
Console.WriteLine("digitar uma palavra ou letra");
string letra = Console.ReadLine();
if (letra == "a" || // o símbolo '||' significa 'ou'. Também chamado de 'pipe' (porque parece um tubo)
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u")
{
    Console.WriteLine("É uma vogal.");
}
else
{
    Console.WriteLine("Não é uma vogal.");
}


//switch case
Console.WriteLine("digitar uma palavra ou letra");
letra = Console.ReadLine(); // a variável 'letra', do tipo string, receberá o valor que o usuário digitar. Não foi escrito que é do tipo string porque ela já havia sido declarada anteriormente. Se não houvesse o exemplo anterior, de número 41, teria que ser declarado também o tipo da variável.

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("É uma vogal.");
        break;

    default:
        Console.WriteLine("Não é uma vogal.");
        break;
}


//o símbolo % dá o resto (chamado de módulo). Exemplo: 9%2 resultará em 1, pois 9/2 resulta em 4 inteiros e sobra 1.

// Operadores lógicos:
// fazer a negação de algo, o 'not': usa-se ! (ponto de exclamação). Exemplo:
bool choveu = true;
bool estaTarde = false;

if (!choveu && estaTarde) // && significa 'AND', ou seja, as 2 condições têm que ser atendidas.
{
    Console.WriteLine("Vou pedalar!"); // ou seja: se não está chovendo (!choveu) E não está tarde (estaTarde é falso), eu vou pedalar.
}





Calculadora calc = new Calculadora();

calc.Somar(3, 4); //vai chamar o método Somar da classe Calculadora, que imprime na tela qual a operação feita e o cálculo
calc.Potencia(3, 2);
calc.Seno(30);



// exemplo de Do While:
int soma = 0, numero = 0;

do
{
    Console.WriteLine("Digite um número (0 -> encerra o programa)");
    numero = Convert.ToInt32(Console.ReadLine());
soma += numero;
}   while (numero != 0) ;

Console.WriteLine($"Total da soma dos números digitados é: {soma}");


// Construindo um menu interativo

string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.WriteLine("Digite uma das opções:");
    Console.WriteLine("1 - Cadastro cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");


opcao = Console.ReadLine();

switch (opcao)
    {
    case "1":
            Console.WriteLine("Cadastro cliente");
            break;

    case "2":
            Console.WriteLine("Buscar cliente");
            break;

    case "3":
            Console.WriteLine("Apagar cliente");
            break;

    case "4":
            Console.WriteLine("Encerrar");
            //Environment.Exit(0); // o programa se encerra e, se mais códigos forem implementados após isso, não rodará. Então o mais corretor é trocar por:
            exibirMenu = false; // assim ele torna o while 'false', o que faz com que encerre o while sem encerrar o programa inteiro.
            break;

    default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}