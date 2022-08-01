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
            Display.Text = result.ToString();
            string calcresult = string.Join(" ", numbers);
            History.AppendText(calcresult + "\n");
            History.AppendText($"Result: {Display.Text}\n");
        }
    }
}