
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
            this.FunctionsView = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OrderMenuBar = new System.Windows.Forms.Panel();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.OrderSplitter = new System.Windows.Forms.Splitter();
            this.ProductMenuBar = new System.Windows.Forms.Panel();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.ProductSplitter = new System.Windows.Forms.Splitter();
            this.CustomerMenuBar = new System.Windows.Forms.Panel();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.CustomerSplitter = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AppTitleLabel = new System.Windows.Forms.Label();
            this.AppDescriptionLabel = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.HeaderIcon = new System.Windows.Forms.PictureBox();
            this.IconLarge = new System.Windows.Forms.PictureBox();
            this.FunctionsView.SuspendLayout();
            this.panel1.SuspendLayout();
            this.OrderMenuBar.SuspendLayout();
            this.ProductMenuBar.SuspendLayout();
            this.CustomerMenuBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconLarge)).BeginInit();
            this.SuspendLayout();
            // 
            // FunctionsView
            // 
            this.FunctionsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FunctionsView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.FunctionsView.Controls.Add(this.panel2);
            this.FunctionsView.Location = new System.Drawing.Point(123, 0);
            this.FunctionsView.Name = "FunctionsView";
            this.FunctionsView.Size = new System.Drawing.Size(696, 450);
            this.FunctionsView.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.OrderMenuBar);
            this.panel1.Controls.Add(this.ProductMenuBar);
            this.panel1.Controls.Add(this.CustomerMenuBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 450);
            this.panel1.TabIndex = 2;
            // 
            // OrderMenuBar
            // 
            this.OrderMenuBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderMenuBar.Controls.Add(this.label1);
            this.OrderMenuBar.Controls.Add(this.OrderLabel);
            this.OrderMenuBar.Controls.Add(this.OrderSplitter);
            this.OrderMenuBar.Location = new System.Drawing.Point(0, 197);
            this.OrderMenuBar.Name = "OrderMenuBar";
            this.OrderMenuBar.Size = new System.Drawing.Size(119, 43);
            this.OrderMenuBar.TabIndex = 1;
            this.OrderMenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OrderBTNClick);
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.OrderLabel.Location = new System.Drawing.Point(32, 15);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(33, 13);
            this.OrderLabel.TabIndex = 2;
            this.OrderLabel.Text = "Order";
            // 
            // OrderSplitter
            // 
            this.OrderSplitter.BackColor = System.Drawing.Color.White;
            this.OrderSplitter.Location = new System.Drawing.Point(0, 0);
            this.OrderSplitter.Name = "OrderSplitter";
            this.OrderSplitter.Size = new System.Drawing.Size(4, 43);
            this.OrderSplitter.TabIndex = 1;
            this.OrderSplitter.TabStop = false;
            // 
            // ProductMenuBar
            // 
            this.ProductMenuBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductMenuBar.Controls.Add(this.ProductLabel);
            this.ProductMenuBar.Controls.Add(this.ProductSplitter);
            this.ProductMenuBar.Location = new System.Drawing.Point(0, 151);
            this.ProductMenuBar.Name = "ProductMenuBar";
            this.ProductMenuBar.Size = new System.Drawing.Size(120, 43);
            this.ProductMenuBar.TabIndex = 1;
            this.ProductMenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProductBTNClick);
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ProductLabel.Location = new System.Drawing.Point(32, 15);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(44, 13);
            this.ProductLabel.TabIndex = 2;
            this.ProductLabel.Text = "Product";
            // 
            // ProductSplitter
            // 
            this.ProductSplitter.BackColor = System.Drawing.Color.White;
            this.ProductSplitter.Location = new System.Drawing.Point(0, 0);
            this.ProductSplitter.Name = "ProductSplitter";
            this.ProductSplitter.Size = new System.Drawing.Size(4, 43);
            this.ProductSplitter.TabIndex = 1;
            this.ProductSplitter.TabStop = false;
            // 
            // CustomerMenuBar
            // 
            this.CustomerMenuBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerMenuBar.Controls.Add(this.CustomerLabel);
            this.CustomerMenuBar.Controls.Add(this.CustomerSplitter);
            this.CustomerMenuBar.Location = new System.Drawing.Point(0, 105);
            this.CustomerMenuBar.Name = "CustomerMenuBar";
            this.CustomerMenuBar.Size = new System.Drawing.Size(120, 43);
            this.CustomerMenuBar.TabIndex = 0;
            this.CustomerMenuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CustomerBTNClick);
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.CustomerLabel.Location = new System.Drawing.Point(32, 16);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(51, 13);
            this.CustomerLabel.TabIndex = 1;
            this.CustomerLabel.Text = "Customer";
            // 
            // CustomerSplitter
            // 
            this.CustomerSplitter.BackColor = System.Drawing.Color.White;
            this.CustomerSplitter.Location = new System.Drawing.Point(0, 0);
            this.CustomerSplitter.Name = "CustomerSplitter";
            this.CustomerSplitter.Size = new System.Drawing.Size(4, 43);
            this.CustomerSplitter.TabIndex = 0;
            this.CustomerSplitter.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.IconLarge);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.AppDescriptionLabel);
            this.panel2.Controls.Add(this.AppTitleLabel);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 447);
            this.panel2.TabIndex = 0;
            // 
            // AppTitleLabel
            // 
            this.AppTitleLabel.AutoSize = true;
            this.AppTitleLabel.Location = new System.Drawing.Point(19, 16);
            this.AppTitleLabel.Name = "AppTitleLabel";
            this.AppTitleLabel.Size = new System.Drawing.Size(125, 13);
            this.AppTitleLabel.TabIndex = 0;
            this.AppTitleLabel.Text = "ADONIS RESTAURANT";
            // 
            // AppDescriptionLabel
            // 
            this.AppDescriptionLabel.AutoSize = true;
            this.AppDescriptionLabel.Location = new System.Drawing.Point(23, 48);
            this.AppDescriptionLabel.Name = "AppDescriptionLabel";
            this.AppDescriptionLabel.Size = new System.Drawing.Size(121, 13);
            this.AppDescriptionLabel.TabIndex = 1;
            this.AppDescriptionLabel.Text = "${APP_DESCRIPTION}";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 447);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.HeaderIcon);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 100);
            this.panel3.TabIndex = 2;
            // 
            // HeaderIcon
            // 
            this.HeaderIcon.Location = new System.Drawing.Point(29, 19);
            this.HeaderIcon.Name = "HeaderIcon";
            this.HeaderIcon.Size = new System.Drawing.Size(60, 60);
            this.HeaderIcon.TabIndex = 0;
            this.HeaderIcon.TabStop = false;
            // 
            // IconLarge
            // 
            this.IconLarge.Location = new System.Drawing.Point(202, 83);
            this.IconLarge.Name = "IconLarge";
            this.IconLarge.Size = new System.Drawing.Size(300, 300);
            this.IconLarge.TabIndex = 3;
            this.IconLarge.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FunctionsView);
            this.Name = "Main";
            this.Text = "ADONIS RESTAURANT";
            this.FunctionsView.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.OrderMenuBar.ResumeLayout(false);
            this.OrderMenuBar.PerformLayout();
            this.ProductMenuBar.ResumeLayout(false);
            this.ProductMenuBar.PerformLayout();
            this.CustomerMenuBar.ResumeLayout(false);
            this.CustomerMenuBar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HeaderIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconLarge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel FunctionsView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel OrderMenuBar;
        private System.Windows.Forms.Panel ProductMenuBar;
        private System.Windows.Forms.Panel CustomerMenuBar;
        private System.Windows.Forms.Splitter OrderSplitter;
        private System.Windows.Forms.Splitter ProductSplitter;
        private System.Windows.Forms.Splitter CustomerSplitter;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AppTitleLabel;
        private System.Windows.Forms.Label AppDescriptionLabel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox HeaderIcon;
        private System.Windows.Forms.PictureBox IconLarge;
    }
}

