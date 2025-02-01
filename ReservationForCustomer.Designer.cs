namespace HotelReservationsSystem
{
    partial class ReservationForCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForCustomer));
            button2 = new Button();
            sumbit = new Button();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(307, 161);
            button2.Name = "button2";
            button2.Size = new Size(192, 60);
            button2.TabIndex = 1;
            button2.Text = "Manage Reservations";
            button2.UseVisualStyleBackColor = true;
            // 
            // sumbit
            // 
            sumbit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sumbit.Location = new Point(307, 77);
            sumbit.Name = "sumbit";
            sumbit.Size = new Size(192, 60);
            sumbit.TabIndex = 2;
            sumbit.Text = "Book Rooms";
            sumbit.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(307, 253);
            button3.Name = "button3";
            button3.Size = new Size(192, 60);
            button3.TabIndex = 3;
            button3.Text = "Feedbcak";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(66, 29);
            button1.TabIndex = 4;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // ReservationForCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(sumbit);
            Controls.Add(button2);
            DoubleBuffered = true;
            Name = "ReservationForCustomer";
            Text = "ReservationForCustomer";
            Load += ReservationForCustomer_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button sumbit;
        private Button button3;
        private Button button1;
    }
}