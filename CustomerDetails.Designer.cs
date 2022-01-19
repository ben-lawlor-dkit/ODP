namespace HotelBookingDemo
{
    partial class CustomerDetails
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.ButtonReserve = new System.Windows.Forms.Button();
            this.lblNoOfNights = new System.Windows.Forms.Label();
            this.txtNoOfNights = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDisplayTotal = new System.Windows.Forms.Label();
            this.ButtonAddNights = new System.Windows.Forms.Button();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ButtonBackToRooms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(134, 77);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(94, 20);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "First Name: ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(230, 74);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(311, 26);
            this.txtFirstName.TabIndex = 11;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(134, 138);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(94, 20);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Last Name: ";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(230, 135);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(311, 26);
            this.txtLastName.TabIndex = 13;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(134, 199);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 20);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Address: ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(230, 196);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(311, 26);
            this.txtAddress.TabIndex = 15;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(134, 260);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(63, 20);
            this.lblPhone.TabIndex = 16;
            this.lblPhone.Text = "Phone: ";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(230, 257);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(311, 26);
            this.txtPhone.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(134, 321);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(230, 318);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(311, 26);
            this.txtEmail.TabIndex = 19;
            // 
            // ButtonReserve
            // 
            this.ButtonReserve.BackColor = System.Drawing.Color.PapayaWhip;
            this.ButtonReserve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReserve.Location = new System.Drawing.Point(169, 499);
            this.ButtonReserve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonReserve.Name = "ButtonReserve";
            this.ButtonReserve.Size = new System.Drawing.Size(422, 61);
            this.ButtonReserve.TabIndex = 20;
            this.ButtonReserve.Text = "Reserve";
            this.ButtonReserve.UseVisualStyleBackColor = false;
            this.ButtonReserve.Click += new System.EventHandler(this.ButtonReserve_Click);
            // 
            // lblNoOfNights
            // 
            this.lblNoOfNights.AutoSize = true;
            this.lblNoOfNights.Location = new System.Drawing.Point(315, 358);
            this.lblNoOfNights.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoOfNights.Name = "lblNoOfNights";
            this.lblNoOfNights.Size = new System.Drawing.Size(139, 20);
            this.lblNoOfNights.TabIndex = 21;
            this.lblNoOfNights.Text = "Number Of Nights:";
            // 
            // txtNoOfNights
            // 
            this.txtNoOfNights.Location = new System.Drawing.Point(360, 409);
            this.txtNoOfNights.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoOfNights.Name = "txtNoOfNights";
            this.txtNoOfNights.Size = new System.Drawing.Size(46, 26);
            this.txtNoOfNights.TabIndex = 22;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(238, 467);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 20);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "Total: ";
            // 
            // lblDisplayTotal
            // 
            this.lblDisplayTotal.AutoSize = true;
            this.lblDisplayTotal.Location = new System.Drawing.Point(296, 467);
            this.lblDisplayTotal.Name = "lblDisplayTotal";
            this.lblDisplayTotal.Size = new System.Drawing.Size(0, 20);
            this.lblDisplayTotal.TabIndex = 26;
            // 
            // ButtonAddNights
            // 
            this.ButtonAddNights.BackColor = System.Drawing.SystemColors.Info;
            this.ButtonAddNights.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddNights.Location = new System.Drawing.Point(430, 390);
            this.ButtonAddNights.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonAddNights.Name = "ButtonAddNights";
            this.ButtonAddNights.Size = new System.Drawing.Size(68, 65);
            this.ButtonAddNights.TabIndex = 27;
            this.ButtonAddNights.Text = "+";
            this.ButtonAddNights.UseVisualStyleBackColor = false;
            this.ButtonAddNights.Click += new System.EventHandler(this.ButtonAddNights_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.BackColor = System.Drawing.SystemColors.Info;
            this.ButtonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemove.Location = new System.Drawing.Point(268, 390);
            this.ButtonRemove.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(68, 65);
            this.ButtonRemove.TabIndex = 28;
            this.ButtonRemove.Text = "-";
            this.ButtonRemove.UseVisualStyleBackColor = false;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // ButtonBackToRooms
            // 
            this.ButtonBackToRooms.BackColor = System.Drawing.Color.PapayaWhip;
            this.ButtonBackToRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBackToRooms.Location = new System.Drawing.Point(3, 14);
            this.ButtonBackToRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonBackToRooms.Name = "ButtonBackToRooms";
            this.ButtonBackToRooms.Size = new System.Drawing.Size(187, 40);
            this.ButtonBackToRooms.TabIndex = 29;
            this.ButtonBackToRooms.Text = "<-- Back to Rooms";
            this.ButtonBackToRooms.UseVisualStyleBackColor = false;
            this.ButtonBackToRooms.Click += new System.EventHandler(this.ButtonBackToRooms_Click);
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(742, 575);
            this.Controls.Add(this.ButtonBackToRooms);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ButtonAddNights);
            this.Controls.Add(this.lblDisplayTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtNoOfNights);
            this.Controls.Add(this.lblNoOfNights);
            this.Controls.Add(this.ButtonReserve);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Booking Details";
            this.Load += new System.EventHandler(this.CustomerDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button ButtonReserve;
        private System.Windows.Forms.Label lblNoOfNights;
        private System.Windows.Forms.TextBox txtNoOfNights;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDisplayTotal;
        private System.Windows.Forms.Button ButtonAddNights;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.Button ButtonBackToRooms;
    }
}