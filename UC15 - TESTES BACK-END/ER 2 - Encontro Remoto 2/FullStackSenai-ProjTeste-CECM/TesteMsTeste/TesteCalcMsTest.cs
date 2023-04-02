using FullStackSenai_ProjTeste_CECM;
using System.Data;

namespace TesteMsTeste
{
    [TestClass]
    public class TesteCalcMsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //3A (Arrange, Act, Assert)
            //Prepara��o

            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //A�ao
            var resultado = Calculadora.Somar(pNum, sNum);

            //Verifica��es
            Assert.AreEqual(rNum, resultado);
        }

        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 5, 7)]
        [DataRow(3, 5, 8)]
        public void TestSomaDoisNum(double pNum, double sNum, double rNum) {
            //Prepara��o

            //A�ao
            var resultado = Calculadora.Somar(pNum, sNum);

            //Verifica��es
            Assert.AreEqual(rNum, resultado);

        }

        [TestMethod]
        [DataRow(40, 1.49, 18.01, "Abaixo do Peso")]
        [DataRow(50, 1.45, 23.78, "Peso Normal")]
        [DataRow(69, 1.64, 25.65, "Sobrepeso")]
        [DataRow(89, 1.72, 30.08, "Obesidade I")]
        [DataRow(99, 1.68, 35.07, "Obesidade II")]
        [DataRow(122, 1.74, 40.29, "Obesidade III")]


        public void TesteCalculoImc(double kg, double altura, double resultado, string classificacao)
        {
            //Prepara��o

            //A�ao
            var resultadoImc = Calculadora.CalculoImc(kg, altura);
            var classificacaoImc = Calculadora.CalculadoraImc(kg, altura);

            //Verifica��es
            Assert.AreEqual(resultado, resultadoImc);
            Assert.AreEqual(classificacao, classificacaoImc);

        }
    }
}