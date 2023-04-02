using FullStackSenai_ProjTeste_CECM;

namespace TesteXUnit
{
    public class TesteCalcXUnit
    {
        [Fact]
        public void TestMethod1()
        {
            //3A (Arrange, Act, Assert)
            //Preparação

            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Açao
            var resultado = Calculadora.Somar(pNum, sNum);

            //Verificações
            Assert.Equal(rNum, resultado);
        }
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(1, 2, 3)]
        [InlineData(1, 3, 4)]
        [InlineData(7, 1, 8)]


        public void TestSomaDoisNum(double pNum, double sNum, double rNum)
        {
            //Preparação

            //Açao
            var resultado = Calculadora.Somar(pNum, sNum);

            //Verificações
            Assert.Equal (rNum, resultado);

        }

        [Theory]
        [InlineData(40, 1.49, 18.01, "Abaixo do Peso")]
        [InlineData(50, 1.45, 23.78, "Peso Normal")]
        [InlineData(69, 1.64, 25.65, "Sobrepeso")]
        [InlineData(89, 1.72, 30.08, "Obesidade I")]
        [InlineData(99, 1.68, 35.07, "Obesidade II")]
        [InlineData(122, 1.74, 40.29, "Obesidade III")]

        public void TesteCalculoImc(double kg, double altura, double resultado, string classificacao)
        {
            //Preparação

            //Açao
            var resultadoImc = Calculadora.CalculoImc(kg, altura);
            var classificacaoImc = Calculadora.CalculadoraImc(kg, altura);

            //Verificações
            Assert.Equal(resultado, resultadoImc);
            Assert.Equal(classificacao, classificacaoImc);

        }
    }
}