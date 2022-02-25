namespace Coffee
{
    partial class fmCash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmCash));
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSubTotal = new System.Windows.Forms.TextBox();
            this.pnPad = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTotalPrice.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.Location = new System.Drawing.Point(22, 55);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(367, 64);
            this.txbTotalPrice.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số tiền thanh toán";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Coffee.Properties.Resources.color6;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbTotalPrice);
            this.panel1.Location = new System.Drawing.Point(-4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 175);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Coffee.Properties.Resources.color6;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnCheckOut);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txbSubTotal);
            this.panel2.Location = new System.Drawing.Point(-21, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 220);
            this.panel2.TabIndex = 3;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackgroundImage = global::Coffee.Properties.Resources.color7;
            this.btnCheckOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckOut.Location = new System.Drawing.Point(39, 142);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(367, 75);
            this.btnCheckOut.TabIndex = 5;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(33, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tiền nhận";
            // 
            // txbSubTotal
            // 
            this.txbSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSubTotal.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSubTotal.Location = new System.Drawing.Point(39, 49);
            this.txbSubTotal.Name = "txbSubTotal";
            this.txbSubTotal.Size = new System.Drawing.Size(367, 64);
            this.txbSubTotal.TabIndex = 0;
            // 
            // pnPad
            // 
            this.pnPad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPad.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnPad.BackgroundImage = global::Coffee.Properties.Resources.color6;
            this.pnPad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnPad.Location = new System.Drawing.Point(406, 12);
            this.pnPad.Name = "pnPad";
            this.pnPad.Size = new System.Drawing.Size(337, 408);
            this.pnPad.TabIndex = 4;
            // 
            // fmCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coffee.Properties.Resources.color6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 423);
            this.Controls.Add(this.pnPad);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Cambria", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "fmCash";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmCash";
            this.Load += new System.EventHandler(this.fmCash_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSubTotal;
        private System.Windows.Forms.FlowLayoutPanel pnPad;
        private System.Windows.Forms.Button btnCheckOut;
    }
}