﻿namespace HA.Setup
{
    partial class CreateDataBaseXml
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
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDataBaseName = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btncCreate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataBaseFilePath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(195, 12);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(247, 21);
            this.txtLoginName.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(195, 45);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(247, 21);
            this.txtPassword.TabIndex = 1;
            // 
            // txtDataBaseName
            // 
            this.txtDataBaseName.Enabled = false;
            this.txtDataBaseName.Location = new System.Drawing.Point(195, 125);
            this.txtDataBaseName.Name = "txtDataBaseName";
            this.txtDataBaseName.Size = new System.Drawing.Size(247, 21);
            this.txtDataBaseName.TabIndex = 2;
            this.txtDataBaseName.Text = "PMS_Wedding";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(195, 82);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(247, 21);
            this.txtPath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "数据库名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "数据库用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "数据库密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "数据库服务地址(仅支持本地地址)";
            // 
            // btncCreate
            // 
            this.btncCreate.Location = new System.Drawing.Point(195, 205);
            this.btncCreate.Name = "btncCreate";
            this.btncCreate.Size = new System.Drawing.Size(75, 23);
            this.btncCreate.TabIndex = 8;
            this.btncCreate.Text = "下一步";
            this.btncCreate.UseVisualStyleBackColor = true;
            this.btncCreate.Click += new System.EventHandler(this.btncCreate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "数据库物理路径";
            this.label5.Visible = false;
            // 
            // txtDataBaseFilePath
            // 
            this.txtDataBaseFilePath.Location = new System.Drawing.Point(195, 169);
            this.txtDataBaseFilePath.Name = "txtDataBaseFilePath";
            this.txtDataBaseFilePath.Size = new System.Drawing.Size(247, 21);
            this.txtDataBaseFilePath.TabIndex = 10;
            this.txtDataBaseFilePath.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = ". . .";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateDataBaseXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDataBaseFilePath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncCreate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtDataBaseName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLoginName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateDataBaseXml";
            this.Text = "配置数据库";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtDataBaseName;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDataBaseFilePath;
        private System.Windows.Forms.Button button1;
    }
}