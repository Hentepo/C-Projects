namespace MyCatQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Question1 question1 = new Question1();
            question1.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}