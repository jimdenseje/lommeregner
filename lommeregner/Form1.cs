namespace lommeregner
{
    public partial class Main : Form
    {
        List<string> enteries = new List<string>();
        public Main()
        {
            InitializeComponent();
        }

        private void Num_9_Click(object sender, EventArgs e)
        {
            enteries.Add("9");
            Display.Text = Display.Text + "9";
        }

        private void Num_8_Click(object sender, EventArgs e)
        {
            enteries.Add("8");
            Display.Text = Display.Text + "8";
        }

        private void Num_7_Click(object sender, EventArgs e)
        {
            enteries.Add("7");
            Display.Text = Display.Text + "7";
        }

        private void Num_6_Click(object sender, EventArgs e)
        {
            enteries.Add("6");
            Display.Text = Display.Text + "6";
        }

        private void Num_5_Click(object sender, EventArgs e)
        {
            enteries.Add("5");
            Display.Text = Display.Text + "5";
        }

        private void Num_4_Click(object sender, EventArgs e)
        {
            enteries.Add("4");
            Display.Text = Display.Text + "4";
        }

        private void Num_3_Click(object sender, EventArgs e)
        {
            enteries.Add("3");
            Display.Text = Display.Text + "3";
        }

        private void Num_2_Click(object sender, EventArgs e)
        {
            enteries.Add("2");
            Display.Text = Display.Text + "2";
        }

        private void Num_1_Click(object sender, EventArgs e)
        {
            enteries.Add("1");
            Display.Text = Display.Text + "1";
        }

        private void Num_0_Click(object sender, EventArgs e)
        {
            enteries.Add("0");
            Display.Text = Display.Text + "0";
        }

        private void Num_Decimal_Click(object sender, EventArgs e)
        {
            enteries.Add(".");
            Display.Text = Display.Text + ".";
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Display.Text.Length > 0)
            {
                Display.Text = Display.Text.Remove(Display.Text.Length - 1);
            }
            else
            {
                Display.Text = "";
                enteries.Clear();
            }
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            enteries.Add("/");
            Display.Text = Display.Text + " / ";
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            enteries.Add("*");
            Display.Text = Display.Text + " * ";
        }

        private void SubtractBtn_Click(object sender, EventArgs e)
        {
            enteries.Add("-");
            Display.Text = Display.Text + " - ";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            enteries.Add("+");
            Display.Text = Display.Text + " + ";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            //Make calculator from display text
            string[] numbers = Display.Text.Split(' ');
            double result = double.Parse(numbers[0].Replace('.',','));
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == "+")
                {
                    result += double.Parse(numbers[i + 1].Replace('.',','));
                }
                else if (numbers[i] == "-")
                {
                    result -= double.Parse(numbers[i + 1].Replace('.', ','));
                }
                else if (numbers[i] == "*")
                {
                    result *= double.Parse(numbers[i + 1].Replace('.', ','));
                }
                else if (numbers[i] == "/")
                {
                    result /= double.Parse(numbers[i + 1].Replace('.', ','));
                }
            }
            if (Display.Text != result.ToString()) {
                string calcresult = string.Join(" ", numbers);
                History.AppendText(calcresult + "\n");
                History.AppendText($"Result: {Display.Text}\n");
            }
            Display.Text = result.ToString();
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = false;

            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                Num_0.PerformClick();
            }
            else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1) {

                Num_1.PerformClick();
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {

                Num_2.PerformClick();
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {

                Num_3.PerformClick();
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {

                Num_3.PerformClick();
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {

                Num_4.PerformClick();
            }
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {

                Num_5.PerformClick();
            }
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {

                Num_6.PerformClick();
            }
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {

                Num_7.PerformClick();
            }
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8) {
                Num_8.PerformClick();
            }
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                Num_9.PerformClick();
            }
            else if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                DeleteBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Divide)
            {
                DivideBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                MultiplyBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                SubtractBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Add)
            {
                AddBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
            {
                Num_Decimal.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                EqualBtn.PerformClick();
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Display_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = false;

            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                Num_0.PerformClick();
            }
            else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {

                Num_1.PerformClick();
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {

                Num_2.PerformClick();
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {

                Num_3.PerformClick();
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {

                Num_3.PerformClick();
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {

                Num_4.PerformClick();
            }
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {

                Num_5.PerformClick();
            }
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {

                Num_6.PerformClick();
            }
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {

                Num_7.PerformClick();
            }
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                Num_8.PerformClick();
            }
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                Num_9.PerformClick();
            }
            else if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                DeleteBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Divide)
            {
                DivideBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                MultiplyBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                SubtractBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Add)
            {
                AddBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
            {
                Num_Decimal.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                EqualBtn.PerformClick();
            }
            else
            {
                e.Handled = true;
            }
        }

        private void History_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = false;

            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                Num_0.PerformClick();
            }
            else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {

                Num_1.PerformClick();
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {

                Num_2.PerformClick();
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {

                Num_3.PerformClick();
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {

                Num_3.PerformClick();
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {

                Num_4.PerformClick();
            }
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {

                Num_5.PerformClick();
            }
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {

                Num_6.PerformClick();
            }
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {

                Num_7.PerformClick();
            }
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                Num_8.PerformClick();
            }
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                Num_9.PerformClick();
            }
            else if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                DeleteBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Divide)
            {
                DivideBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                MultiplyBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                SubtractBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Add)
            {
                AddBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
            {
                Num_Decimal.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                EqualBtn.PerformClick();
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}