// importacao de bibliotecas


// nome da classe

// declaracao de métodos


// declaracao de variáveis
int op = 0;
int num1, num2;
double res=0;

// entradas
Console.WriteLine("Escolha uma operação: \n\n" +
    "1- Soma\n 2- Substração\n 3- Multiplicação\n 4-Divisão\n 5-Sair\n\n"+
    "Digite a opção escolhida: ");
op=int.Parse(Console.ReadLine());

// processamento
switch (op)
{
    case 1:
        Console.WriteLine("Operação somar.");
        Console.Write("Digite o numero 1: ");
        num1=int.Parse(Console.ReadLine());
        Console.Write("Digite o numero 2: ");
        num2 = int.Parse(Console.ReadLine());
        res = num1 + num2;
        break;
    case 2:
        Console.WriteLine("Operação substrair.");
        Console.Write("Digite o numero 1: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o numero 2: ");
        num2 = int.Parse(Console.ReadLine());
        res = num1 - num2;
        break;
    case 3:
        Console.WriteLine("Operação multiplicar.");
        Console.Write("Digite o numero 1: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o numero 2: ");
        num2 = int.Parse(Console.ReadLine());
        res = num1 * num2;
        break; 
    case 4:
        Console.WriteLine("Operação dividir.");
        Console.Write("Digite o numero 1: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o numero 2: ");
        num2 = int.Parse(Console.ReadLine());
        res = 1.0*num1 / num2;
        break;
    case 5:
        Console.WriteLine("Saindo do sistema.");
        break;
}

Console.WriteLine("O resultado é: " + res);
    // saidas


