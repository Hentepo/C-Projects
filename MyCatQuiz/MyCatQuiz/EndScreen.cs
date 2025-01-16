using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyCatQuiz
{
    public partial class EndScreen : Form
    {

        public EndScreen()
        {
            InitializeComponent();

            ResultLabel.Text = $"{Program.userName} sait {Program.correctAnswerCount} pistettä!";
            Utility.PrintMessage("Your score is " + Convert.ToString(Database.correctAnswerCount), true);
            File.AppendAllText(Program.filePath, $"\n + {Program.userName} + Program.correctAnswerCount + points");
        }
        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxEnd_Click(object sender, EventArgs e)
        {
            Program.list.Clear();
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void ResultTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
