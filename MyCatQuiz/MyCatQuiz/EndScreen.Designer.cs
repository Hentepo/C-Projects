namespace MyCatQuiz
{
    partial class EndScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndScreen));
            label1 = new Label();
            label2 = new Label();
            QuestionTextBox = new TextBox();
            TextBoxa = new Button();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(554, 59);
            label2.Name = "label2";
            label2.Size = new Size(409, 128);
            label2.TabIndex = 1;
            label2.Text = "Tulokset";
            label2.Click += label2_Click;
            // 
            // QuestionTextBox
            // 
            QuestionTextBox.BorderStyle = BorderStyle.None;
            QuestionTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuestionTextBox.ForeColor = SystemColors.WindowText;
            QuestionTextBox.Location = new Point(249, 331);
            QuestionTextBox.Name = "QuestionTextBox";
            QuestionTextBox.Size = new Size(1148, 43);
            QuestionTextBox.TabIndex = 3;
            QuestionTextBox.TabStop = false;
            QuestionTextBox.Text = "QuestionTextBox";
            // 
            // TextBoxa
            // 
            TextBoxa.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxa.Location = new Point(510, 725);
            TextBoxa.Name = "TextBoxa";
            TextBoxa.Size = new Size(578, 65);
            TextBoxa.TabIndex = 4;
            TextBoxa.Text = "Lopeta";
            TextBoxa.UseVisualStyleBackColor = true;
            TextBoxa.Click += TextBoxa_Click;
            // 
            // EndScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1662, 939);
            Controls.Add(TextBoxa);
            Controls.Add(QuestionTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EndScreen";
            Text = "Form12";
            Load += Form12_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox QuestionTextBox;
        private Button TextBoxa;
    }
}
