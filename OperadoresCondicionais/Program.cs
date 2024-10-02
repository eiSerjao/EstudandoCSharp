/*
Introdução a Operadores Condicionais
If e Else e If aninhado
*/

// int quantidadeDeProdutos = 3;

// int quantidadeDeComprar = 0;

// bool possivelVenda = quantidadeDeComprar > 0 && quantidadeDeProdutos >= quantidadeDeComprar;

// Console.WriteLine($"Quantidade em estoque: {quantidadeDeProdutos}");
// Console.WriteLine($"Quantidade compra: {quantidadeDeComprar}");
// Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

// if(quantidadeDeComprar == 0)
// {
//   Console.WriteLine("Venda invalida");
// }
// else if (possivelVenda)
// {
//   Console.WriteLine("Venda Realizada");
// }
// else
// {
//   Console.WriteLine("Venda não realizada");
// }

// =========================================================================================================

// Apredendo o switch casa

// Console.WriteLine("Digita uma Letra: ");
// string letra = Console.ReadLine();

// switch (letra)
// {
//   case "a":
//   case "e":
//   case "i":
//   case "o":
//   case "u":
//     Console.WriteLine("Vogal");
//   break;

//   default:
//     Console.WriteLine("Não é uma vogal");
//     break;
// }

// if (letra == "a")
// {
//   Console.WriteLine("Vogal");
// }	
// else if (letra == "e")
// {
//   Console.WriteLine("Vogal");
// }
// else if(letra == "i")
// {
//   Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//   Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//   Console.WriteLine("Vogal");
// }
// else
// {
//   Console.WriteLine("Não é uma vogal");
// }

//=======================================================================================================================

/*
Operador OR (Pipe,||)
*/

bool ehMaiorDeIdade = true;
bool possuiAutorizacaoDoResponsavel = false;

if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
  Console.WriteLine("Entrada Liberada");
}
else
{
  Console.WriteLine("Entrada não liberada");
}





