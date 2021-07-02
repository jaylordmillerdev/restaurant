
namespace Restaurant.App.View
{
    partial class ViewAllOrder
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
            this.OrderViewLayout = new System.Windows.Forms.TableLayoutPanel();
            this.layout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RefreshBT = new System.Windows.Forms.PictureBox();
            this.ExitFilter = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterEndDate = new System.Windows.Forms.DateTimePicker();
            this.FilterStartDate = new System.Windows.Forms.DateTimePicker();
            this.OrderViewLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderViewLayout
            // 
            this.OrderViewLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.OrderViewLayout.ColumnCount = 1;
            this.OrderViewLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OrderViewLayout.Controls.Add(this.layout, 0, 1);
            this.OrderViewLayout.Controls.Add(this.panel1, 0, 0);
            this.OrderViewLayout.Location = new System.Drawing.Point(54, 0);
            this.OrderViewLayout.MinimumSize = new System.Drawing.Size(674, 450);
            this.OrderViewLayout.Name = "OrderViewLayout";
            this.OrderViewLayout.RowCount = 2;
            this.OrderViewLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderViewLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.OrderViewLayout.Size = new System.Drawing.Size(692, 450);
            this.OrderViewLayout.TabIndex = 1;
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
            this.panel1.Controls.Add(this.RefreshBT);
            this.panel1.Controls.Add(this.ExitFilter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FilterEndDate);
            this.panel1.Controls.Add(this.FilterStartDate);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 39);
            this.panel1.TabIndex = 2;
            // 
            // RefreshBT
            // 
            this.RefreshBT.Location = new System.Drawing.Point(617, 10);
            this.RefreshBT.Name = "RefreshBT";
            this.RefreshBT.Size = new System.Drawing.Size(20, 20);
            this.RefreshBT.TabIndex = 9;
            this.RefreshBT.TabStop = false;
            this.RefreshBT.Click += new System.EventHandler(this.Refresh);
            // 
            // ExitFilter
            // 
            this.ExitFilter.Location = new System.Drawing.Point(653, 10);
            this.ExitFilter.Name = "ExitFilter";
            this.ExitFilter.Size = new System.Drawing.Size(20, 20);
            this.ExitFilter.TabIndex = 8;
            this.ExitFilter.TabStop = false;
            this.ExitFilter.Click += new System.EventHandler(this.RefetchAllData);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start";
            // 
            // FilterEndDate
            // 
            this.FilterEndDate.Location = new System.Drawing.Point(401, 9);
            this.FilterEndDate.Name = "FilterEndDate";
            this.FilterEndDate.Size = new System.Drawing.Size(200, 20);
            this.FilterEndDate.TabIndex = 1;
            this.FilterEndDate.ValueChanged += new System.EventHandler(this.EndDateChangeValue);
            // 
            // FilterStartDate
            // 
            this.FilterStartDate.Location = new System.Drawing.Point(56, 9);
            this.FilterStartDate.Name = "FilterStartDate";
            this.FilterStartDate.Size = new System.Drawing.Size(200, 20);
            this.FilterStartDate.TabIndex = 0;
            this.FilterStartDate.ValueChanged += new System.EventHandler(this.StartDateChangeValue);
            // 
            // ViewAllOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderViewLayout);
            this.Name = "ViewAllOrder";
            this.Text = "ViewAllOrder";
            this.OrderViewLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel OrderViewLayout;
        public System.Windows.Forms.FlowLayoutPanel layout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FilterEndDate;
        private System.Windows.Forms.DateTimePicker FilterStartDate;
        private System.Windows.Forms.PictureBox ExitFilter;
        private System.Windows.Forms.PictureBox RefreshBT;
    }
}