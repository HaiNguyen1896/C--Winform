namespace MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOpenFol = new System.Windows.Forms.TextBox();
            this.btnOpenBrowser = new System.Windows.Forms.Button();
            this.chkSaveBfr = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbList = new System.Windows.Forms.RichTextBox();
            this.btnGetFile = new System.Windows.Forms.Button();
            this.grbGroup = new System.Windows.Forms.GroupBox();
            this.btnSaveBrowser = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtSaveFol = new System.Windows.Forms.TextBox();
            this.chkSaveAft = new System.Windows.Forms.CheckBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Select the folder path";
            // 
            // txtOpenFol
            // 
            this.txtOpenFol.Location = new System.Drawing.Point(29, 70);
            this.txtOpenFol.Multiline = true;
            this.txtOpenFol.Name = "txtOpenFol";
            this.txtOpenFol.Size = new System.Drawing.Size(455, 33);
            this.txtOpenFol.TabIndex = 1;
            // 
            // btnOpenBrowser
            // 
            this.btnOpenBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenBrowser.Location = new System.Drawing.Point(508, 70);
            this.btnOpenBrowser.Name = "btnOpenBrowser";
            this.btnOpenBrowser.Size = new System.Drawing.Size(98, 32);
            this.btnOpenBrowser.TabIndex = 2;
            this.btnOpenBrowser.Text = "Browser";
            this.btnOpenBrowser.UseVisualStyleBackColor = true;
            this.btnOpenBrowser.Click += new System.EventHandler(this.btnOpenBrowser_Click);
            // 
            // chkSaveBfr
            // 
            this.chkSaveBfr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSaveBfr.Location = new System.Drawing.Point(29, 120);
            this.chkSaveBfr.Name = "chkSaveBfr";
            this.chkSaveBfr.Size = new System.Drawing.Size(336, 29);
            this.chkSaveBfr.TabIndex = 3;
            this.chkSaveBfr.Text = "Save the link for later use";
            this.chkSaveBfr.UseVisualStyleBackColor = true;
            this.chkSaveBfr.CheckedChanged += new System.EventHandler(this.chkSaveBfr_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(577, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "2. List file need to rename in folder";
            // 
            // rtbList
            // 
            this.rtbList.Location = new System.Drawing.Point(29, 204);
            this.rtbList.Name = "rtbList";
            this.rtbList.Size = new System.Drawing.Size(455, 156);
            this.rtbList.TabIndex = 5;
            this.rtbList.Text = "";
            // 
            // btnGetFile
            // 
            this.btnGetFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetFile.Location = new System.Drawing.Point(508, 204);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(98, 32);
            this.btnGetFile.TabIndex = 6;
            this.btnGetFile.Text = "Get File";
            this.btnGetFile.UseVisualStyleBackColor = true;
            this.btnGetFile.Click += new System.EventHandler(this.btnGetFile_Click);
            // 
            // grbGroup
            // 
            this.grbGroup.Controls.Add(this.btnSaveBrowser);
            this.grbGroup.Controls.Add(this.lbl2);
            this.grbGroup.Controls.Add(this.txtSaveFol);
            this.grbGroup.Location = new System.Drawing.Point(29, 394);
            this.grbGroup.Name = "grbGroup";
            this.grbGroup.Size = new System.Drawing.Size(596, 140);
            this.grbGroup.TabIndex = 7;
            this.grbGroup.TabStop = false;
            this.grbGroup.Text = "groupBox1";
            // 
            // btnSaveBrowser
            // 
            this.btnSaveBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBrowser.Location = new System.Drawing.Point(471, 46);
            this.btnSaveBrowser.Name = "btnSaveBrowser";
            this.btnSaveBrowser.Size = new System.Drawing.Size(117, 35);
            this.btnSaveBrowser.TabIndex = 8;
            this.btnSaveBrowser.Text = "Save Browser";
            this.btnSaveBrowser.UseVisualStyleBackColor = true;
            this.btnSaveBrowser.Click += new System.EventHandler(this.btnSaveBrowser_Click);
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(6, 18);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(401, 25);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Pick the folder locate file after rename";
            // 
            // txtSaveFol
            // 
            this.txtSaveFol.Location = new System.Drawing.Point(6, 46);
            this.txtSaveFol.Multiline = true;
            this.txtSaveFol.Name = "txtSaveFol";
            this.txtSaveFol.Size = new System.Drawing.Size(449, 35);
            this.txtSaveFol.TabIndex = 0;
            // 
            // chkSaveAft
            // 
            this.chkSaveAft.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSaveAft.Location = new System.Drawing.Point(29, 497);
            this.chkSaveAft.Name = "chkSaveAft";
            this.chkSaveAft.Size = new System.Drawing.Size(336, 29);
            this.chkSaveAft.TabIndex = 8;
            this.chkSaveAft.Text = "Save the link for later use";
            this.chkSaveAft.UseVisualStyleBackColor = true;
            this.chkSaveAft.CheckedChanged += new System.EventHandler(this.chkSaveAft_CheckedChanged);
            // 
            // btnRename
            // 
            this.btnRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.Location = new System.Drawing.Point(149, 560);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(133, 39);
            this.btnRename.TabIndex = 9;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(375, 560);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 39);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(654, 651);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.chkSaveAft);
            this.Controls.Add(this.grbGroup);
            this.Controls.Add(this.btnGetFile);
            this.Controls.Add(this.rtbList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkSaveBfr);
            this.Controls.Add(this.btnOpenBrowser);
            this.Controls.Add(this.txtOpenFol);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.grbGroup.ResumeLayout(false);
            this.grbGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.Button btnRename;

        private System.Windows.Forms.CheckBox chkSaveAft;

        private System.Windows.Forms.Button btnSaveBrowser;

        private System.Windows.Forms.Label lbl2;

        private System.Windows.Forms.TextBox txtSaveFol;

        private System.Windows.Forms.GroupBox grbGroup;

        private System.Windows.Forms.Button btnGetFile;

        private System.Windows.Forms.RichTextBox rtbList;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.CheckBox chkSaveBfr;

        private System.Windows.Forms.Button btnOpenBrowser;

        private System.Windows.Forms.TextBox txtOpenFol;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}