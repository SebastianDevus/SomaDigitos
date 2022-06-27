List<int> numeros = new List<int>();
int numeroDigitado;
int contador = 0;

Console.Clear();

Console.Write("Escreva um número: ");
numeroDigitado = Convert.ToInt32(Console.ReadLine());

Console.Write("Dígitos: ");

do
{
numeros.Add(numeroDigitado % 10);
numeroDigitado /= 10;

Console.Write($"{numeros.ElementAt(contador)} ");
contador++;
} while (numeroDigitado != 0);

Console.WriteLine($"\n\nSoma: {numeros.Sum()}\n");