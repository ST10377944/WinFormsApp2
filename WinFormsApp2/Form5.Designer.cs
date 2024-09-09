namespace WinFormsApp2
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            Exit = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Top;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(576, 395);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(127, 20);
            linkLabel1.TabIndex = 29;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.BackColor = SystemColors.Highlight;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(380, 271);
            label3.Name = "label3";
            label3.Size = new Size(287, 25);
            label3.TabIndex = 28;
            label3.Text = "Monthly Claim System";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.login_icon;
            pictureBox1.Location = new Point(380, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.Location = new Point(481, 356);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(208, 27);
            textBox2.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Location = new Point(481, 311);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 27);
            textBox1.TabIndex = 25;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(348, 357);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 24;
            label2.Text = "Enter Password";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, 316);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 23;
            label1.Text = "Enter ManagerID";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.AutoSize = true;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(642, 450);
            button3.Name = "button3";
            button3.Size = new Size(167, 37);
            button3.TabIndex = 22;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Top;
            Exit.AutoSize = true;
            Exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.Location = new Point(460, 449);
            Exit.Name = "Exit";
            Exit.Size = new Size(166, 38);
            Exit.TabIndex = 21;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(270, 449);
            button1.Name = "button1";
            button1.Size = new Size(172, 38);
            button1.TabIndex = 20;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 560);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(Exit);
            Controls.Add(button1);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button Exit;
        private Button button1;
    }
}