
// crie um programa para calcularo imc de uma pessoa
// imc = peso / altura * altura

using ConceitosBasicos;

bool prossiga = true;
do
{
    try
    {
        Console.WriteLine("Informe o altura:");
        float altura = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe o peso:");
        float peso = float.Parse(Console.ReadLine());
        var calculadoraIMC = new CalculadoraIMC();
        
        Console.WriteLine(calculadoraIMC.Calcular(peso, altura));

        prossiga = false;

    }
    catch (FormatException e)
    {
        Console.WriteLine("Informe apenas numeros");
    }
    catch (DivideByZeroException e) { }

} while (prossiga);


