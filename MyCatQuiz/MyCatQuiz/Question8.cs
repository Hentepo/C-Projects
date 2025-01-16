using System.Collections.Generic;

namespace MyCatQuiz
{
    public partial class Question8 : Form
    {

        public Question8()
        {
            InitializeComponent();

            Program.rndnum = Program.generateUniqueNumber();

            if (Program.rndnum == 1) 
            {
                QuestionTextBox.Text = AppScreen.Question1();
                TextBoxa.Text = AppScreen.Question1a();
                TextBoxb.Text = AppScreen.Question1b();
                TextBoxc.Text = AppScreen.Question1c();
                TextBoxd.Text = AppScreen.Question1d();

            }
            else if (Program.rndnum == 2)
            {
                QuestionTextBox.Text = AppScreen.Question2();
                TextBoxa.Text = AppScreen.Question2a();
                TextBoxb.Text = AppScreen.Question2b();
                TextBoxc.Text = AppScreen.Question2c();
                TextBoxd.Text = AppScreen.Question2d();
            }
            else if (Program.rndnum == 3)
            {
                QuestionTextBox.Text = AppScreen.Question3();
                TextBoxa.Text = AppScreen.Question3a();
                TextBoxb.Text = AppScreen.Question3b();
                TextBoxc.Text = AppScreen.Question3c();
                TextBoxd.Text = AppScreen.Question3d();
            }
            else if (Program.rndnum == 4)
            {
                QuestionTextBox.Text = AppScreen.Question4();
                TextBoxa.Text = AppScreen.Question4a();
                TextBoxb.Text = AppScreen.Question4b();
                TextBoxc.Text = AppScreen.Question4c();
                TextBoxd.Text = AppScreen.Question4d();
            }
            else if (Program.rndnum == 5)
            {
                QuestionTextBox.Text = AppScreen.Question5();
                TextBoxa.Text = AppScreen.Question5a();
                TextBoxb.Text = AppScreen.Question5b();
                TextBoxc.Text = AppScreen.Question5c();
                TextBoxd.Text = AppScreen.Question5d();
            }
            else if (Program.rndnum == 6)
            {
                QuestionTextBox.Text = AppScreen.Question6();
                TextBoxa.Text = AppScreen.Question6a();
                TextBoxb.Text = AppScreen.Question6b();
                TextBoxc.Text = AppScreen.Question6c();
                TextBoxd.Text = AppScreen.Question6d();
            }
            else if (Program.rndnum == 7)
            {
                QuestionTextBox.Text = AppScreen.Question7();
                TextBoxa.Text = AppScreen.Question7a();
                TextBoxb.Text = AppScreen.Question7b();
                TextBoxc.Text = AppScreen.Question7c();
                TextBoxd.Text = AppScreen.Question7d();
            }
            else if (Program.rndnum == 8)
            {
                QuestionTextBox.Text = AppScreen.Question8();
                TextBoxa.Text = AppScreen.Question8a();
                TextBoxb.Text = AppScreen.Question8b();
                TextBoxc.Text = AppScreen.Question8c();
                TextBoxd.Text = AppScreen.Question8d();
            }
            else if (Program.rndnum == 9)
            {
                QuestionTextBox.Text = AppScreen.Question9();
                TextBoxa.Text = AppScreen.Question9a();
                TextBoxb.Text = AppScreen.Question9b();
                TextBoxc.Text = AppScreen.Question9c();
                TextBoxd.Text = AppScreen.Question9d();
            }
            else if (Program.rndnum == 10)
            {
                QuestionTextBox.Text = AppScreen.Question10();
                TextBoxa.Text = AppScreen.Question10a();
                TextBoxb.Text = AppScreen.Question10b();
                TextBoxc.Text = AppScreen.Question10c();
                TextBoxd.Text = AppScreen.Question10d();
            }
        }
        private void Form9_Load(object sender, EventArgs e)
        {
            
        }

        private async void TextBoxa_Click(object sender, EventArgs e)
        {
            if (Program.rndnum == 1)
            {              
                TextBoxa.BackColor = Color.Red;
            }
            else if (Program.rndnum == 2)
            {
                TextBoxa.BackColor = Color.Red;
            }
            else if (Program.rndnum == 3)
            {
                TextBoxa.BackColor = Color.Red;
            }
            else if (Program.rndnum == 4)
            {
                TextBoxa.BackColor = Color.Red;
            }
            else if (Program.rndnum == 5)
            {
                TextBoxa.BackColor = Color.Red;
            }
            else if (Program.rndnum == 6)
            {
                TextBoxa.BackColor = Color.Red;
            }
            else if (Program.rndnum == 7)
            {
                TextBoxa.BackColor = Color.Red;
            }
            else if (Program.rndnum == 8)
            {
                TextBoxa.BackColor = Color.Red;
            }
            else if (Program.rndnum == 9)
            {
                TextBoxa.BackColor = Color.Red;
            }
            else if (Program.rndnum == 10)
            {
                TextBoxa.BackColor = Color.Red;
            }

            await Task.Delay(1000);
            this.Close();
            Question9 question9 = new Question9();
            question9.Show();

        }

        private async void TextBoxb_Click(object sender, EventArgs e)
        {
            if (Program.rndnum == 1)
            {
                TextBoxb.BackColor = Color.Red;
            }
            else if (Program.rndnum == 2)
            {
                TextBoxb.BackColor = Color.Red;
            }
            else if (Program.rndnum == 3)
            {
                TextBoxb.BackColor = Color.Green;
                Program.correctAnswerCount++;
            }
            else if (Program.rndnum == 4)
            {
                TextBoxb.BackColor = Color.Green;
                Program.correctAnswerCount++;
            }
            else if (Program.rndnum == 5)
            {
                TextBoxb.BackColor = Color.Green;
                Program.correctAnswerCount++;
            }
            else if (Program.rndnum == 6)
            {
                TextBoxb.BackColor = Color.Green;
                Program.correctAnswerCount++;
            }
            else if (Program.rndnum == 7)
            {
                TextBoxb.BackColor = Color.Red;
            }
            else if (Program.rndnum == 8)
            {
                TextBoxb.BackColor = Color.Green;
                Program.correctAnswerCount++;
            }
            else if (Program.rndnum == 9)
            {
                TextBoxb.BackColor = Color.Red;
            }
            else if (Program.rndnum == 10)
            {
                TextBoxb.BackColor = Color.Green;
                Program.correctAnswerCount++;
            }
            await Task.Delay(1000);
            this.Close();
            Question9 question9 = new Question9();
            question9.Show();
        }
        private async void TextBoxc_Click(object sender, EventArgs e)
        {
            if (Program.rndnum == 1)
            {
                TextBoxc.BackColor = Color.Green;
                Program.correctAnswerCount++;
            }
            else if (Program.rndnum == 2)
            {
                TextBoxc.BackColor = Color.Red;
            }
            else if (Program.rndnum == 3)
            {
                TextBoxc.BackColor = Color.Red;
            }
            else if (Program.rndnum == 4)
            {
                TextBoxc.BackColor = Color.Red;
            }
            else if (Program.rndnum == 5)
            {
                TextBoxc.BackColor = Color.Red;
            }
            else if (Program.rndnum == 6)
            {
                TextBoxc.BackColor = Color.Red;
            }
            else if (Program.rndnum == 7)
            {
                TextBoxc.BackColor = Color.Green;
                Program.correctAnswerCount++;
            }
            else if (Program.rndnum == 8)
            {
                TextBoxc.BackColor = Color.Red;
            }
            else if (Program.rndnum == 9)
            {
                TextBoxc.BackColor = Color.Green;
                Program.correctAnswerCount++;
            }
            else if (Program.rndnum == 10)
            {
                TextBoxc.BackColor = Color.Red;
            }
            await Task.Delay(1000);
            this.Close();
            Question9 question9 = new Question9();
            question9.Show();
        }
        private async void TextBoxd_Click(object sender, EventArgs e)
        {
            if (Program.rndnum == 1)
            {
                TextBoxd.BackColor = Color.Red;
            }
            else if (Program.rndnum == 2)
            {
                TextBoxd.BackColor = Color.Green;
                Program.correctAnswerCount++;
            }
            else if (Program.rndnum == 3)
            {
                TextBoxd.BackColor = Color.Red;
            }
            else if (Program.rndnum == 4)
            {
                TextBoxd.BackColor = Color.Red;
            }
            else if (Program.rndnum == 5)
            {
                TextBoxd.BackColor = Color.Red;
            }
            else if (Program.rndnum == 6)
            {
                TextBoxd.BackColor = Color.Red;
            }
            else if (Program.rndnum == 7)
            {
                TextBoxd.BackColor = Color.Red;
            }
            else if (Program.rndnum == 8)
            {
                TextBoxd.BackColor = Color.Red;
            }
            else if (Program.rndnum == 9)
            {
                TextBoxd.BackColor = Color.Red;
            }
            else if (Program.rndnum == 10)
            {
                TextBoxd.BackColor = Color.Red;
            }
            await Task.Delay(1000);
            this.Close();
            Question9 question9 = new Question9();
            question9.Show();
        }

    }
}
