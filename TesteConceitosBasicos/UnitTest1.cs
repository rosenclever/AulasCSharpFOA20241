using ConceitosBasicos;
using System.Runtime.InteropServices;

namespace TesteConceitosBasicos
{
    [TestClass]
    public class CalculadoraIMCTeste
    {
        [TestMethod]
        public void CalcularTeste()
        {
            //cenario
            float peso = 100f;
            float altura = 2f;
            CalculadoraIMC calculadora = new CalculadoraIMC();

            //a��o
            float imc  = calculadora.Calcular(peso, altura);
            //separar os m�todos calcular imc e obter status na classe CalcularIMC
            //assistir ao v�deo sobre pr�nc�pios solid do Felipe Deschamps
            //verifica��o
            Assert.AreEqual(25, imc);
        }
        [TestMethod]
        public void ObterClassificacaoTest() 
        {
            //cenario
            float imc = 25;
            string status;
            CalculadoraIMC calculadoraIMC = new CalculadoraIMC();
            //a��o
            status = calculadoraIMC.ObterClassificacao(imc);
            //verifica��o
            Assert.AreEqual("sobrepeso", status);
        }
    }
}