using CalculatorTDD;

namespace CalculatorGUI
{
    public partial class Form1 : Form
    {
        private Calculator calculator = new Calculator();

        public Form1()
        {
            InitializeComponent();

            // Dodaj obs³ugê zdarzeñ
            btnAdd.Click += BtnAdd_Click;
            btnSubstract.Click += BtnSubstract_Click;
            btnMultiply.Click += BtnMultiply_Click;
            btnDivide.Click += BtnDivide_Click;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Oblicz((a, b) => calculator.Add(a, b));
        }

        private void BtnSubstract_Click(object sender, EventArgs e)
        {
            Oblicz((a, b) => calculator.Subtract(a, b));
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            Oblicz((a, b) => calculator.Multiply(a, b));
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            Oblicz((a, b) => calculator.Divide(a, b));
        }

        private void Oblicz(Func<double, double, double> dzialanie)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double wynik = dzialanie(a, b);
                txtResult.Text = wynik.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("WprowadŸ poprawne liczby!");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Nie mo¿na dzieliæ przez zero!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

