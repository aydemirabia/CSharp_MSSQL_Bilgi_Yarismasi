
namespace BilgiYarismasi
{
    partial class FrmSoruEkrani
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
            this.txtSoruEkrani = new System.Windows.Forms.TextBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSoru = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSoruEkrani
            // 
            this.txtSoruEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoruEkrani.Location = new System.Drawing.Point(12, 12);
            this.txtSoruEkrani.Multiline = true;
            this.txtSoruEkrani.Name = "txtSoruEkrani";
            this.txtSoruEkrani.Size = new System.Drawing.Size(488, 262);
            this.txtSoruEkrani.TabIndex = 0;
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnA.Location = new System.Drawing.Point(12, 280);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(236, 60);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnB.Location = new System.Drawing.Point(264, 280);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(236, 60);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnD.Location = new System.Drawing.Point(264, 346);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(236, 60);
            this.btnD.TabIndex = 3;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC.Location = new System.Drawing.Point(12, 346);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(236, 60);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.Location = new System.Drawing.Point(533, 12);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(241, 54);
            this.btnBasla.TabIndex = 5;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(541, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "PUAN: ";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.ForeColor = System.Drawing.Color.White;
            this.lblPuan.Location = new System.Drawing.Point(650, 106);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(24, 25);
            this.lblPuan.TabIndex = 7;
            this.lblPuan.Text = "0";
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogru.ForeColor = System.Drawing.Color.White;
            this.lblDogru.Location = new System.Drawing.Point(650, 221);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(36, 25);
            this.lblDogru.TabIndex = 9;
            this.lblDogru.Text = "__";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(528, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "CEVAP: ";
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoru.ForeColor = System.Drawing.Color.White;
            this.lblSoru.Location = new System.Drawing.Point(650, 161);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(36, 25);
            this.lblSoru.TabIndex = 11;
            this.lblSoru.Text = "__";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(528, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "SORU: ";
            // 
            // FrmSoruEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 517);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.txtSoruEkrani);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSoruEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmSoruEkrani";
            this.Load += new System.EventHandler(this.FrmSoruEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoruEkrani;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.Label label3;
    }
}