using System.Globalization;
using System.Text;

public class Program
{
    static void Main()
    {
        // Chamada de cada função criada abaixo
        ExecutarTarefa1();
        ExecutarTarefa2();
        ExecutarTarefa3();
        ExecutarTarefa4();
        ExecutarTarefa5();
        ExecutarTarefa6();

        Console.WriteLine("\n--- Todas as tarefas foram executadas! ---");
    }

    // 1° - Boas vindas personalizada
    static void ExecutarTarefa1()
    {
        Console.WriteLine("\n--- Tarefa 1 ---");
        Console.WriteLine("Qual o seu Nome?");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo(a)!");
    }

    // 2° - Concatenação de nome e sobrenome
    static void ExecutarTarefa2()
    {
        Console.WriteLine("\n--- Tarefa 2 ---");
        Console.WriteLine("Qual o seu Nome?");
        string name = Console.ReadLine();
        Console.WriteLine("Qual o seu Sobrenome?");
        string surname = Console.ReadLine();

        StringBuilder nameAndSurname = new StringBuilder();
        nameAndSurname.Append(name).Append(" ").Append(surname);

        Console.WriteLine($"Olá, {nameAndSurname}");
    }

    // 3° - Calculadora simples
    static void ExecutarTarefa3()
    {
        Console.WriteLine("\n--- Tarefa 3 ---");
        double valor1 = 10.5;
        double valor2 = 5.7;

        Console.WriteLine($"Valores: {valor1} e {valor2}");
        Console.WriteLine("Digite o sinal (+, -, *, / ou %):");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double resultado = op switch
        {
            '+' => valor1 + valor2,
            '-' => valor1 - valor2,
            '*' => valor1 * valor2,
            '/' => valor2 != 0 ? valor1 / valor2 : 0,
            '%' => valor2 != 0 ? valor1 % valor2 : 0,
            _ => 0
        };
        Console.WriteLine($"O resultado é: {resultado}");
    }

    // 4° - Contador de palavras
    static void ExecutarTarefa4()
    {
        Console.WriteLine("\n--- Tarefa 4 ---");
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();
        int totalPalavras = string.IsNullOrWhiteSpace(frase) ? 0 : frase.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        Console.WriteLine($"A frase tem {totalPalavras} palavras.");
    }

    // 5° - Validador de Placa
    static void ExecutarTarefa5()
    {
        Console.WriteLine("\n--- Tarefa 5 ---");
        string placa = "";
        bool placaValida = false;

        while (!placaValida)
        {
            Console.WriteLine("Digite a placa (7 caracteres - Ex: ABC1234):");
            placa = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(placa) && placa.Length == 7)
            {
                // Isola as partes
                string parteLetras = placa.Substring(0, 3);
                string parteNumeros = placa.Substring(3, 4);

                // Verifica se as partes são válidas
                bool letrasOk = parteLetras.All(char.IsLetter);
                bool numerosOk = parteNumeros.All(char.IsDigit);

                if (letrasOk && numerosOk)
                {
                    placaValida = true;
                    Console.WriteLine("Verdadeiro (Placa Válida)");
                }
                else
                {
                    Console.WriteLine("Falso (Placa Inválida). Tente novamente!");
                }
            }
            else
            {
                Console.WriteLine("Erro: A placa deve ter exatamente 7 caracteres.");
            }
        }
    }

    // 6° - Formatador de Datas
    static void ExecutarTarefa6()
    {
        Console.WriteLine("\n--- Tarefa 6 ---");
        DateTime agora = DateTime.Now;
        var cultura = new CultureInfo("pt-BR");

        Console.WriteLine($"1. Completo: {agora.ToString("dddd, dd/MM/yyyy HH:mm:ss", cultura)}");
        Console.WriteLine($"2. Data: {agora.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"3. Hora (24h): {agora.ToString("HH:mm:ss")}");
        Console.WriteLine($"4. Mês Extenso: {agora.ToString("dd 'de' MMMM 'de' yyyy", cultura)}");
    }
}