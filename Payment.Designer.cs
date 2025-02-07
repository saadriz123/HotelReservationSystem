namespace HotelReservationsSystem
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label7 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(317, 41);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 3;
            label2.Text = "Payment Details";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Location = new Point(233, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(325, 313);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(253, 219);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(281, 27);
            textBox2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 117);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 7;
            label1.Text = "Name on card";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 185);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 8;
            label3.Text = "Card number";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(253, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 27);
            textBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 259);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(253, 259);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 11;
            label5.Text = "Expiry date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(253, 322);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 12;
            label6.Text = "CVC";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(253, 354);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(295, 415);
            label7.Name = "label7";
            label7.Size = new Size(214, 20);
            label7.TabIndex = 15;
            label7.Text = "Agree to Terms and Conditions";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(271, 418);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 16;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Location = new Point(335, 449);
            button1.Name = "button1";
            button1.Size = new Size(103, 38);
            button1.TabIndex = 17;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(66, 29);
            button2.TabIndex = 18;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(253, 282);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(281, 27);
            textBox3.TabIndex = 19;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(798, 499);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(label7);
            Controls.Add(maskedTextBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            DoubleBuffered = true;
            Name = "Payment";
            Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox maskedTextBox1;
        private Label label7;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox3;
    }
}