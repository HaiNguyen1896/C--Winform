namespace AutoCreate
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
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnSltPath = new System.Windows.Forms.Button();
            this.btnCrtFolder = new System.Windows.Forms.Button();
            this.txtCrtFolder = new System.Windows.Forms.TextBox();
            this.txtCrtText = new System.Windows.Forms.TextBox();
            this.btnCrtText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(124, 132);
            this.txtFolder.Multiline = true;
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(317, 39);
            this.txtFolder.TabIndex = 0;
            // 
            // btnSltPath
            // 
            this.btnSltPath.Location = new System.Drawing.Point(473, 132);
            this.btnSltPath.Name = "btnSltPath";
            this.btnSltPath.Size = new System.Drawing.Size(127, 39);
            this.btnSltPath.TabIndex = 1;
            this.btnSltPath.Text = "Select Path";
            this.btnSltPath.UseVisualStyleBackColor = true;
            this.btnSltPath.Click += new System.EventHandler(this.btnSltPath_Click);
            // 
            // btnCrtFolder
            // 
            this.btnCrtFolder.Location = new System.Drawing.Point(124, 229);
            this.btnCrtFolder.Name = "btnCrtFolder";
            this.btnCrtFolder.Size = new System.Drawing.Size(127, 39);
            this.btnCrtFolder.TabIndex = 2;
            this.btnCrtFolder.Text = "Create Folder";
            this.btnCrtFolder.UseVisualStyleBackColor = true;
            this.btnCrtFolder.Click += new System.EventHandler(this.btnCrtFolder_Click);
            // 
            // txtCrtFolder
            // 
            this.txtCrtFolder.Location = new System.Drawing.Point(124, 184);
            this.txtCrtFolder.Multiline = true;
            this.txtCrtFolder.Name = "txtCrtFolder";
            this.txtCrtFolder.Size = new System.Drawing.Size(127, 39);
            this.txtCrtFolder.TabIndex = 3;
            // 
            // txtCrtText
            // 
            this.txtCrtText.Location = new System.Drawing.Point(314, 184);
            this.txtCrtText.Multiline = true;
            this.txtCrtText.Name = "txtCrtText";
            this.txtCrtText.Size = new System.Drawing.Size(127, 39);
            this.txtCrtText.TabIndex = 4;
            // 
            // btnCrtText
            // 
            this.btnCrtText.Location = new System.Drawing.Point(314, 229);
            this.btnCrtText.Name = "btnCrtText";
            this.btnCrtText.Size = new System.Drawing.Size(127, 39);
            this.btnCrtText.TabIndex = 5;
            this.btnCrtText.Text = "Create Text";
            this.btnCrtText.UseVisualStyleBackColor = true;
            this.btnCrtText.Click += new System.EventHandler(this.btnCrtText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrtText);
            this.Controls.Add(this.txtCrtText);
            this.Controls.Add(this.txtCrtFolder);
            this.Controls.Add(this.btnCrtFolder);
            this.Controls.Add(this.btnSltPath);
            this.Controls.Add(this.txtFolder);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtCrtFolder;
        private System.Windows.Forms.Button btnCrtText;

        private System.Windows.Forms.Button btnCrtFolder;
        private System.Windows.Forms.TextBox txtCrtText;

        private System.Windows.Forms.Button btnSltPath;

        private System.Windows.Forms.TextBox txtFolder;

        #endregion
    }
}