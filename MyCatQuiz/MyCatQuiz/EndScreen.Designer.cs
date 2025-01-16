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
            ResultLabel = new TextBox();
            TextBoxEnd = new Button();
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
            // 
            // ResultLabel
            // 
            ResultLabel.BorderStyle = BorderStyle.None;
            ResultLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultLabel.ForeColor = SystemColors.WindowText;
            ResultLabel.Location = new Point(252, 312);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(1150, 43);
            ResultLabel.TabIndex = 3;
            ResultLabel.TabStop = false;
            ResultLabel.Text = "ResultLabel";
            ResultLabel.TextChanged += ResultTextBox_TextChanged;
            // 
            // TextBoxEnd
            // 
            TextBoxEnd.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxEnd.Location = new Point(510, 725);
            TextBoxEnd.Name = "TextBoxEnd";
            TextBoxEnd.Size = new Size(578, 65);
            TextBoxEnd.TabIndex = 4;
            TextBoxEnd.Text = "Lopeta";
            TextBoxEnd.UseVisualStyleBackColor = true;
            TextBoxEnd.Click += TextBoxEnd_Click;

            // 
            // EndScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1662, 939);
            Controls.Add(TextBoxEnd);
            Controls.Add(ResultLabel);
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
        private TextBox ResultLabel;
        private Button TextBoxEnd;
    }
}
