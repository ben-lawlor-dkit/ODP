namespace HotelBookingDemo
{
    partial class AdminPromoDeals
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
            this.richTextBoxPromoDeals = new System.Windows.Forms.RichTextBox();
            this.ButtonPromoDeals = new System.Windows.Forms.Button();
            this.LabelEnterNewDeal = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.LabelPromotionalDeal = new System.Windows.Forms.Label();
            this.LabelWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxPromoDeals
            // 
            this.richTextBoxPromoDeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxPromoDeals.Location = new System.Drawing.Point(369, 81);
            this.richTextBoxPromoDeals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxPromoDeals.MaxLength = 200;
            this.richTextBoxPromoDeals.Multiline = false;
            this.richTextBoxPromoDeals.Name = "richTextBoxPromoDeals";
            this.richTextBoxPromoDeals.Size = new System.Drawing.Size(313, 34);
            this.richTextBoxPromoDeals.TabIndex = 0;
            this.richTextBoxPromoDeals.Text = "";
            // 
            // ButtonPromoDeals
            // 
            this.ButtonPromoDeals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPromoDeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPromoDeals.Location = new System.Drawing.Point(179, 130);
            this.ButtonPromoDeals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonPromoDeals.Name = "ButtonPromoDeals";
            this.ButtonPromoDeals.Size = new System.Drawing.Size(317, 40);
            this.ButtonPromoDeals.TabIndex = 1;
            this.ButtonPromoDeals.Text = "Post New Promotion Deal";
            this.ButtonPromoDeals.UseVisualStyleBackColor = true;
            this.ButtonPromoDeals.Click += new System.EventHandler(this.ButtonPromoDeals_Click);
            // 
            // LabelEnterNewDeal
            // 
            this.LabelEnterNewDeal.AutoSize = true;
            this.LabelEnterNewDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEnterNewDeal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelEnterNewDeal.Location = new System.Drawing.Point(35, 87);
            this.LabelEnterNewDeal.Name = "LabelEnterNewDeal";
            this.LabelEnterNewDeal.Size = new System.Drawing.Size(308, 25);
            this.LabelEnterNewDeal.TabIndex = 2;
            this.LabelEnterNewDeal.Text = "Enter New Promotional Deal Here:";
            // 
            // ButtonClose
            // 
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.Location = new System.Drawing.Point(584, 223);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(98, 33);
            this.ButtonClose.TabIndex = 3;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // LabelPromotionalDeal
            // 
            this.LabelPromotionalDeal.AutoSize = true;
            this.LabelPromotionalDeal.Location = new System.Drawing.Point(175, 187);
            this.LabelPromotionalDeal.Name = "LabelPromotionalDeal";
            this.LabelPromotionalDeal.Size = new System.Drawing.Size(88, 20);
            this.LabelPromotionalDeal.TabIndex = 4;
            this.LabelPromotionalDeal.Text = "PromoDeal";
            this.LabelPromotionalDeal.Visible = false;
            // 
            // LabelWarning
            // 
            this.LabelWarning.AutoSize = true;
            this.LabelWarning.Location = new System.Drawing.Point(42, 23);
            this.LabelWarning.Name = "LabelWarning";
            this.LabelWarning.Size = new System.Drawing.Size(610, 40);
            this.LabelWarning.TabIndex = 5;
            this.LabelWarning.Text = "Warning: No bookings have been made, so no customers will receive the offer.\r\nMak" +
    "e a booking first with your email address(es) to see this observer pattern in ac" +
    "tion.";
            this.LabelWarning.Visible = false;
            // 
            // AdminPromoDeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(694, 268);
            this.Controls.Add(this.LabelWarning);
            this.Controls.Add(this.LabelPromotionalDeal);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.LabelEnterNewDeal);
            this.Controls.Add(this.ButtonPromoDeals);
            this.Controls.Add(this.richTextBoxPromoDeals);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminPromoDeals";
            this.Text = "Admin Promotional Deals";
            this.Load += new System.EventHandler(this.AdminPromoDeals_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxPromoDeals;
        private System.Windows.Forms.Button ButtonPromoDeals;
        private System.Windows.Forms.Label LabelEnterNewDeal;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelPromotionalDeal;
        private System.Windows.Forms.Label LabelWarning;
    }
}