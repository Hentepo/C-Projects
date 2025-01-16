using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyCatQuiz
{
    public partial class StartScreen : Form
    {

        public StartScreen()
        {
            InitializeComponent();

            StartLabel.Text = "Anna nimimerkki";


        }
        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxOk_Click(object sender, EventArgs e)
        {
            Program.userName = UserInputBox.Text;
            this.Close();
            Question1 question1 = new Question1();
            question1.Show();
        }

        private void ResultTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
