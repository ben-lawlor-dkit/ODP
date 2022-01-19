namespace HotelBookingDemo
{
    partial class RoomBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomBuilder));
            this.RadioButtonStandard = new System.Windows.Forms.RadioButton();
            this.RadioButtonDeluxe = new System.Windows.Forms.RadioButton();
            this.CheckBoxBreakfast = new System.Windows.Forms.CheckBox();
            this.CheckBoxDinner = new System.Windows.Forms.CheckBox();
            this.LabelBreakfastAndDinnerIncl = new System.Windows.Forms.Label();
            this.ButtonReserve = new System.Windows.Forms.Button();
            this.LabelTotalPrice = new System.Windows.Forms.Label();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RadioButtonStandard
            // 
            this.RadioButtonStandard.AutoSize = true;
            this.RadioButtonStandard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioButtonStandard.Image = ((System.Drawing.Image)(resources.GetObject("RadioButtonStandard.Image")));
            this.RadioButtonStandard.Location = new System.Drawing.Point(16, 23);
            this.RadioButtonStandard.Name = "RadioButtonStandard";
            this.RadioButtonStandard.Size = new System.Drawing.Size(356, 223);
            this.RadioButtonStandard.TabIndex = 0;
            this.RadioButtonStandard.TabStop = true;
            this.RadioButtonStandard.UseVisualStyleBackColor = true;
            this.RadioButtonStandard.CheckedChanged += new System.EventHandler(this.RadioButtonStandard_CheckedChanged);
            // 
            // RadioButtonDeluxe
            // 
            this.RadioButtonDeluxe.AutoSize = true;
            this.RadioButtonDeluxe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioButtonDeluxe.Image = ((System.Drawing.Image)(resources.GetObject("RadioButtonDeluxe.Image")));
            this.RadioButtonDeluxe.Location = new System.Drawing.Point(406, 23);
            this.RadioButtonDeluxe.Name = "RadioButtonDeluxe";
            this.RadioButtonDeluxe.Size = new System.Drawing.Size(356, 223);
            this.RadioButtonDeluxe.TabIndex = 1;
            this.RadioButtonDeluxe.TabStop = true;
            this.RadioButtonDeluxe.UseVisualStyleBackColor = true;
            this.RadioButtonDeluxe.CheckedChanged += new System.EventHandler(this.RadioButtonDeluxe_CheckedChanged);
            // 
            // CheckBoxBreakfast
            // 
            this.CheckBoxBreakfast.AutoSize = true;
            this.CheckBoxBreakfast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBoxBreakfast.Image = ((System.Drawing.Image)(resources.GetObject("CheckBoxBreakfast.Image")));
            this.CheckBoxBreakfast.Location = new System.Drawing.Point(14, 266);
            this.CheckBoxBreakfast.Name = "CheckBoxBreakfast";
            this.CheckBoxBreakfast.Size = new System.Drawing.Size(375, 225);
            this.CheckBoxBreakfast.TabIndex = 2;
            this.CheckBoxBreakfast.UseVisualStyleBackColor = true;
            this.CheckBoxBreakfast.CheckedChanged += new System.EventHandler(this.CheckBoxBreakfast_CheckedChanged);
            // 
            // CheckBoxDinner
            // 
            this.CheckBoxDinner.AutoSize = true;
            this.CheckBoxDinner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBoxDinner.Image = ((System.Drawing.Image)(resources.GetObject("CheckBoxDinner.Image")));
            this.CheckBoxDinner.Location = new System.Drawing.Point(404, 266);
            this.CheckBoxDinner.Name = "CheckBoxDinner";
            this.CheckBoxDinner.Size = new System.Drawing.Size(375, 225);
            this.CheckBoxDinner.TabIndex = 3;
            this.CheckBoxDinner.UseVisualStyleBackColor = true;
            this.CheckBoxDinner.CheckedChanged += new System.EventHandler(this.CheckBoxDinner_CheckedChanged);
            // 
            // LabelBreakfastAndDinnerIncl
            // 
            this.LabelBreakfastAndDinnerIncl.AutoSize = true;
            this.LabelBreakfastAndDinnerIncl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBreakfastAndDinnerIncl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelBreakfastAndDinnerIncl.Location = new System.Drawing.Point(768, 72);
            this.LabelBreakfastAndDinnerIncl.Name = "LabelBreakfastAndDinnerIncl";
            this.LabelBreakfastAndDinnerIncl.Size = new System.Drawing.Size(263, 116);
            this.LabelBreakfastAndDinnerIncl.TabIndex = 11;
            this.LabelBreakfastAndDinnerIncl.Text = "Breakfast and Dinner \r\nincluded in all\r\nDeluxe Room \r\npackages!";
            this.LabelBreakfastAndDinnerIncl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelBreakfastAndDinnerIncl.Visible = false;
            // 
            // ButtonReserve
            // 
            this.ButtonReserve.BackColor = System.Drawing.Color.DarkOrange;
            this.ButtonReserve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonReserve.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReserve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonReserve.Location = new System.Drawing.Point(797, 373);
            this.ButtonReserve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonReserve.Name = "ButtonReserve";
            this.ButtonReserve.Size = new System.Drawing.Size(212, 68);
            this.ButtonReserve.TabIndex = 14;
            this.ButtonReserve.Text = "Reserve";
            this.ButtonReserve.UseVisualStyleBackColor = false;
            this.ButtonReserve.Click += new System.EventHandler(this.ButtonReserve_Click);
            // 
            // LabelTotalPrice
            // 
            this.LabelTotalPrice.AutoSize = true;
            this.LabelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelTotalPrice.Location = new System.Drawing.Point(797, 333);
            this.LabelTotalPrice.Name = "LabelTotalPrice";
            this.LabelTotalPrice.Size = new System.Drawing.Size(36, 38);
            this.LabelTotalPrice.TabIndex = 13;
            this.LabelTotalPrice.Text = "€";
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.BackColor = System.Drawing.Color.MidnightBlue;
            this.LabelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelTotal.Location = new System.Drawing.Point(790, 283);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(154, 52);
            this.LabelTotal.TabIndex = 12;
            this.LabelTotal.Text = "Total: ";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(797, 461);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(86, 26);
            this.ButtonCancel.TabIndex = 15;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // RoomBuilder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1021, 503);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonReserve);
            this.Controls.Add(this.LabelTotalPrice);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.LabelBreakfastAndDinnerIncl);
            this.Controls.Add(this.CheckBoxDinner);
            this.Controls.Add(this.CheckBoxBreakfast);
            this.Controls.Add(this.RadioButtonDeluxe);
            this.Controls.Add(this.RadioButtonStandard);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "RoomBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Room Package";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.RadioButton RadioButtonStandard;

        #endregion

        private System.Windows.Forms.RadioButton RadioButtonDeluxe;
        private System.Windows.Forms.CheckBox CheckBoxBreakfast;
        private System.Windows.Forms.CheckBox CheckBoxDinner;
        private System.Windows.Forms.Label LabelBreakfastAndDinnerIncl;
        private System.Windows.Forms.Button ButtonReserve;
        private System.Windows.Forms.Label LabelTotalPrice;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Button ButtonCancel;
    }
}