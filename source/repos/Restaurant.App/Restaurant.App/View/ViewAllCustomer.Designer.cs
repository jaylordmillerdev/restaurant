﻿
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
            this.button1 = new System.Windows.Forms.Button();
            this.CustomerViewLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerViewLayout
            // 
            this.CustomerViewLayout.ColumnCount = 1;
            this.CustomerViewLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CustomerViewLayout.Controls.Add(this.layout, 0, 1);
            this.CustomerViewLayout.Controls.Add(this.button1, 0, 0);
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
            this.layout.BackColor = System.Drawing.Color.White;
            this.layout.Location = new System.Drawing.Point(3, 48);
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(686, 399);
            this.layout.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NewCustomerBT);
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
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel layout;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TableLayoutPanel CustomerViewLayout;
    }
}