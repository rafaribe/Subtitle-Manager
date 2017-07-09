namespace Subtitle_Renamer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_folderpicker = new System.Windows.Forms.Button();
            this.btn_mudanca = new System.Windows.Forms.Button();
            this.txt_origem = new System.Windows.Forms.TextBox();
            this.txt_destino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.includeSubFoldersCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // btn_folderpicker
            // 
            this.btn_folderpicker.Location = new System.Drawing.Point(136, 206);
            this.btn_folderpicker.Name = "btn_folderpicker";
            this.btn_folderpicker.Size = new System.Drawing.Size(142, 68);
            this.btn_folderpicker.TabIndex = 0;
            this.btn_folderpicker.Text = "Escolher pasta";
            this.btn_folderpicker.UseVisualStyleBackColor = true;
            this.btn_folderpicker.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_mudanca
            // 
            this.btn_mudanca.Location = new System.Drawing.Point(432, 206);
            this.btn_mudanca.Name = "btn_mudanca";
            this.btn_mudanca.Size = new System.Drawing.Size(142, 68);
            this.btn_mudanca.TabIndex = 1;
            this.btn_mudanca.Text = "Mudar extensao";
            this.btn_mudanca.UseVisualStyleBackColor = true;
            this.btn_mudanca.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_origem
            // 
            this.txt_origem.Location = new System.Drawing.Point(136, 83);
            this.txt_origem.Name = "txt_origem";
            this.txt_origem.Size = new System.Drawing.Size(142, 22);
            this.txt_origem.TabIndex = 2;
            // 
            // txt_destino
            // 
            this.txt_destino.Location = new System.Drawing.Point(432, 83);
            this.txt_destino.Name = "txt_destino";
            this.txt_destino.Size = new System.Drawing.Size(142, 22);
            this.txt_destino.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Origin Extension";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination Extension";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(136, 341);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(439, 23);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            // 
            // includeSubFoldersCheckbox
            // 
            this.includeSubFoldersCheckbox.AutoSize = true;
            this.includeSubFoldersCheckbox.Location = new System.Drawing.Point(433, 142);
            this.includeSubFoldersCheckbox.Name = "includeSubFoldersCheckbox";
            this.includeSubFoldersCheckbox.Size = new System.Drawing.Size(147, 21);
            this.includeSubFoldersCheckbox.TabIndex = 8;
            this.includeSubFoldersCheckbox.Text = "Include Subfolders";
            this.includeSubFoldersCheckbox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.includeSubFoldersCheckbox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_destino);
            this.Controls.Add(this.txt_origem);
            this.Controls.Add(this.btn_mudanca);
            this.Controls.Add(this.btn_folderpicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Subtitle Renamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_folderpicker;
        private System.Windows.Forms.Button btn_mudanca;
        private System.Windows.Forms.TextBox txt_origem;
        private System.Windows.Forms.TextBox txt_destino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox includeSubFoldersCheckbox;
    }
}

