
namespace Restaurant.App
{
    partial class NewCustomer
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
            this.CustomerLayoutView = new System.Windows.Forms.Panel();
            this.BackBT = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FirstnameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.LastnameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.CustomerLayoutView.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerLayoutView
            // 
            this.CustomerLayoutView.Controls.Add(this.BackBT);
            this.CustomerLayoutView.Controls.Add(this.flowLayoutPanel1);
            this.CustomerLayoutView.Controls.Add(this.flowLayoutPanel2);
            this.CustomerLayoutView.Controls.Add(this.flowLayoutPanel3);
            this.CustomerLayoutView.Controls.Add(this.ErrorMessageLabel);
            this.CustomerLayoutView.Controls.Add(this.SaveBTN);
            this.CustomerLayoutView.Location = new System.Drawing.Point(12, 12);
            this.CustomerLayoutView.Name = "CustomerLayoutView";
            this.CustomerLayoutView.Size = new System.Drawing.Size(674, 450);
            this.CustomerLayoutView.TabIndex = 0;
            // 
            // BackBT
            // 
            this.BackBT.Location = new System.Drawing.Point(0, 0);
            this.BackBT.Name = "BackBT";
            this.BackBT.Size = new System.Drawing.Size(103, 50);
            this.BackBT.TabIndex = 12;
            this.BackBT.Text = "Back";
            this.BackBT.UseVisualStyleBackColor = true;
            this.BackBT.Click += new System.EventHandler(this.GoBack);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.FirstnameTB);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(175, 118);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(334, 24);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // FirstnameTB
            // 
            this.FirstnameTB.Location = new System.Drawing.Point(3, 3);
            this.FirstnameTB.Name = "FirstnameTB";
            this.FirstnameTB.Size = new System.Drawing.Size(258, 20);
            this.FirstnameTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Firstname";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.LastnameTB);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(175, 148);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(334, 23);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // LastnameTB
            // 
            this.LastnameTB.Location = new System.Drawing.Point(3, 3);
            this.LastnameTB.Name = "LastnameTB";
            this.LastnameTB.Size = new System.Drawing.Size(258, 20);
            this.LastnameTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "*Lastname";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.AddressTB);
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(175, 177);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(334, 23);
            this.flowLayoutPanel3.TabIndex = 10;
            // 
            // AddressTB
            // 
            this.AddressTB.Location = new System.Drawing.Point(3, 3);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(258, 20);
            this.AddressTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "*Address";
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
            this.SaveBTN.Click += new System.EventHandler(this.SaveCustomerBTN);
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.CustomerLayoutView);
            this.Name = "NewCustomer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NewCustomer_Load);
            this.CustomerLayoutView.ResumeLayout(false);
            this.CustomerLayoutView.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox FirstnameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox LastnameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Button BackBT;
        public System.Windows.Forms.Panel CustomerLayoutView;
    }
}