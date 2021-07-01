
namespace Restaurant.App.View
{
    partial class NewAndUpdateProduct
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
            this.NewProductLayoutView = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.QuantityTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.BackBT = new System.Windows.Forms.PictureBox();
            this.NewProductLayoutView.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackBT)).BeginInit();
            this.SuspendLayout();
            // 
            // NewProductLayoutView
            // 
            this.NewProductLayoutView.BackColor = System.Drawing.Color.Transparent;
            this.NewProductLayoutView.Controls.Add(this.BackBT);
            this.NewProductLayoutView.Controls.Add(this.flowLayoutPanel1);
            this.NewProductLayoutView.Controls.Add(this.flowLayoutPanel2);
            this.NewProductLayoutView.Controls.Add(this.flowLayoutPanel3);
            this.NewProductLayoutView.Controls.Add(this.ErrorMessageLabel);
            this.NewProductLayoutView.Controls.Add(this.SaveBTN);
            this.NewProductLayoutView.Location = new System.Drawing.Point(63, 0);
            this.NewProductLayoutView.Name = "NewProductLayoutView";
            this.NewProductLayoutView.Size = new System.Drawing.Size(674, 450);
            this.NewProductLayoutView.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.NameTB);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(175, 118);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(359, 24);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(3, 3);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(258, 20);
            this.NameTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Product Name";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.QuantityTB);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(175, 148);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(359, 23);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // QuantityTB
            // 
            this.QuantityTB.Location = new System.Drawing.Point(3, 3);
            this.QuantityTB.Name = "QuantityTB";
            this.QuantityTB.Size = new System.Drawing.Size(258, 20);
            this.QuantityTB.TabIndex = 2;
            this.QuantityTB.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "*Quantity";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.PriceTB);
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(175, 177);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(334, 23);
            this.flowLayoutPanel3.TabIndex = 10;
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(3, 3);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(258, 20);
            this.PriceTB.TabIndex = 3;
            this.PriceTB.Text = "0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "*Price";
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(175, 203);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Padding = new System.Windows.Forms.Padding(40, 10, 0, 0);
            this.ErrorMessageLabel.Size = new System.Drawing.Size(80, 30);
            this.ErrorMessageLabel.TabIndex = 11;
            this.ErrorMessageLabel.Text = "label4";
            // 
            // SaveBTN
            // 
            this.SaveBTN.Location = new System.Drawing.Point(175, 243);
            this.SaveBTN.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(334, 42);
            this.SaveBTN.TabIndex = 7;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveProduct);
            // 
            // BackBT
            // 
            this.BackBT.Location = new System.Drawing.Point(13, 3);
            this.BackBT.Name = "BackBT";
            this.BackBT.Size = new System.Drawing.Size(50, 50);
            this.BackBT.TabIndex = 13;
            this.BackBT.TabStop = false;
            this.BackBT.Click += new System.EventHandler(this.GoBack);
            // 
            // NewAndUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewProductLayoutView);
            this.Name = "NewAndUpdateProduct";
            this.Text = "NewAndUpdateProduct";
            this.NewProductLayoutView.ResumeLayout(false);
            this.NewProductLayoutView.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackBT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel NewProductLayoutView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox QuantityTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.PictureBox BackBT;
    }
}