

using Conceptos_POO;

Console.WriteLine("POO CONCEPTOS");
Console.WriteLine("===============");

try
{
	Console.WriteLine(new Date(2024, 2, 29));
	Console.WriteLine(new Date(2022, 8, 9));
	Console.WriteLine(new Date(2022, 11, 30));
}
catch (Exception error)
{

	Console.WriteLine(error.Message);
}
