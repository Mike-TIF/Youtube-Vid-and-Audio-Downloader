namespace SongDownloader
{
    partial class BaseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UrlInputTxt = new System.Windows.Forms.TextBox();
            this.CheckUrlBtn = new System.Windows.Forms.Button();
            this.OutputTxt = new System.Windows.Forms.RichTextBox();
            this.ExtensionInputTxt = new System.Windows.Forms.TextBox();
            this.DownloadAllBtn = new System.Windows.Forms.Button();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentlySelectedFileLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UrlInputTxt
            // 
            this.UrlInputTxt.Location = new System.Drawing.Point(4, 26);
            this.UrlInputTxt.Name = "UrlInputTxt";
            this.UrlInputTxt.Size = new System.Drawing.Size(524, 23);
            this.UrlInputTxt.TabIndex = 0;
            // 
            // CheckUrlBtn
            // 
            this.CheckUrlBtn.Location = new System.Drawing.Point(644, 26);
            this.CheckUrlBtn.Name = "CheckUrlBtn";
            this.CheckUrlBtn.Size = new System.Drawing.Size(153, 24);
            this.CheckUrlBtn.TabIndex = 1;
            this.CheckUrlBtn.Text = "CHECK";
            this.CheckUrlBtn.UseVisualStyleBackColor = true;
            this.CheckUrlBtn.Click += new System.EventHandler(this.CheckUrlBtn_Click);
            // 
            // OutputTxt
            // 
            this.OutputTxt.Location = new System.Drawing.Point(4, 55);
            this.OutputTxt.Name = "OutputTxt";
            this.OutputTxt.Size = new System.Drawing.Size(793, 361);
            this.OutputTxt.TabIndex = 2;
            this.OutputTxt.Text = "";
            // 
            // ExtensionInputTxt
            // 
            this.ExtensionInputTxt.Location = new System.Drawing.Point(537, 26);
            this.ExtensionInputTxt.Name = "ExtensionInputTxt";
            this.ExtensionInputTxt.Size = new System.Drawing.Size(101, 23);
            this.ExtensionInputTxt.TabIndex = 3;
            // 
            // DownloadAllBtn
            // 
            this.DownloadAllBtn.Location = new System.Drawing.Point(644, 422);
            this.DownloadAllBtn.Name = "DownloadAllBtn";
            this.DownloadAllBtn.Size = new System.Drawing.Size(153, 24);
            this.DownloadAllBtn.TabIndex = 4;
            this.DownloadAllBtn.Text = "DOWNLOAD ALL";
            this.DownloadAllBtn.UseVisualStyleBackColor = true;
            this.DownloadAllBtn.Click += new System.EventHandler(this.DownloadAllBtn_Click);
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.Location = new System.Drawing.Point(485, 422);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(153, 24);
            this.DownloadBtn.TabIndex = 5;
            this.DownloadBtn.Text = "DOWNLOAD";
            this.DownloadBtn.UseVisualStyleBackColor = true;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "WEBSITE URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "FILE EXTENSTION:";
            // 
            // CurrentlySelectedFileLbl
            // 
            this.CurrentlySelectedFileLbl.AutoEllipsis = true;
            this.CurrentlySelectedFileLbl.Location = new System.Drawing.Point(4, 427);
            this.CurrentlySelectedFileLbl.Name = "CurrentlySelectedFileLbl";
            this.CurrentlySelectedFileLbl.Size = new System.Drawing.Size(475, 15);
            this.CurrentlySelectedFileLbl.TabIndex = 8;
            this.CurrentlySelectedFileLbl.Text = "WEBSITE URL:";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CurrentlySelectedFileLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DownloadBtn);
            this.Controls.Add(this.DownloadAllBtn);
            this.Controls.Add(this.ExtensionInputTxt);
            this.Controls.Add(this.OutputTxt);
            this.Controls.Add(this.CheckUrlBtn);
            this.Controls.Add(this.UrlInputTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BaseForm";
            this.Text = "File Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UrlInputTxt;
        private Button CheckUrlBtn;
        private RichTextBox OutputTxt;
        private TextBox ExtensionInputTxt;
        private Button DownloadAllBtn;
        private Button DownloadBtn;
        private Label label1;
        private Label label2;
        private Label CurrentlySelectedFileLbl;
    }
}