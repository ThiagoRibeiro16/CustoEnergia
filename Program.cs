Console.Clear();

double consumo, horasUso, custo, custoEstimado;

Console.Write("Consumo do aparelho: ");
consumo = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Horas de uso por dia: ");
horasUso = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Custo da energia: ");
custo = Convert.ToDouble(Console.ReadLine()!);

custoEstimado = (consumo * horasUso) * custo;

Console.WriteLine($"Custo estimado: {custoEstimado:N2}");