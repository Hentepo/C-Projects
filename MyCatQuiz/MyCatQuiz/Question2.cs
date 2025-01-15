using System.Collections.Generic;

namespace MyCatQuiz
{
    public partial class Question2 : Form
    {

        internal static int rndnum;
        internal static List<int> list = new List<int>();
        internal static Random rnd = new Random();
        internal static int correctAnswerCount;

        public static int generateUniqueNumber()
        {
            do
            {
                rndnum = rnd.Next(1, 11);
            }
            while (list.Contains(rndnum));

            list.Add(rndnum);

            return rndnum;
        }


        public Question2()
        {
            InitializeComponent();

//            rndnum = generateUniqueNumber();
            rndnum = 1;


            if (rndnum == 1 )
            {
                QuestionTextBox.Text = AppScreen.Question1();
                TextBoxa.Text = AppScreen.Question1a();
                TextBoxb.Text = AppScreen.Question1b();
                TextBoxc.Text = AppScreen.Question1c();
                TextBoxd.Text = AppScreen.Question1d();

            }
            else if (rndnum == 2)
            {
                QuestionTextBox.Text = AppScreen.Question2();
                TextBoxa.Text = AppScreen.Question2a();
                TextBoxb.Text = AppScreen.Question2b();
                TextBoxc.Text = AppScreen.Question2c();
                TextBoxd.Text = AppScreen.Question2d();
            }
            else if (rndnum == 3)
            {
                QuestionTextBox.Text = AppScreen.Question3();
                TextBoxa.Text = AppScreen.Question3a();
                TextBoxb.Text = AppScreen.Question3b();
                TextBoxc.Text = AppScreen.Question3c();
                TextBoxd.Text = AppScreen.Question3d();
            }
            else if (rndnum == 4)
            {
                QuestionTextBox.Text = AppScreen.Question4();
                TextBoxa.Text = AppScreen.Question4a();
                TextBoxb.Text = AppScreen.Question4b();
                TextBoxc.Text = AppScreen.Question4c();
                TextBoxd.Text = AppScreen.Question4d();
            }
            else if (rndnum == 5)
            {
                QuestionTextBox.Text = AppScreen.Question5();
                TextBoxa.Text = AppScreen.Question5a();
                TextBoxb.Text = AppScreen.Question5b();
                TextBoxc.Text = AppScreen.Question5c();
                TextBoxd.Text = AppScreen.Question5d();
            }
            else if (rndnum == 6)
            {
                QuestionTextBox.Text = AppScreen.Question6();
                TextBoxa.Text = AppScreen.Question6a();
                TextBoxb.Text = AppScreen.Question6b();
                TextBoxc.Text = AppScreen.Question6c();
                TextBoxd.Text = AppScreen.Question6d();
            }
            else if (rndnum == 7)
            {
                QuestionTextBox.Text = AppScreen.Question7();
                TextBoxa.Text = AppScreen.Question7a();
                TextBoxb.Text = AppScreen.Question7b();
                TextBoxc.Text = AppScreen.Question7c();
                TextBoxd.Text = AppScreen.Question7d();
            }
            else if (rndnum == 8)
            {
                QuestionTextBox.Text = AppScreen.Question8();
                TextBoxa.Text = AppScreen.Question8a();
                TextBoxb.Text = AppScreen.Question8b();
                TextBoxc.Text = AppScreen.Question8c();
                TextBoxd.Text = AppScreen.Question8d();
            }
            else if (rndnum == 9)
            {
                QuestionTextBox.Text = AppScreen.Question9();
                TextBoxa.Text = AppScreen.Question9a();
                TextBoxb.Text = AppScreen.Question9b();
                TextBoxc.Text = AppScreen.Question9c();
                TextBoxd.Text = AppScreen.Question9d();
            }
            else if (rndnum == 10)
            {
                QuestionTextBox.Text = AppScreen.Question10();
                TextBoxa.Text = AppScreen.Question10a();
                TextBoxb.Text = AppScreen.Question10b();
                TextBoxc.Text = AppScreen.Question10c();
                TextBoxd.Text = AppScreen.Question10d();
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxa_Click(object sender, EventArgs e)
        {
            if (rndnum == 1)
            {
                TextBoxa.BackColor = Color.Red;
            }

            if (rndnum == 2)
            {

            }

            if (rndnum == 3)
            {

            }

            if (rndnum == 4)
            {

            }

            if (rndnum == 5)
            {

            }

            if (rndnum == 6)
            {

            }

            if (rndnum == 7)
            {

            }

            if (rndnum == 8)
            {

            }

            if (rndnum == 9)
            {

            }

            if (rndnum == 10)
            {

            }
        }

        private void TextBoxb_Click(object sender, EventArgs e)
        {
            if (rndnum == 1)
            {
                TextBoxb.BackColor = Color.Red;
            }

            if (rndnum == 2)
            {

            }

            if (rndnum == 3)
            {
                correctAnswerCount++;
            }

            if (rndnum == 4)
            {
                correctAnswerCount++;
            }

            if (rndnum == 5)
            {
                correctAnswerCount++;
            }

            if (rndnum == 6)
            {
                correctAnswerCount++;
            }

            if (rndnum == 7)
            {

            }

            if (rndnum == 8)
            {
                correctAnswerCount++;
            }

            if (rndnum == 9)
            {

            }

            if (rndnum == 10)
            {
                correctAnswerCount++;
            }

        }
        private void TextBoxc_Click(object sender, EventArgs e)
        {
            if (rndnum == 1)
            {
                TextBoxc.BackColor = Color.Green;
                correctAnswerCount++;
            }

            if (rndnum == 2)
            {

            }

            if (rndnum == 3)
            {

            }

            if (rndnum == 4)
            {

            }

            if (rndnum == 5)
            {

            }

            if (rndnum == 6)
            {

            }

            if (rndnum == 7)
            {
                correctAnswerCount++;
            }

            if (rndnum == 8)
            {

            }

            if (rndnum == 9)
            {
                correctAnswerCount++;
            }

            if (rndnum == 10)
            {

            }

        }
        private void TextBoxd_Click(object sender, EventArgs e)
        {
            if (rndnum == 1)
            {
                TextBoxd.BackColor = Color.Red;
            }

            if (rndnum == 2)
            {
                correctAnswerCount++;
            }

            if (rndnum == 3)
            {

            }

            if (rndnum == 4)
            {

            }

            if (rndnum == 5)
            {

            }

            if (rndnum == 6)
            {

            }

            if (rndnum == 7)
            {

            }

            if (rndnum == 8)
            {

            }

            if (rndnum == 9)
            {

            }

            if (rndnum == 10)
            {

            }
        }

    }
}
