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


// string opcao;
// bool exibirMenu = true;

// while (exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar clientes");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case "2":
//             Console.WriteLine("Busca de clientes");
//             break;
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar"); 
//             exibirMenu = false;           
//             break;
//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }
// }

// Console.WriteLine("O programa se encerrou");



//-- Exemplo com lista --//

// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");
// listaString.Add("RJ");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("SC");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Remove("MG");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// Console.WriteLine("Percorrendo o lista com o for");
// for (int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição N° {contador}: {listaString[contador]}");
// }

// Console.WriteLine("Percorrendo o lista com o foreach");
// int contadorForeach = 0;
// foreach (string item in listaString)
// {
//     Console.WriteLine($"Posição N° {contadorForeach}: {item}");
//     contadorForeach++;
// }


//--- Exemplos com Array --//

// int[] arrayInteiro = new int[4];

// arrayInteiro[0] = 72;
// arrayInteiro[1] = 64;
// arrayInteiro[2] = 50;
// arrayInteiro[3] = 1; //vai dar erro pois o array foi definido com 3 posições

// int[] arrayInteiroDobrado = new int[arrayInteiro.Length * 2];
// Array.Copy(arrayInteiro, arrayInteiroDobrado, arrayInteiro.Length);

// // Array.Resize(ref arrayInteiro, arrayInteiro.Length * 2);


// Console.WriteLine("Percorrendo o array com for");
// for (int contador = 0; contador < arrayInteiro.Length; contador++)
// {
//     Console.WriteLine($"Valor da posição {contador}: {arrayInteiro[contador]}");
// }


// Console.WriteLine("Percorrendo o array com foreach");

// int contadorForeach = 0;
// foreach (int valor in arrayInteiro)
// {
//     Console.WriteLine($"Valor da posição {contadorForeach}: {valor}");
//     contadorForeach++;
// }




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


// --Exemplos de comentários --//

using ExemploFundamentos.Common.Models;


    // Instancia da classe Pessoa
    Pessoa p = new Pessoa();

    /*
        Atribui o nome idade para pessoa
        passando o nome Hélio
        e passando a idade 46
    */
    p.Nome = "Hélio";
p.Idade = 46;

//Faz a pessoa se apresentar
p.Apresentar();
