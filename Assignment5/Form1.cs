namespace Assignment5
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        int randomNumber = rnd.Next(0, 101);

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int enteredNumber;
            if (int.TryParse(textBox1.Text, out enteredNumber)) { }
            else
            {
                label4.Visible = true;
                label4.Text = "Enter valid type of data";
            }


            if (enteredNumber < randomNumber)
            {
                label3.Visible = true;
                label3.Text = "Too low, try again!";
                textBox1.Text = "";
            }
            else if (enteredNumber > randomNumber)
            {
                label3.Visible = true;
                label3.Text = "Too high, try again!";
                textBox1.Text = "";
            }
            else if (enteredNumber == randomNumber)
            {
                label3.Visible = true;
                label3.Text = "Congratulations! This is exact number!" + Environment.NewLine + "New random number is generated!";
                textBox1.Text = "";
                randomNumber = rnd.Next(0, 101);
            }
        }
    }
}