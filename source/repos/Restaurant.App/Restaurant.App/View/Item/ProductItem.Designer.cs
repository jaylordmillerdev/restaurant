
namespace Restaurant.App.View
{
    partial class ProductItem
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
            this.OrderNowBT = new System.Windows.Forms.PictureBox();
            this.EditBT = new System.Windows.Forms.PictureBox();
            this.DeleteBT = new System.Windows.Forms.PictureBox();
            this.Splitter = new System.Windows.Forms.Splitter();
            this.QuantityLeftLB = new System.Windows.Forms.Label();
            this.ProductNameLB = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderNowBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBT)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.OrderNowBT);
            this.MainPanel.Controls.Add(this.EditBT);
            this.MainPanel.Controls.Add(this.DeleteBT);
            this.MainPanel.Controls.Add(this.Splitter);
            this.MainPanel.Controls.Add(this.QuantityLeftLB);
            this.MainPanel.Controls.Add(this.ProductNameLB);
            this.MainPanel.Location = new System.Drawing.Point(63, 205);
            this.MainPanel.MinimumSize = new System.Drawing.Size(674, 40);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(674, 59);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowDetails);
            this.MainPanel.MouseEnter += new System.EventHandler(this.MainPanelEnter);
            this.MainPanel.MouseLeave += new System.EventHandler(this.MainPanelLeave);
            // 
            // OrderNowBT
            // 
            this.OrderNowBT.Location = new System.Drawing.Point(556, 20);
            this.OrderNowBT.Name = "OrderNowBT";
            this.OrderNowBT.Size = new System.Drawing.Size(20, 20);
            this.OrderNowBT.TabIndex = 8;
            this.OrderNowBT.TabStop = false;
            this.OrderNowBT.Click += new System.EventHandler(this.OrderItem);
            // 
            // EditBT
            // 
            this.EditBT.Location = new System.Drawing.Point(595, 20);
            this.EditBT.Name = "EditBT";
            this.EditBT.Size = new System.Drawing.Size(20, 20);
            this.EditBT.TabIndex = 7;
            this.EditBT.TabStop = false;
            this.EditBT.Click += new System.EventHandler(this.UpdateItem);
            // 
            // DeleteBT
            // 
            this.DeleteBT.Location = new System.Drawing.Point(635, 20);
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(20, 20);
            this.DeleteBT.TabIndex = 6;
            this.DeleteBT.TabStop = false;
            this.DeleteBT.Click += new System.EventHandler(this.DeleteItem);
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
            // QuantityLeftLB
            // 
            this.QuantityLeftLB.AutoSize = true;
            this.QuantityLeftLB.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLeftLB.Location = new System.Drawing.Point(27, 30);
            this.QuantityLeftLB.Name = "QuantityLeftLB";
            this.QuantityLeftLB.Size = new System.Drawing.Size(107, 20);
            this.QuantityLeftLB.TabIndex = 3;
            this.QuantityLeftLB.Text = "${QUANTITY_NAME}";
            // 
            // ProductNameLB
            // 
            this.ProductNameLB.AutoSize = true;
            this.ProductNameLB.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLB.Location = new System.Drawing.Point(27, 13);
            this.ProductNameLB.Name = "ProductNameLB";
            this.ProductNameLB.Size = new System.Drawing.Size(115, 20);
            this.ProductNameLB.TabIndex = 0;
            this.ProductNameLB.Text = "${CUSTOMER_NAME}";
            // 
            // ProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Name = "ProductItem";
            this.Text = "ProductItem";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderNowBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label ProductNameLB;
        private System.Windows.Forms.Label QuantityLeftLB;
        private System.Windows.Forms.Splitter Splitter;
        private System.Windows.Forms.PictureBox DeleteBT;
        private System.Windows.Forms.PictureBox EditBT;
        private System.Windows.Forms.PictureBox OrderNowBT;
    }
}