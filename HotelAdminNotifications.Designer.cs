namespace HotelBookingDemo
{
    partial class HotelAdminNotifications
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
            this.lblHotelAdminNotifications = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CloseButton = new System.Windows.Forms.Button();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nights = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHotelAdminNotifications
            // 
            this.lblHotelAdminNotifications.AutoSize = true;
            this.lblHotelAdminNotifications.Location = new System.Drawing.Point(19, 13);
            this.lblHotelAdminNotifications.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHotelAdminNotifications.Name = "lblHotelAdminNotifications";
            this.lblHotelAdminNotifications.Size = new System.Drawing.Size(123, 20);
            this.lblHotelAdminNotifications.TabIndex = 0;
            this.lblHotelAdminNotifications.Text = "Guest Bookings";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstname,
            this.lastname,
            this.address,
            this.email,
            this.Phone,
            this.nights});
            this.dataGridView1.Location = new System.Drawing.Point(20, 38);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1065, 231);
            this.dataGridView1.TabIndex = 2;
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Location = new System.Drawing.Point(1010, 301);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 26);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // firstname
            // 
            this.firstname.HeaderText = "First Name";
            this.firstname.MinimumWidth = 8;
            this.firstname.Name = "firstname";
            this.firstname.Width = 150;
            // 
            // lastname
            // 
            this.lastname.HeaderText = "Last Name";
            this.lastname.MinimumWidth = 8;
            this.lastname.Name = "lastname";
            this.lastname.Width = 150;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 8;
            this.address.Name = "address";
            this.address.Width = 250;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            this.email.Width = 200;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone Number";
            this.Phone.MinimumWidth = 8;
            this.Phone.Name = "Phone";
            this.Phone.Width = 150;
            // 
            // nights
            // 
            this.nights.HeaderText = "Nights";
            this.nights.MinimumWidth = 8;
            this.nights.Name = "nights";
            // 
            // HotelAdminNotifications
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1101, 345);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblHotelAdminNotifications);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HotelAdminNotifications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Administration System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHotelAdminNotifications;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn nights;
    }
}