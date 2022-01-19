namespace HotelBookingDemo
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.ButtonStandardRoom = new System.Windows.Forms.Button();
            this.ButtonBook = new System.Windows.Forms.Button();
            this.LabelPromoDeal = new System.Windows.Forms.Label();
            this.ButtonDisplayDeals = new System.Windows.Forms.Button();
            this.ButtonDeluxeRoom = new System.Windows.Forms.Button();
            this.ButtonBookings = new System.Windows.Forms.Button();
            this.ButtonAddPromo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonStandardRoom
            // 
            this.ButtonStandardRoom.BackColor = System.Drawing.Color.MidnightBlue;
            this.ButtonStandardRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonStandardRoom.BackgroundImage")));
            this.ButtonStandardRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonStandardRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStandardRoom.Location = new System.Drawing.Point(12, 318);
            this.ButtonStandardRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonStandardRoom.Name = "ButtonStandardRoom";
            this.ButtonStandardRoom.Size = new System.Drawing.Size(323, 181);
            this.ButtonStandardRoom.TabIndex = 2;
            this.ButtonStandardRoom.UseVisualStyleBackColor = false;
            this.ButtonStandardRoom.Click += new System.EventHandler(this.ButtonStandardRoom_Click);
            // 
            // ButtonBook
            // 
            this.ButtonBook.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBook.ForeColor = System.Drawing.Color.Honeydew;
            this.ButtonBook.Location = new System.Drawing.Point(334, 439);
            this.ButtonBook.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonBook.Name = "ButtonBook";
            this.ButtonBook.Size = new System.Drawing.Size(235, 60);
            this.ButtonBook.TabIndex = 3;
            this.ButtonBook.Text = "BOOK NOW";
            this.ButtonBook.UseVisualStyleBackColor = false;
            this.ButtonBook.Click += new System.EventHandler(this.ButtonBook_Click);
            // 
            // LabelPromoDeal
            // 
            this.LabelPromoDeal.AutoSize = true;
            this.LabelPromoDeal.BackColor = System.Drawing.Color.LimeGreen;
            this.LabelPromoDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPromoDeal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelPromoDeal.Location = new System.Drawing.Point(562, 29);
            this.LabelPromoDeal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPromoDeal.Name = "LabelPromoDeal";
            this.LabelPromoDeal.Size = new System.Drawing.Size(164, 29);
            this.LabelPromoDeal.TabIndex = 5;
            this.LabelPromoDeal.Text = "PromoDeals!";
            // 
            // ButtonDisplayDeals
            // 
            this.ButtonDisplayDeals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDisplayDeals.Location = new System.Drawing.Point(348, 26);
            this.ButtonDisplayDeals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonDisplayDeals.Name = "ButtonDisplayDeals";
            this.ButtonDisplayDeals.Size = new System.Drawing.Size(207, 36);
            this.ButtonDisplayDeals.TabIndex = 1;
            this.ButtonDisplayDeals.Text = "Display Promotional Deals";
            this.ButtonDisplayDeals.UseVisualStyleBackColor = true;
            this.ButtonDisplayDeals.Click += new System.EventHandler(this.ButtonDisplayDeals_Click);
            // 
            // ButtonDeluxeRoom
            // 
            this.ButtonDeluxeRoom.BackColor = System.Drawing.Color.MidnightBlue;
            this.ButtonDeluxeRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDeluxeRoom.BackgroundImage")));
            this.ButtonDeluxeRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonDeluxeRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDeluxeRoom.Location = new System.Drawing.Point(567, 318);
            this.ButtonDeluxeRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonDeluxeRoom.Name = "ButtonDeluxeRoom";
            this.ButtonDeluxeRoom.Size = new System.Drawing.Size(323, 181);
            this.ButtonDeluxeRoom.TabIndex = 4;
            this.ButtonDeluxeRoom.UseVisualStyleBackColor = false;
            this.ButtonDeluxeRoom.Click += new System.EventHandler(this.ButtonDeluxeRoom_Click);
            // 
            // ButtonBookings
            // 
            this.ButtonBookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBookings.Location = new System.Drawing.Point(12, 78);
            this.ButtonBookings.Name = "ButtonBookings";
            this.ButtonBookings.Size = new System.Drawing.Size(109, 29);
            this.ButtonBookings.TabIndex = 6;
            this.ButtonBookings.Text = "Bookings";
            this.ButtonBookings.UseVisualStyleBackColor = true;
            this.ButtonBookings.Click += new System.EventHandler(this.ButtonBookings_Click);
            // 
            // ButtonAddPromo
            // 
            this.ButtonAddPromo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddPromo.Location = new System.Drawing.Point(12, 113);
            this.ButtonAddPromo.Name = "ButtonAddPromo";
            this.ButtonAddPromo.Size = new System.Drawing.Size(109, 29);
            this.ButtonAddPromo.TabIndex = 7;
            this.ButtonAddPromo.Text = "Promotions";
            this.ButtonAddPromo.UseVisualStyleBackColor = true;
            this.ButtonAddPromo.Click += new System.EventHandler(this.ButtonAddPromo_Click);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(902, 526);
            this.Controls.Add(this.ButtonAddPromo);
            this.Controls.Add(this.ButtonBookings);
            this.Controls.Add(this.ButtonDeluxeRoom);
            this.Controls.Add(this.ButtonDisplayDeals);
            this.Controls.Add(this.LabelPromoDeal);
            this.Controls.Add(this.ButtonBook);
            this.Controls.Add(this.ButtonStandardRoom);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Booking Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStandardRoom;
        private System.Windows.Forms.Button ButtonBook;
        private System.Windows.Forms.Label LabelPromoDeal;
        private System.Windows.Forms.Button ButtonDisplayDeals;
        private System.Windows.Forms.Button ButtonDeluxeRoom;
        private System.Windows.Forms.Button ButtonBookings;
        private System.Windows.Forms.Button ButtonAddPromo;
    }
}

