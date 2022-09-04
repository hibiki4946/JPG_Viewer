namespace ZipReader04
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.panelImages = new System.Windows.Forms.Panel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.panelImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelImages
            // 
            this.panelImages.AutoScroll = true;
            this.panelImages.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelImages.Controls.Add(label4);
            this.panelImages.Controls.Add(label3);
            this.panelImages.Controls.Add(label2);
            this.panelImages.Controls.Add(label1);
            this.panelImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImages.Location = new System.Drawing.Point(0, 0);
            this.panelImages.Name = "panelImages";
            this.panelImages.Size = new System.Drawing.Size(1939, 1194);
            this.panelImages.TabIndex = 0;
            this.panelImages.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panelImages_Scroll);
            this.panelImages.SizeChanged += new System.EventHandler(this.panelImages_SizeChanged);
            this.panelImages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelImages_MouseClick);
            this.panelImages.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelImages_MouseDoubleClick);
            this.panelImages.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.panelImages_PreviewKeyDown);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label1.Location = new System.Drawing.Point(491, 104);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(885, 96);
            label1.TabIndex = 0;
            label1.Text = "Press X to select folder";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label2.Location = new System.Drawing.Point(491, 436);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(815, 96);
            label2.TabIndex = 1;
            label2.Text = "Press Z to next pages";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label3.Location = new System.Drawing.Point(491, 263);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(550, 96);
            label3.TabIndex = 2;
            label3.Text = "Scroll to view";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label4.Location = new System.Drawing.Point(491, 619);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(655, 96);
            label4.TabIndex = 3;
            label4.Text = "Press Esc to Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1939, 1194);
            this.Controls.Add(this.panelImages);
            this.Name = "Form1";
            this.Text = "JPG_Viewer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.panelImages.ResumeLayout(false);
            this.panelImages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelImages;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

