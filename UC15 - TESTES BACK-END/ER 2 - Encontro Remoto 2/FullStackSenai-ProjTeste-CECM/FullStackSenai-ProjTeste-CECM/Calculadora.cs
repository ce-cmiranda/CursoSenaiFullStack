namespace FullStackSenai_ProjTeste_CECM
{
    public class Calculadora
    {
        public static double Somar(double pNum, double sNum)
        {
            return (pNum + sNum);
        }

        public static double CalculoImc(double kg, double altura)
        {
            double resultado = Math.Truncate(100 * kg / (altura * altura)) / 100;
            return resultado;
        }
        public static string CalculadoraImc(double kg, double altura)
        {
            double resultado = CalculoImc(kg, altura);

            if (resultado < 18.5)
            {
                return "Abaixo do Peso";
            }

            if (resultado < 24.9)
            {
                return "Peso Normal";
            }

            if (resultado < 29.9)
            {
                return "Sobrepeso";
            }
            if (resultado < 34.9)
            {
                return "Obesidade I";
            }
            if (resultado < 39.9)
            {
                return "Obesidade II";
            }
            else
            {
                return "Obesidade III";
            }

        }
    }
}