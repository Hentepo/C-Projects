using System.Collections.Generic;

namespace MyCatQuiz
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

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

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}