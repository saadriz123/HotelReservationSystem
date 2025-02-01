namespace HotelReservationsSystem
{
    partial class ManageSpecialOffers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSpecialOffers));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(66, 29);
            button1.TabIndex = 16;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 135);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 17;
            label1.Text = "Promotion code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(339, 39);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 24;
            label2.Text = "Apply Offers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 174);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 25;
            label3.Text = "Discount Percentage";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 260);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 26;
            label4.Text = "End Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(151, 217);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 27;
            label5.Text = "Start Date";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(364, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 28;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(364, 172);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(125, 27);
            numericUpDown1.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(364, 217);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 30;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(364, 260);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 31;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(512, 322);
            button2.Name = "button2";
            button2.Size = new Size(102, 34);
            button2.TabIndex = 32;
            button2.Text = "Add Offer";
            button2.UseVisualStyleBackColor = true;
            // 
            // ManageSpecialOffers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "ManageSpecialOffers";
            Text = "ManageSpecialOffers";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button2;
    }
}