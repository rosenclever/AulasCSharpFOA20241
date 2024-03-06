
// crie um programa para calcularo imc de uma pessoa
// imc = peso / altura * altura
bool prossiga = true;
do
{
    try
    {
        Console.WriteLine("Informe o altura:");
        float altura = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe o peso:");
        float peso = float.Parse(Console.ReadLine());
        float imc = peso / (altura * altura);
        Console.WriteLine($"O imc calculado foi {imc:f1}");
        prossiga = false;

    }
    catch (FormatException e)
    {
        Console.WriteLine("Informe apenas numeros");
    }
    catch(DivideByZeroException e) { }while (prossiga);


