using DotNet.Models.Calculadora;
using System.Diagnostics.CodeAnalysis;


// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um número para somar (ou '0' para encerrar):");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while (numero != 0);

// Console.WriteLine($"A soma dos números digitados é: {soma}");



// Console.WriteLine("Escolha uma operação: \n1 - Somar \n2 - Subtrair \n3 - Multiplicar \n4 - Dividir \n5 - Somar \n6 - Seno \n7 - Coseno \n8 - Tangente\n \n9 - Raiz quadrada \nDigite o número da operação:");
// int operacao = Convert.ToInt32(Console.ReadLine());

// Calculadora calculadora = new Calculadora();

// if (operacao >= 1 && operacao < 6)
// {
//     Console.WriteLine("Digite o valor de x:");
//     int x = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Digite o valor de y:");
//     int y = Convert.ToInt32(Console.ReadLine());

//     switch (operacao)
//     {
//         case 1:
//             calculadora.Somar(x, y);
//             break;
//         case 2:
//             calculadora.Subtrair(x, y);
//             break;
//         case 3:
//             calculadora.Multiplicar(x, y);
//             break;
//         case 4:
//             calculadora.Dividir(x, y);
//             break;
//         case 5:
//             calculadora.Potencia(x, y);
//             break;
//         default:
//             Console.WriteLine("Operação inválida.");
//             break;
//     }
// } else if (operacao >= 6 && operacao <= 8)
// {
//     Console.WriteLine("Digite o ângulo em graus:");
//     double angulo = Convert.ToDouble(Console.ReadLine());

//     switch (operacao)
//     {
//         case 6:
//             calculadora.Seno(angulo);
//             break;
//         case 7:
//             calculadora.Coseno(angulo);
//             break;
//         case 8:
//             calculadora.Tangente(angulo);
//             break;
//         default:
//             Console.WriteLine("Operação inválida.");
//             break;
//     }
// } else if (operacao == 9)
// {
//     Console.WriteLine("Digite o valor para calcular a raiz quadrada:");
//     double valor = Convert.ToDouble(Console.ReadLine());
//     calculadora.RaizQuadrada(valor);
// }
// else
// {
//     Console.WriteLine("Operação inválida.");
// }



// Console.WriteLine("Digite uma letra:");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("A letra digitada é uma vogal.");
//         break;
//     default: // Caso nao seja uma vogal
//         Console.WriteLine("A letra digitada é uma consoante.");
//         break;
// }



// int qtdEmEstoque = 10;
// int qtdCompra = 4;

// if (qtdEmEstoque >= qtdCompra)
// {
//     Console.WriteLine("Compra realizada com sucesso!");
// }
// else if (qtdEmEstoque == 0)
// {
//     Console.WriteLine("Venda invalida");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos estoque suficiente.");
// }