// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0){
//     Console.WriteLine("Venda inválida");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("venda realizada.");    
// }
// else
// {
//     Console.WriteLine("Desculpe, Não temos a quantidade desejada em estoque.");

// }

/////////////////////////////////////////////////

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// if (letra == "a")
// {
//     Console.WriteLine("vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("vogal");
// }
// else if(letra == "i")
// {
//     Console.WriteLine("vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("vogal");
// }
// else
// {
//     Console.WriteLine("Não é vogal");
// }

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// if(letra == "a" ||
//    letra == "e" ||
//    letra == "i" ||
//    letra == "o" ||
//    letra == "u")
//    {
//     Console.WriteLine("Vogal");
//    }
//    else
//    {
//     Console.WriteLine("Não é uma vogal");
//    }



// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;

// }


// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada"); 
// }


// bool possuiPresencaMinima = true;
// double media = 5.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }

// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar!");
// }
// else
// {
//     Console.WriteLine("Vou pedalar um outro dia!");
// }

using System.Diagnostics.Contracts;
using ExemploFundamentos.Models;

// int numero = 5;

// for(int contador = 0; contador <= 100; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

//------------------------------------//

// int numero = 5;
// int contador = 1;


// while (contador <= 10)
// {
//     Console.WriteLine($"{contador}° Execução: {numero} X {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break; // Interrompe o loop quando contador é igual a 6
//     }

// }

//----------------------------------------//

// int soma =0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while (numero != 0);

// Console.WriteLine($"A soma dos números é: {soma}");


string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar clientes");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Busca de clientes");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar"); 
            exibirMenu = false;           
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

Console.WriteLine("O programa se encerrou");















//Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
//calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
//calc.RaizQuadrada(9);

// int numeroIncremento = 10;
// int numeroDecremento = 20;

// Console.WriteLine(numeroIncremento);

// Console.WriteLine("Incrementando o 10");
// //numero = numero + 1;
// numeroIncremento++;

// Console.WriteLine(numeroIncremento);

// Console.WriteLine("Decrementando o 20");
// //numero = numero + 1;
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);