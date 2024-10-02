using ExemploFundamentos.Models;

// Convertendo de maneira segura

// string a = "15-";

// // int b = 0;

// int.TryParse(a, out int b);

// Console.WriteLine(b);
// Console.WriteLine("COnversão realizada com sucesso!");

//==============================================================================

// //Ordem dos operadores

// //Mudando a ordem dos operadores pode mudar o resultado usando o "()"

// //Seguindo a ordem da matematica
// double a = 4 / 2 + 2;

// //Usando o parentese dando prioridade a soma
// double b = 4 / (2 + 2);


// Console.WriteLine(a);

// Console.WriteLine(b);

//====================================================================================

// Cast Implícito:  Uma conversão de diferetes tipos que você não precisar
//realizar a conversão de forma manual.

// O correndo um Cast Implicito:
// int a = 5 ;
// double b = a;

// Console.WriteLine(b);


// // Aqui o Int são suporta dados do tipo long por isso precisar fazer um 
// // casting manualmente para poder funcionar.
// long c = 5 ;
// int d = Convert.ToInt32(c);

// Console.WriteLine(d);


// int e = int.MaxValue;
// long f = Convert.ToInt32(e);

// Console.WriteLine(f);

//===========================================================================================================

// // Conversãro para String

// Console.WriteLine("Ambos eram do tipo inteiro mas usando o Casting convertemos para String");

// // string a = 5;
// string a = Convert.ToString(5);


// Console.WriteLine($"Valor de um dado inteiro que se converteu em string: {a}");

// int inteiro = 5;
// string b = inteiro.ToString();

// Console.WriteLine($"Valor de uma variavel inteiro que se converteu para String: {b}");

// ======================================================================================

// Convertendo tipos de variáveis

// Fazendo Cast - Casting

// int a = Convert.ToInt32(null);

// // //O Convert é uma classe e Toint é um metodo de conversão.

// int b = int.Parse("6");

// Console.WriteLine(a);

// Console.WriteLine(b);

//=====================================================================================

// Combinando 0peradores:

// int a = 10;
// int b = 20;

// int c = a + b;

// // c = 5;

// c /= 5; // c = c + 5;

// Console.WriteLine(c)

// ===============================================================================

// Usando do DateTime

// DateTime dataAtual  = DateTime.Now.AddDays(7);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

//=================================================================================================

// Tipos de Variaveis

// string apresentar  = "Olá mundo!";

// int quantidade  = 1;

// double altura = 1.86;

// decimal preco = 2.50m;

// bool condicao = true;

// Console.WriteLine(apresentar);
// Console.WriteLine("Valor de variavel quantidade: " + quantidade);
// Console.WriteLine("Valor de variavel altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor de variavel preco: " + preco);
// Console.WriteLine("Valor de variavel  condicao: " + condicao);

//================================================================================================================

// Criando uma Classe, Objetos e Criar e Utilizar Metodos

// Pessoa pessoa1 = new Pessoa();
// Pessoa pessoa2 = new Pessoa();

// pessoa1.Nome = "Paulo";
// pessoa1.Idade = 21;
// pessoa1.Apresentar();

// pessoa2.Nome = "Serjão";
// pessoa2.Idade = 22;
// pessoa2.Apresentar();


