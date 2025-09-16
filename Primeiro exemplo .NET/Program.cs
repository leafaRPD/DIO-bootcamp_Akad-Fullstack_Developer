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
