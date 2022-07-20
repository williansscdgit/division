//Divisao
using division.classes;

Console.Write("Digite a quantidade de divisões: ");
int limit = int.Parse(Console.ReadLine());

for (int i = 0; i < limit; i++)
{
    Console.Write("Digite os dois valores separados por vírgula: ");

    string[] line = Console.ReadLine().Split(",");
    double x = double.Parse(line[0]);
    double y = double.Parse(line[1]);
    
    if (y != 0)
    {
        double resultado = x / y;
        Console.WriteLine("Resultado: {0:0.0}", resultado);
    }
    else
    {
        Console.WriteLine("impossivel de realizar a operacao");
    }
}

Console.ReadKey();