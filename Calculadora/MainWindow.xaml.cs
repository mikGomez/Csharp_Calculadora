using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculadora
{
    public partial class MainWindow : Window
    {
        public string operador = "";
        public double numero1 = 0;
        public bool numeroControlado = true;


        public static double Calculate(double numero1, double numero2, string operador)
        {
            switch (operador)
            {
                case "+":
                    return numero1 + numero2;
                case "-":
                    return numero1 - numero2;
                case "*":
                    return numero1 * numero2;
                case "/":
                    if (numero2 != 0)
                    {
                        return numero1 / numero2;
                    }
                    else
                    {
                        throw new ArgumentException("No se puede dividir por 0");
                    }
                default:
                    throw new ArgumentException("Operador no válido");
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string btnText = btn.Content.ToString();

            if (numeroControlado)
            {
                InputBox.Text = btnText;
                numeroControlado = false;
            }
            else
            {
                InputBox.Text += btnText;
            }
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string btnText = btn.Content.ToString();

            if (!string.IsNullOrEmpty(operador))
            {
                calcular();
            }

            operador = btnText;
            numero1 = double.Parse(InputBox.Text);
            numeroControlado = true;
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            calcular();
            operador = "";
        }

        public void calcular()
        {
            if (!string.IsNullOrEmpty(operador))
            {
                double numero2 = double.Parse(InputBox.Text);
                double resultado = 0;
                Calculate(numero1,numero2,operador);
                InputBox.Text = resultado.ToString();
                numeroControlado = true;
                operador = "";
            }
        }

        private void Decimal_Click(object sender, RoutedEventArgs e)
        {
            if (!InputBox.Text.Contains("."))
            {
                InputBox.Text += ".";
            }
        }

        private void reset()
        {
            operador = "";
            numero1 = 0;
            numeroControlado = true;
            InputBox.Text = "";
        }
    }
}