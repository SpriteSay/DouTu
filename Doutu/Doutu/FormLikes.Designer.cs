﻿namespace Doutu
{
    partial class FormLikes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.export = new System.Windows.Forms.Button();
            this.manage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(599, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(640, 335);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(130, 50);
            this.export.TabIndex = 2;
            this.export.Text = "批量导出";
            this.export.UseVisualStyleBackColor = true;
            // 
            // manage
            // 
            this.manage.Location = new System.Drawing.Point(640, 264);
            this.manage.Name = "manage";
            this.manage.Size = new System.Drawing.Size(130, 50);
            this.manage.TabIndex = 3;
            this.manage.Text = "表情管理";
            this.manage.UseVisualStyleBackColor = true;
            this.manage.Click += new System.EventHandler(this.manage_Click);
            // 
            // FormLikes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.manage);
            this.Controls.Add(this.export);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormLikes";
            this.Text = "我的收藏";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button manage;
    }
}