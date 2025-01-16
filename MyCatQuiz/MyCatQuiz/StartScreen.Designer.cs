namespace MyCatQuiz
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            label1 = new Label();
            label2 = new Label();
            StartLabel = new TextBox();
            TextBoxOk = new Button();
            UserInputBox = new TextBox();
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
            label2.Location = new Point(588, 60);
            label2.Name = "label2";
            label2.Size = new Size(346, 128);
            label2.TabIndex = 1;
            label2.Text = "Aloitus";
            // 
            // StartLabel
            // 
            StartLabel.BorderStyle = BorderStyle.None;
            StartLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartLabel.ForeColor = SystemColors.WindowText;
            StartLabel.Location = new Point(252, 312);
            StartLabel.Name = "StartLabel";
            StartLabel.Size = new Size(1150, 43);
            StartLabel.TabIndex = 3;
            StartLabel.TabStop = false;
            StartLabel.Text = "StartLabel";
            StartLabel.TextChanged += ResultTextBox_TextChanged;
            // 
            // TextBoxOk
            // 
            TextBoxOk.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxOk.Location = new Point(510, 725);
            TextBoxOk.Name = "TextBoxOk";
            TextBoxOk.Size = new Size(578, 65);
            TextBoxOk.TabIndex = 4;
            TextBoxOk.Text = "OK";
            TextBoxOk.UseVisualStyleBackColor = true;
            TextBoxOk.Click += TextBoxOk_Click;
            // 
            // UserInputBox
            // 
            UserInputBox.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserInputBox.Location = new Point(605, 467);
            UserInputBox.Multiline = true;
            UserInputBox.Name = "UserInputBox";
            UserInputBox.Size = new Size(374, 95);
            UserInputBox.TabIndex = 5;
            UserInputBox.KeyDown += UserInputBox_KeyDown;
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1662, 939);
            Controls.Add(UserInputBox);
            Controls.Add(TextBoxOk);
            Controls.Add(StartLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StartScreen";
            Text = "Form13";
            Load += Form13_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox StartLabel;
        private Button TextBoxOk;
        private TextBox UserInputBox;
    }
}
