
namespace Restaurant.App
{
    partial class Main
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CustomerBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.FunctionsView = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flowLayoutPanel1.Controls.Add(this.CustomerBTN);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(126, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // CustomerBTN
            // 
            this.CustomerBTN.Location = new System.Drawing.Point(3, 3);
            this.CustomerBTN.Name = "CustomerBTN";
            this.CustomerBTN.Size = new System.Drawing.Size(119, 65);
            this.CustomerBTN.TabIndex = 0;
            this.CustomerBTN.Text = "Customer";
            this.CustomerBTN.UseVisualStyleBackColor = true;
            this.CustomerBTN.Click += new System.EventHandler(this.CustomerBTNClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Product";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ProductBTNClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "Order";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OrderBTNClick);
            // 
            // FunctionsView
            // 
            this.FunctionsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FunctionsView.BackColor = System.Drawing.Color.White;
            this.FunctionsView.Location = new System.Drawing.Point(126, 0);
            this.FunctionsView.Name = "FunctionsView";
            this.FunctionsView.Size = new System.Drawing.Size(674, 450);
            this.FunctionsView.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FunctionsView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Main";
            this.Text = "Simple Restaurant";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button CustomerBTN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel FunctionsView;
    }
}

