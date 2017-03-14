namespace LuckyNumbersCs
{
    partial class frmLuckyNumbers
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
            this.lblFrNm = new System.Windows.Forms.Label();
            this.txtbFrNm = new System.Windows.Forms.TextBox();
            this.lblLstNm = new System.Windows.Forms.Label();
            this.txtbLstNm = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblOUT = new System.Windows.Forms.Label();
            this.lblBY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFrNm
            // 
            this.lblFrNm.AutoSize = true;
            this.lblFrNm.Location = new System.Drawing.Point(13, 13);
            this.lblFrNm.Name = "lblFrNm";
            this.lblFrNm.Size = new System.Drawing.Size(184, 17);
            this.lblFrNm.TabIndex = 0;
            this.lblFrNm.Text = "Enter your first name below:";
            // 
            // txtbFrNm
            // 
            this.txtbFrNm.Location = new System.Drawing.Point(13, 34);
            this.txtbFrNm.Name = "txtbFrNm";
            this.txtbFrNm.Size = new System.Drawing.Size(257, 22);
            this.txtbFrNm.TabIndex = 1;
            // 
            // lblLstNm
            // 
            this.lblLstNm.AutoSize = true;
            this.lblLstNm.Location = new System.Drawing.Point(13, 63);
            this.lblLstNm.Name = "lblLstNm";
            this.lblLstNm.Size = new System.Drawing.Size(183, 17);
            this.lblLstNm.TabIndex = 2;
            this.lblLstNm.Text = "Enter your last name below:";
            // 
            // txtbLstNm
            // 
            this.txtbLstNm.Location = new System.Drawing.Point(13, 84);
            this.txtbLstNm.Name = "txtbLstNm";
            this.txtbLstNm.Size = new System.Drawing.Size(257, 22);
            this.txtbLstNm.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(13, 112);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblOUT
            // 
            this.lblOUT.AutoSize = true;
            this.lblOUT.Location = new System.Drawing.Point(13, 152);
            this.lblOUT.Name = "lblOUT";
            this.lblOUT.Size = new System.Drawing.Size(0, 17);
            this.lblOUT.TabIndex = 5;
            // 
            // lblBY
            // 
            this.lblBY.AutoSize = true;
            this.lblBY.Location = new System.Drawing.Point(425, 187);
            this.lblBY.Name = "lblBY";
            this.lblBY.Size = new System.Drawing.Size(141, 17);
            this.lblBY.TabIndex = 6;
            this.lblBY.Text = "By Adam Myczkowski";
            // 
            // frmLuckyNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 213);
            this.Controls.Add(this.lblBY);
            this.Controls.Add(this.lblOUT);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtbLstNm);
            this.Controls.Add(this.lblLstNm);
            this.Controls.Add(this.txtbFrNm);
            this.Controls.Add(this.lblFrNm);
            this.MaximizeBox = false;
            this.Name = "frmLuckyNumbers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucky Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrNm;
        private System.Windows.Forms.TextBox txtbFrNm;
        private System.Windows.Forms.Label lblLstNm;
        private System.Windows.Forms.TextBox txtbLstNm;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblOUT;
        private System.Windows.Forms.Label lblBY;
    }
}