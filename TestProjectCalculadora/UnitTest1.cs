using Calculadora;

namespace TestProjectCalculadora
{
    public class CalculatorTests
    {
        [Fact]
        public void SumaDosNumeros()
        {
            double num1 = 5;
            double num2 = 5;
            double resultado;
            resultado = MainWindow.Calculate(num1,num2,"+");

            Assert.Equal(10,resultado);
        }

        [Fact]
        public void RestaDosNumeros()
        {
            double num1 = 5;
            double num2 = 5;
            double resultado;
            resultado = MainWindow.Calculate(num1, num2, "-");

            Assert.Equal(0, resultado);
        }
        [Fact]
        public void MultiDosNumeros()
        {
            double num1 = 5;
            double num2 = 5;
            double resultado;
            resultado = MainWindow.Calculate(num1, num2, "*");

            Assert.Equal(25, resultado);
        }
        [Fact]
        public void DivDosNumeros()
        {
            double num1 = 5;
            double num2 = 5;
            double resultado;
            resultado = MainWindow.Calculate(num1, num2, "/");

            Assert.Equal(1, resultado);
        }

    }

}