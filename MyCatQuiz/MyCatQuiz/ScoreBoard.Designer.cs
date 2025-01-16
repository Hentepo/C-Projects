namespace MyCatQuiz
{
    partial class ScoreBoard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreBoard));
            label1 = new Label();
            ScoreBoardLabel = new Label();
            ScoreLabel = new TextBox();
            TextBoxBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // ScoreBoardLabel
            // 
            ScoreBoardLabel.AutoSize = true;
            ScoreBoardLabel.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ScoreBoardLabel.Location = new Point(554, 59);
            ScoreBoardLabel.Name = "ScoreBoardLabel";
            ScoreBoardLabel.Size = new Size(620, 128);
            ScoreBoardLabel.TabIndex = 1;
            ScoreBoardLabel.Text = "Pistetaulukko";
            // 
            // ScoreLabel
            // 
            ScoreLabel.BorderStyle = BorderStyle.None;
            ScoreLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ScoreLabel.ForeColor = SystemColors.WindowText;
            ScoreLabel.Location = new Point(252, 239);
            ScoreLabel.Multiline = true;
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(1150, 397);
            ScoreLabel.TabIndex = 3;
            ScoreLabel.TabStop = false;
            ScoreLabel.TextChanged += ResultTextBox_TextChanged;
            // 
            // TextBoxBack
            // 
            TextBoxBack.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxBack.Location = new Point(510, 725);
            TextBoxBack.Name = "TextBoxBack";
            TextBoxBack.Size = new Size(578, 65);
            TextBoxBack.TabIndex = 4;
            TextBoxBack.Text = "Takaisin";
            TextBoxBack.UseVisualStyleBackColor = true;
            TextBoxBack.Click += TextBoxBack_Click;
            // 
            // ScoreBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1662, 939);
            Controls.Add(TextBoxBack);
            Controls.Add(ScoreLabel);
            Controls.Add(ScoreBoardLabel);
            Controls.Add(label1);
            Name = "ScoreBoard";
            Text = "Form14";
            Load += Form14_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label ScoreBoardLabel;
        private TextBox ScoreLabel;
        private Button TextBoxBack;
    }
}
