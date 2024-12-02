namespace CSCI234_LukeDuell_Assignment14_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //resetting the values
            label3.Text = "";
            this.BackColor = System.Drawing.Color.White;




            Random randomint = new Random();
            int randomnumber = randomint.Next(0, 1000);
            int maskedvalue = int.Parse(maskedTextBox1.Text);

            if (maskedvalue == randomnumber)
            {
                this.BackColor = System.Drawing.Color.Green;
                label3.Text = "CORRECT!";
            }
            else if (maskedvalue < randomnumber)
            {
                label3.Text = "Too Low!";
            }
            else if (maskedvalue > randomnumber)
            {
                label3.Text = "Too High!";
            }
        }
    }
}