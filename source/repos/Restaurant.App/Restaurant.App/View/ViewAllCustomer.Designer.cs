
namespace Restaurant.App.View
{
    partial class ViewAllCustomer
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
            this.CustomerViewLayout = new System.Windows.Forms.TableLayoutPanel();
            this.layout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddCustomerBT = new System.Windows.Forms.PictureBox();
            this.CustomerViewLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddCustomerBT)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerViewLayout
            // 
            this.CustomerViewLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.CustomerViewLayout.ColumnCount = 1;
            this.CustomerViewLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CustomerViewLayout.Controls.Add(this.layout, 0, 1);
            this.CustomerViewLayout.Controls.Add(this.panel1, 0, 0);
            this.CustomerViewLayout.Location = new System.Drawing.Point(1, 2);
            this.CustomerViewLayout.MinimumSize = new System.Drawing.Size(674, 450);
            this.CustomerViewLayout.Name = "CustomerViewLayout";
            this.CustomerViewLayout.RowCount = 2;
            this.CustomerViewLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.CustomerViewLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.CustomerViewLayout.Size = new System.Drawing.Size(692, 450);
            this.CustomerViewLayout.TabIndex = 0;
            // 
            // layout
            // 
            this.layout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layout.AutoScroll = true;
            this.layout.BackColor = System.Drawing.Color.Transparent;
            this.layout.Location = new System.Drawing.Point(3, 48);
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(686, 399);
            this.layout.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.AddCustomerBT);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 39);
            this.panel1.TabIndex = 2;
            // 
            // AddCustomerBT
            // 
            this.AddCustomerBT.Location = new System.Drawing.Point(626, 5);
            this.AddCustomerBT.Name = "AddCustomerBT";
            this.AddCustomerBT.Size = new System.Drawing.Size(30, 30);
            this.AddCustomerBT.TabIndex = 3;
            this.AddCustomerBT.TabStop = false;
            this.AddCustomerBT.Click += new System.EventHandler(this.NewCustomerBT);
            // 
            // ViewAllCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerViewLayout);
            this.Name = "ViewAllCustomer";
            this.Text = "ViewAllCustomer";
            this.CustomerViewLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddCustomerBT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel layout;
        public System.Windows.Forms.TableLayoutPanel CustomerViewLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox AddCustomerBT;
    }
}