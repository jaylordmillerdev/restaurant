
namespace Restaurant.App.View
{
    partial class OrderItem
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.DeliverBT = new System.Windows.Forms.PictureBox();
            this.DeleteBT = new System.Windows.Forms.PictureBox();
            this.Splitter = new System.Windows.Forms.Splitter();
            this.ProductInfoLB = new System.Windows.Forms.Label();
            this.CustomerInfoLB = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeliverBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBT)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.DeliverBT);
            this.MainPanel.Controls.Add(this.DeleteBT);
            this.MainPanel.Controls.Add(this.Splitter);
            this.MainPanel.Controls.Add(this.ProductInfoLB);
            this.MainPanel.Controls.Add(this.CustomerInfoLB);
            this.MainPanel.Location = new System.Drawing.Point(63, 196);
            this.MainPanel.MinimumSize = new System.Drawing.Size(674, 40);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(674, 59);
            this.MainPanel.TabIndex = 3;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowDetails);
            this.MainPanel.MouseEnter += new System.EventHandler(this.MainPanelEnter);
            this.MainPanel.MouseLeave += new System.EventHandler(this.MainPanelLeave);
            // 
            // DeliverBT
            // 
            this.DeliverBT.Location = new System.Drawing.Point(593, 20);
            this.DeliverBT.Name = "DeliverBT";
            this.DeliverBT.Size = new System.Drawing.Size(20, 20);
            this.DeliverBT.TabIndex = 8;
            this.DeliverBT.TabStop = false;
            this.DeliverBT.Click += new System.EventHandler(this.DeliverItem);
            // 
            // DeleteBT
            // 
            this.DeleteBT.Location = new System.Drawing.Point(632, 20);
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(20, 20);
            this.DeleteBT.TabIndex = 7;
            this.DeleteBT.TabStop = false;
            this.DeleteBT.Click += new System.EventHandler(this.Cancel);
            // 
            // Splitter
            // 
            this.Splitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(200)))), ((int)(((byte)(227)))));
            this.Splitter.Location = new System.Drawing.Point(0, 0);
            this.Splitter.Name = "Splitter";
            this.Splitter.Size = new System.Drawing.Size(6, 59);
            this.Splitter.TabIndex = 5;
            this.Splitter.TabStop = false;
            // 
            // ProductInfoLB
            // 
            this.ProductInfoLB.AutoSize = true;
            this.ProductInfoLB.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductInfoLB.Location = new System.Drawing.Point(27, 30);
            this.ProductInfoLB.Name = "ProductInfoLB";
            this.ProductInfoLB.Size = new System.Drawing.Size(199, 20);
            this.ProductInfoLB.TabIndex = 3;
            this.ProductInfoLB.Text = "${QUANTITY_NAME}/${PRICE}/${TOTAL}";
            // 
            // CustomerInfoLB
            // 
            this.CustomerInfoLB.AutoSize = true;
            this.CustomerInfoLB.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerInfoLB.Location = new System.Drawing.Point(27, 11);
            this.CustomerInfoLB.Name = "CustomerInfoLB";
            this.CustomerInfoLB.Size = new System.Drawing.Size(242, 20);
            this.CustomerInfoLB.TabIndex = 0;
            this.CustomerInfoLB.Text = "${CUSTOMER_NAME}/${CUSTOMER_ADDRESS}";
            // 
            // OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Name = "OrderItem";
            this.Text = "OrderItem";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeliverBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Splitter Splitter;
        private System.Windows.Forms.Label ProductInfoLB;
        private System.Windows.Forms.Label CustomerInfoLB;
        private System.Windows.Forms.PictureBox DeleteBT;
        private System.Windows.Forms.PictureBox DeliverBT;
    }
}