namespace ThapHaNoifinal
{
    partial class formTHNf
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
            this.cboSodia = new System.Windows.Forms.ComboBox();
            this.lblCocNguon = new System.Windows.Forms.Label();
            this.lblCocTrungGian = new System.Windows.Forms.Label();
            this.lblCocDich = new System.Windows.Forms.Label();
            this.lblLoigiai = new System.Windows.Forms.Label();
            this.lblChonsodia = new System.Windows.Forms.Label();
            this.lblSobuoc = new System.Windows.Forms.Label();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnGiailai = new System.Windows.Forms.Button();
            this.txtLoigiai = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboSodia
            // 
            this.cboSodia.FormattingEnabled = true;
            this.cboSodia.Location = new System.Drawing.Point(528, 40);
            this.cboSodia.Name = "cboSodia";
            this.cboSodia.Size = new System.Drawing.Size(121, 24);
            this.cboSodia.TabIndex = 1;
            this.cboSodia.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblCocNguon
            // 
            this.lblCocNguon.AutoSize = true;
            this.lblCocNguon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCocNguon.Location = new System.Drawing.Point(225, 496);
            this.lblCocNguon.Name = "lblCocNguon";
            this.lblCocNguon.Size = new System.Drawing.Size(76, 18);
            this.lblCocNguon.TabIndex = 2;
            this.lblCocNguon.Text = "Cọc Nguồn";
            // 
            // lblCocTrungGian
            // 
            this.lblCocTrungGian.AutoSize = true;
            this.lblCocTrungGian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCocTrungGian.Location = new System.Drawing.Point(618, 496);
            this.lblCocTrungGian.Name = "lblCocTrungGian";
            this.lblCocTrungGian.Size = new System.Drawing.Size(102, 18);
            this.lblCocTrungGian.TabIndex = 2;
            this.lblCocTrungGian.Text = "Cọc Trung Gian";
            // 
            // lblCocDich
            // 
            this.lblCocDich.AutoSize = true;
            this.lblCocDich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCocDich.Location = new System.Drawing.Point(1032, 496);
            this.lblCocDich.Name = "lblCocDich";
            this.lblCocDich.Size = new System.Drawing.Size(62, 18);
            this.lblCocDich.TabIndex = 2;
            this.lblCocDich.Text = "Cọc Đích";
            // 
            // lblLoigiai
            // 
            this.lblLoigiai.AutoSize = true;
            this.lblLoigiai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLoigiai.Location = new System.Drawing.Point(1200, 26);
            this.lblLoigiai.Name = "lblLoigiai";
            this.lblLoigiai.Size = new System.Drawing.Size(55, 18);
            this.lblLoigiai.TabIndex = 2;
            this.lblLoigiai.Text = "Lời giải:";
            // 
            // lblChonsodia
            // 
            this.lblChonsodia.AutoSize = true;
            this.lblChonsodia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChonsodia.Location = new System.Drawing.Point(528, 19);
            this.lblChonsodia.Name = "lblChonsodia";
            this.lblChonsodia.Size = new System.Drawing.Size(82, 18);
            this.lblChonsodia.TabIndex = 2;
            this.lblChonsodia.Text = "Chọn số đĩa";
            // 
            // lblSobuoc
            // 
            this.lblSobuoc.AutoSize = true;
            this.lblSobuoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSobuoc.Location = new System.Drawing.Point(1200, 302);
            this.lblSobuoc.Name = "lblSobuoc";
            this.lblSobuoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSobuoc.Size = new System.Drawing.Size(62, 18);
            this.lblSobuoc.TabIndex = 2;
            this.lblSobuoc.Text = "Số bước:";
            // 
            // btnGiai
            // 
            this.btnGiai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiai.Location = new System.Drawing.Point(55, 40);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(80, 30);
            this.btnGiai.TabIndex = 3;
            this.btnGiai.Text = "Giải";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btnGiailai
            // 
            this.btnGiailai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiailai.Location = new System.Drawing.Point(206, 40);
            this.btnGiailai.Name = "btnGiailai";
            this.btnGiailai.Size = new System.Drawing.Size(80, 30);
            this.btnGiailai.TabIndex = 3;
            this.btnGiailai.Text = "Giải lại";
            this.btnGiailai.UseVisualStyleBackColor = true;
            this.btnGiailai.Click += new System.EventHandler(this.btnGiailai_Click);
            // 
            // txtLoigiai
            // 
            this.txtLoigiai.Location = new System.Drawing.Point(1200, 47);
            this.txtLoigiai.Multiline = true;
            this.txtLoigiai.Name = "txtLoigiai";
            this.txtLoigiai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLoigiai.Size = new System.Drawing.Size(260, 252);
            this.txtLoigiai.TabIndex = 4;
            // 
            // formTHNf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 653);
            this.Controls.Add(this.txtLoigiai);
            this.Controls.Add(this.btnGiailai);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.lblSobuoc);
            this.Controls.Add(this.lblLoigiai);
            this.Controls.Add(this.lblChonsodia);
            this.Controls.Add(this.lblCocDich);
            this.Controls.Add(this.lblCocTrungGian);
            this.Controls.Add(this.lblCocNguon);
            this.Controls.Add(this.cboSodia);
            this.Name = "formTHNf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formTHNf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSodia;
        private System.Windows.Forms.Label lblCocNguon;
        private System.Windows.Forms.Label lblCocTrungGian;
        private System.Windows.Forms.Label lblCocDich;
        private System.Windows.Forms.Label lblLoigiai;
        private System.Windows.Forms.Label lblChonsodia;
        private System.Windows.Forms.Label lblSobuoc;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btnGiailai;
        private System.Windows.Forms.TextBox txtLoigiai;
    }
}

