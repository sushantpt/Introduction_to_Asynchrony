namespace Introduction_to_Asynchrony
{
    partial class Form1
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
            NonAsyncButton = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // NonAsyncButton
            // 
            NonAsyncButton.BackColor = Color.RosyBrown;
            NonAsyncButton.Location = new Point(35, 84);
            NonAsyncButton.Name = "NonAsyncButton";
            NonAsyncButton.Size = new Size(161, 29);
            NonAsyncButton.TabIndex = 0;
            NonAsyncButton.Text = "Non-Async Button";
            NonAsyncButton.UseVisualStyleBackColor = false;
            NonAsyncButton.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.GreenYellow;
            button2.Location = new Point(35, 180);
            button2.Name = "button2";
            button2.Size = new Size(161, 29);
            button2.TabIndex = 1;
            button2.Text = "Async Button";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(223, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(678, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(223, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(678, 27);
            textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 360);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(NonAsyncButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NonAsyncButton;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
