namespace MyCatQuiz
{
    partial class Question10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question6));
            label1 = new Label();
            label2 = new Label();
            QuestionTextBox = new TextBox();
            TextBoxa = new Button();
            TextBoxb = new Button();
            TextBoxc = new Button();
            TextBoxd = new Button();
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
            label2.Size = new Size(487, 128);
            label2.TabIndex = 1;
            label2.Text = "Kysymys 10";
            // 
            // QuestionTextBox
            // 
            QuestionTextBox.BorderStyle = BorderStyle.None;
            QuestionTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuestionTextBox.ForeColor = SystemColors.WindowText;
            QuestionTextBox.Location = new Point(252, 265);
            QuestionTextBox.Name = "QuestionTextBox";
            QuestionTextBox.Size = new Size(1148, 43);
            QuestionTextBox.TabIndex = 3;
            QuestionTextBox.TabStop = false;
            QuestionTextBox.Text = "QuestionTextBox";
            // 
            // TextBoxa
            // 
            TextBoxa.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxa.Location = new Point(317, 389);
            TextBoxa.Name = "TextBoxa";
            TextBoxa.Size = new Size(995, 65);
            TextBoxa.TabIndex = 4;
            TextBoxa.Text = "button1";
            TextBoxa.UseVisualStyleBackColor = true;
            TextBoxa.Click += TextBoxa_Click;

            // 
            // TextBoxb
            // 
            TextBoxb.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxb.Location = new Point(317, 512);
            TextBoxb.Name = "TextBoxb";
            TextBoxb.Size = new Size(995, 65);
            TextBoxb.TabIndex = 5;
            TextBoxb.Text = "button1";
            TextBoxb.UseVisualStyleBackColor = true;
            TextBoxb.Click += TextBoxb_Click;

            // 
            // TextBoxc
            // 
            TextBoxc.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxc.Location = new Point(317, 625);
            TextBoxc.Name = "TextBoxc";
            TextBoxc.Size = new Size(995, 65);
            TextBoxc.TabIndex = 6;
            TextBoxc.Text = "button1";
            TextBoxc.UseVisualStyleBackColor = true;
            TextBoxc.Click += TextBoxc_Click;
            // 
            // TextBoxd
            // 
            TextBoxd.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxd.Location = new Point(317, 735);
            TextBoxd.Name = "TextBoxd";
            TextBoxd.Size = new Size(995, 65);
            TextBoxd.TabIndex = 7;
            TextBoxd.Text = "button1";
            TextBoxd.UseVisualStyleBackColor = true;
            TextBoxd.Click += TextBoxd_Click;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1662, 939);
            Controls.Add(TextBoxd);
            Controls.Add(TextBoxc);
            Controls.Add(TextBoxb);
            Controls.Add(TextBoxa);
            Controls.Add(QuestionTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form11";
            Text = "Form11";
            Load += Form11_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox QuestionTextBox;
        private Button TextBoxa;
        private Button TextBoxb;
        private Button TextBoxc;
        private Button TextBoxd;
    }
}
