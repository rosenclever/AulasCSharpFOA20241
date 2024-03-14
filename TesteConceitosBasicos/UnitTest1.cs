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

            //ação
            float imc  = calculadora.Calcular(peso, altura);
            //separar os métodos calcular imc e obter status na classe CalcularIMC
            //assistir ao vídeo sobre príncípios solid do Felipe Deschamps
            //verificação
            Assert.AreEqual(25, imc);
        }
        [TestMethod]
        public void ObterClassificacaoComIMCTest() 
        {
            //cenario
            float imc = 25;
            string status;
            CalculadoraIMC calculadoraIMC = new CalculadoraIMC();
            //ação
            status = calculadoraIMC.ObterClassificacao(imc);
            //verificação
            Assert.AreEqual("sobrepeso", status);
        }
        [TestMethod]
        public void ObterClassificacaoComPesoEAlturaTest()
        {
            //cenario
            float peso = 100;
            float altura = 2;
            string status;
            CalculadoraIMC calculadoraIMC = new CalculadoraIMC();
            //ação
            status = calculadoraIMC.ObterClassificacao(peso, altura);
            //verificação
            Assert.AreEqual("sobrepeso", status);
        }
    }
}