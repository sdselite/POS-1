﻿namespace POS.UserInterfaceLayer.Transfer
{
    partial class FrmTransferOrderSearch
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
            this.cbx_StoreTo = new System.Windows.Forms.ComboBox();
            this.cbx_StoreFrom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panl_Header.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cbx_StoreTo);
            this.groupBox2.Controls.Add(this.cbx_StoreFrom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            // 
            // cbx_StoreTo
            // 
            this.cbx_StoreTo.FormattingEnabled = true;
            this.cbx_StoreTo.Location = new System.Drawing.Point(349, 13);
            this.cbx_StoreTo.Name = "cbx_StoreTo";
            this.cbx_StoreTo.Size = new System.Drawing.Size(241, 24);
            this.cbx_StoreTo.TabIndex = 13;
            // 
            // cbx_StoreFrom
            // 
            this.cbx_StoreFrom.FormattingEnabled = true;
            this.cbx_StoreFrom.Location = new System.Drawing.Point(349, 41);
            this.cbx_StoreFrom.Name = "cbx_StoreFrom";
            this.cbx_StoreFrom.Size = new System.Drawing.Size(241, 24);
            this.cbx_StoreFrom.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "المخزن المحول منه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "المخزن المحول اليه";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "إلغاء البحث";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmTransferOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(698, 403);
            this.Name = "FrmTransferOrderSearch";
            this.panl_Header.ResumeLayout(false);
            this.panl_Header.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbx_StoreTo;
        private System.Windows.Forms.ComboBox cbx_StoreFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;

    }
}
