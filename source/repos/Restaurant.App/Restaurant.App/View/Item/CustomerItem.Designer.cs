
namespace Restaurant.App.View
{
    partial class CustomerItem
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
            this.CustomerNameLB = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.EditBT = new System.Windows.Forms.PictureBox();
            this.DeleteBT = new System.Windows.Forms.PictureBox();
            this.Splitter = new System.Windows.Forms.Splitter();
            this.CustomerIcon = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerNameLB
            // 
            this.CustomerNameLB.AutoSize = true;
            this.CustomerNameLB.Location = new System.Drawing.Point(52, 14);
            this.CustomerNameLB.Name = "CustomerNameLB";
            this.CustomerNameLB.Size = new System.Drawing.Size(257, 13);
            this.CustomerNameLB.TabIndex = 0;
            this.CustomerNameLB.Text = "${CUSTOMER_NAME}/${CUSTOMER_ADDRESS}";
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.CustomerIcon);
            this.MainPanel.Controls.Add(this.EditBT);
            this.MainPanel.Controls.Add(this.DeleteBT);
            this.MainPanel.Controls.Add(this.Splitter);
            this.MainPanel.Controls.Add(this.CustomerNameLB);
            this.MainPanel.Location = new System.Drawing.Point(64, 216);
            this.MainPanel.MinimumSize = new System.Drawing.Size(674, 40);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(674, 40);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.MouseEnter += new System.EventHandler(this.MainPanelEnter);
            this.MainPanel.MouseLeave += new System.EventHandler(this.MainPanelLeave);
            // 
            // EditBT
            // 
            this.EditBT.Location = new System.Drawing.Point(602, 10);
            this.EditBT.Name = "EditBT";
            this.EditBT.Size = new System.Drawing.Size(20, 20);
            this.EditBT.TabIndex = 8;
            this.EditBT.TabStop = false;
            this.EditBT.Click += new System.EventHandler(this.UpdateItem);
            // 
            // DeleteBT
            // 
            this.DeleteBT.Location = new System.Drawing.Point(637, 11);
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(20, 20);
            this.DeleteBT.TabIndex = 7;
            this.DeleteBT.TabStop = false;
            this.DeleteBT.Click += new System.EventHandler(this.DeleteItem);
            // 
            // Splitter
            // 
            this.Splitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(200)))), ((int)(((byte)(227)))));
            this.Splitter.Location = new System.Drawing.Point(0, 0);
            this.Splitter.Name = "Splitter";
            this.Splitter.Size = new System.Drawing.Size(6, 40);
            this.Splitter.TabIndex = 6;
            this.Splitter.TabStop = false;
            // 
            // CustomerIcon
            // 
            this.CustomerIcon.Location = new System.Drawing.Point(17, 11);
            this.CustomerIcon.Name = "CustomerIcon";
            this.CustomerIcon.Size = new System.Drawing.Size(20, 20);
            this.CustomerIcon.TabIndex = 10;
            this.CustomerIcon.TabStop = false;
            // 
            // CustomerItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Name = "CustomerItem";
            this.Text = "Form1";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label CustomerNameLB;
        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Splitter Splitter;
        private System.Windows.Forms.PictureBox EditBT;
        private System.Windows.Forms.PictureBox DeleteBT;
        private System.Windows.Forms.PictureBox CustomerIcon;
    }
}