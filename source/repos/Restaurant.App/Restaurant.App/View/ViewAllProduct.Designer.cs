
namespace Restaurant.App.View
{
    partial class ViewAllProduct
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
            this.ProductViewLayout = new System.Windows.Forms.TableLayoutPanel();
            this.layout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddProductBT = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FilterProductNameTB = new Restaurant.App.CustomSkin.BottomBorderTextBox();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.ProductViewLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductBT)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductViewLayout
            // 
            this.ProductViewLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ProductViewLayout.ColumnCount = 1;
            this.ProductViewLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ProductViewLayout.Controls.Add(this.layout, 0, 2);
            this.ProductViewLayout.Controls.Add(this.panel1, 0, 0);
            this.ProductViewLayout.Controls.Add(this.panel2, 0, 1);
            this.ProductViewLayout.Location = new System.Drawing.Point(54, 0);
            this.ProductViewLayout.MinimumSize = new System.Drawing.Size(674, 450);
            this.ProductViewLayout.Name = "ProductViewLayout";
            this.ProductViewLayout.RowCount = 3;
            this.ProductViewLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ProductViewLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ProductViewLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.ProductViewLayout.Size = new System.Drawing.Size(692, 450);
            this.ProductViewLayout.TabIndex = 1;
            // 
            // layout
            // 
            this.layout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layout.AutoScroll = true;
            this.layout.BackColor = System.Drawing.Color.Transparent;
            this.layout.Location = new System.Drawing.Point(3, 93);
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(686, 354);
            this.layout.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.AddProductBT);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 39);
            this.panel1.TabIndex = 2;
            // 
            // AddProductBT
            // 
            this.AddProductBT.Location = new System.Drawing.Point(645, 5);
            this.AddProductBT.Name = "AddProductBT";
            this.AddProductBT.Size = new System.Drawing.Size(30, 30);
            this.AddProductBT.TabIndex = 4;
            this.AddProductBT.TabStop = false;
            this.AddProductBT.Click += new System.EventHandler(this.NewProductBTN);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.FilterProductNameTB);
            this.panel2.Controls.Add(this.SearchIcon);
            this.panel2.Location = new System.Drawing.Point(3, 48);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(686, 39);
            this.panel2.TabIndex = 3;
            // 
            // FilterProductNameTB
            // 
            this.FilterProductNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilterProductNameTB.Location = new System.Drawing.Point(479, 12);
            this.FilterProductNameTB.Name = "FilterProductNameTB";
            this.FilterProductNameTB.Size = new System.Drawing.Size(196, 20);
            this.FilterProductNameTB.TabIndex = 11;
            this.FilterProductNameTB.TextChanged += new System.EventHandler(this.FilterProduct);
            // 
            // SearchIcon
            // 
            this.SearchIcon.Location = new System.Drawing.Point(449, 12);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(20, 20);
            this.SearchIcon.TabIndex = 10;
            this.SearchIcon.TabStop = false;
            // 
            // ViewAllProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProductViewLayout);
            this.Name = "ViewAllProduct";
            this.Text = "Form1";
            this.ProductViewLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddProductBT)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel ProductViewLayout;
        public System.Windows.Forms.FlowLayoutPanel layout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox SearchIcon;
        private System.Windows.Forms.PictureBox AddProductBT;
        private CustomSkin.BottomBorderTextBox FilterProductNameTB;
    }
}