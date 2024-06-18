Menu();

static void Menu(){
    Console.Clear();

    Console.WriteLine("Escolha uma operação de 1 a 4");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("0 - Sair");

    Console.WriteLine("============");
    Console.Write("Digite a opçção: ");
    short opcao = short.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 0: System.Environment.Exit(0); break;
        default: Menu(); break;
    }


}

static void LoopMenu(){
    Console.ReadKey();
    Menu();
}

static (double valor1, double valor2) DigitarValores(){
    Console.WriteLine("Primeiro valor: ");
    double valor1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    double valor2 = double.Parse(Console.ReadLine());

    Console.WriteLine("");

    return (valor1, valor2);
}

static void Soma(){
    
    var valores = DigitarValores();
    Console.WriteLine($"O resultado da soma é: {valores.valor1 + valores.valor2}");
    LoopMenu();
}

static void Subtracao(){

    var valores = DigitarValores();
    Console.WriteLine($"O resultado da subtração é: {valores.valor1 - valores.valor2}");
    LoopMenu();
}

static void Divisao(){

    var valores = DigitarValores();
    Console.WriteLine($"O resultado da divisão é: {valores.valor1 / valores.valor2}");
    LoopMenu();
}

static void Multiplicacao(){

    var valores = DigitarValores();
    Console.WriteLine($"O resultado da multiplicação é: {valores.valor1 * valores.valor2}");
    LoopMenu();
}


