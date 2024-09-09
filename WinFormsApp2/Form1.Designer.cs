namespace WinFormsApp2
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            Lecturebutton = new Button();
            ManagerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(259, 32);
            label1.Name = "label1";
            label1.Size = new Size(355, 31);
            label1.TabIndex = 0;
            label1.Text = "Contract Monthly Claim System";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.lecture_2044621;
            pictureBox1.Location = new Point(199, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(504, 264);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(360, 342);
            label2.Name = "label2";
            label2.Size = new Size(184, 20);
            label2.TabIndex = 2;
            label2.Text = "Please Choose Your Login";
            label2.Click += label2_Click_1;
            // 
            // Lecturebutton
            // 
            Lecturebutton.Anchor = AnchorStyles.Top;
            Lecturebutton.BackColor = SystemColors.GradientActiveCaption;
            Lecturebutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lecturebutton.Location = new Point(293, 377);
            Lecturebutton.Name = "Lecturebutton";
            Lecturebutton.Size = new Size(128, 29);
            Lecturebutton.TabIndex = 3;
            Lecturebutton.Text = "Lecture Login";
            Lecturebutton.UseVisualStyleBackColor = false;
            Lecturebutton.Click += Lecturebutton_Click_1;
            // 
            // ManagerButton
            // 
            ManagerButton.Anchor = AnchorStyles.Top;
            ManagerButton.BackColor = SystemColors.GradientActiveCaption;
            ManagerButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManagerButton.Location = new Point(445, 377);
            ManagerButton.Name = "ManagerButton";
            ManagerButton.Size = new Size(139, 29);
            ManagerButton.TabIndex = 4;
            ManagerButton.Text = "Manager Login";
            ManagerButton.UseVisualStyleBackColor = false;
            ManagerButton.Click += ManagerButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 450);
            Controls.Add(ManagerButton);
            Controls.Add(Lecturebutton);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "LoginWindow";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button Lecturebutton;
        private Button ManagerButton;
    }
}
