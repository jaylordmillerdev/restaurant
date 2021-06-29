
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
            this.panel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerNameLB
            // 
            this.CustomerNameLB.AutoSize = true;
            this.CustomerNameLB.Location = new System.Drawing.Point(27, 14);
            this.CustomerNameLB.Name = "CustomerNameLB";
            this.CustomerNameLB.Size = new System.Drawing.Size(119, 13);
            this.CustomerNameLB.TabIndex = 0;
            this.CustomerNameLB.Text = "${CUSTOMER_NAME}";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.button2);
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.CustomerNameLB);
            this.panel.Location = new System.Drawing.Point(64, 216);
            this.panel.MinimumSize = new System.Drawing.Size(674, 40);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(674, 40);
            this.panel.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(502, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.UpdateItem);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DeleteItem);
            // 
            // CustomerItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Name = "CustomerItem";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label CustomerNameLB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel panel;
    }
}