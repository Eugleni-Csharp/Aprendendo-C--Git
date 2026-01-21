
Console.Clear();


try
{
    Menu();
}
catch (FormatException ex)
{
    // Tratamento de Exception 'char'
    // // Unhandled exception. System.FormatException: String must be exactly one character long. at System.Convert.ToChar(String value, IFormatProvider provider)
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
    Console.WriteLine("Encerrando o programa...");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
    Console.WriteLine("Ocorreu um erro inesperado. Encerrando o programa...");
}

static void Menu()
{
    Console.Clear();

    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("0 - Sair");
    Console.Write("Opção: ");
    char opcao = Convert.ToChar(Console.ReadLine() ?? "0");

    switch (opcao)
    {
        case '1':
            Soma();
            break;

        case '2':
            Subtracao();
            break;

        case '3':
            Multiplicacao();
            break;

        case '0':
            Console.WriteLine("Saindo...");
            Thread.Sleep(1000);
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Opção inválida!");
            Menu();
            break;

    }
}

static void Soma()
{
    Console.Clear();

    Console.Write("Digite um número: ");
    var num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite outro número: ");
    var num2 = Convert.ToDouble(Console.ReadLine());

    var resultado = num1 + num2;
    Console.WriteLine($"O resultado da soma é: {resultado}");
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
    Console.ReadKey();
    // Thread.Sleep(1000);
    Menu();
}


static void Subtracao()
{
    Console.Clear();

    Console.Write("Digite um número: ");
    var num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite outro número: ");
    var num2 = Convert.ToDouble(Console.ReadLine());

    var resultado = num1 - num2;
    Console.WriteLine($"O resultado da subtração é: {resultado}");
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Menu();
}


static void Multiplicacao()
{
    Console.Clear();

    Console.Write("Digite um número: ");
    var num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite outro número: ");
    var num2 = Convert.ToDouble(Console.ReadLine());

    var resultado = num1 * num2;
    Console.WriteLine($"O resultado da multiplicação é: {resultado}");
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Menu();
}




