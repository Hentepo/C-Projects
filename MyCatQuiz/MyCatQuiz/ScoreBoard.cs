using System.Collections.Generic;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyCatQuiz
{
    public partial class ScoreBoard : Form
    {

        public ScoreBoard()
        {
            InitializeComponent();

            string[] lines = File.ReadAllLines(Program.filePath);

            foreach (var line in lines)
            {
                if (line.EndsWith("10 points"))
                {
                    ScoreLabel.Text += line + Environment.NewLine;
                }
            }

            foreach (var line in lines)
            {
                if (line.EndsWith("9 points"))
                {
                    ScoreLabel.Text += line + Environment.NewLine;
                }
            }

            foreach (var line in lines)
            {
                if (line.EndsWith("8 points"))
                {
                    ScoreLabel.Text += line + Environment.NewLine;
                }
            }

            foreach (var line in lines)
            {
                if (line.EndsWith("7 points"))
                {
                    ScoreLabel.Text += line + Environment.NewLine;
                }
            }

            foreach (var line in lines)
            {
                if (line.EndsWith("6 points"))
                {
                    ScoreLabel.Text += line + Environment.NewLine;
                }
            }

            foreach (var line in lines)
            {
                if (line.EndsWith("5 points"))
                {
                    ScoreLabel.Text += line + Environment.NewLine;
                }
            }

            foreach (var line in lines)
            {
                if (line.EndsWith("4 points"))
                {
                    ScoreLabel.Text += line + Environment.NewLine;
                }
            }

            foreach (var line in lines)
            {
                if (line.EndsWith("3 points"))
                {
                    ScoreLabel.Text += line + Environment.NewLine;
                }
            }

            foreach (var line in lines)
            {
                if (line.EndsWith("2 points"))
                {
                    ScoreLabel.Text += line + Environment.NewLine;
                }
            }

            foreach (var line in lines)
            {
                if (line.EndsWith("1 points"))
                {
                    ScoreLabel.Text += line + Environment.NewLine;
                }
            }

            foreach (var line in lines)
            {
                if (line.EndsWith("0 points"))
                {
                    ScoreLabel.Text += line + Environment.NewLine;
                }
            }

        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void ResultTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
