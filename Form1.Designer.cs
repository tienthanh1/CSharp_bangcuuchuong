﻿namespace CSharp_bangcuuchuong
{
    partial class Form1
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
            this.lblbangcuuchuong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnxem = new System.Windows.Forms.Button();
            this.lbsketqua = new System.Windows.Forms.ListBox();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblbangcuuchuong
            // 
            this.lblbangcuuchuong.AutoSize = true;
            this.lblbangcuuchuong.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbangcuuchuong.Location = new System.Drawing.Point(203, 47);
            this.lblbangcuuchuong.Name = "lblbangcuuchuong";
            this.lblbangcuuchuong.Size = new System.Drawing.Size(398, 46);
            this.lblbangcuuchuong.TabIndex = 0;
            this.lblbangcuuchuong.Text = "BẢNG CỬU CHƯƠNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(572, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bạn muốn thể hiện bảng cửu chương mấy ?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnxem
            // 
            this.btnxem.Location = new System.Drawing.Point(515, 180);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(170, 56);
            this.btnxem.TabIndex = 4;
            this.btnxem.Text = "Xem";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbsketqua
            // 
            this.lbsketqua.FormattingEnabled = true;
            this.lbsketqua.Location = new System.Drawing.Point(89, 270);
            this.lbsketqua.Name = "lbsketqua";
            this.lbsketqua.Size = new System.Drawing.Size(596, 147);
            this.lbsketqua.TabIndex = 5;
            this.lbsketqua.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtSo
            // 
            this.txtSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSo.Location = new System.Drawing.Point(89, 180);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(338, 49);
            this.txtSo.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.lbsketqua);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblbangcuuchuong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbangcuuchuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.ListBox lbsketqua;
        private System.Windows.Forms.TextBox txtSo;
    }
}

