namespace HotelReservationsSystem
{
    partial class ManagerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerDashboard));
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(305, 119);
            button1.Name = "button1";
            button1.Size = new Size(165, 52);
            button1.TabIndex = 0;
            button1.Text = "Manage Rooms";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(305, 188);
            button3.Name = "button3";
            button3.Size = new Size(165, 52);
            button3.TabIndex = 2;
            button3.Text = "View Feedback";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(305, 255);
            button4.Name = "button4";
            button4.Size = new Size(165, 52);
            button4.TabIndex = 3;
            button4.Text = "View Reports ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(12, 12);
            button5.Name = "button5";
            button5.Size = new Size(66, 29);
            button5.TabIndex = 20;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // ManagerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "ManagerDashboard";
            Text = "ManagerDashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}