namespace LempelZivWelch
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
            this.richTextBox_Original = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Compressed = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Decompressed = new System.Windows.Forms.RichTextBox();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uIModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDisplaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelDecompressedHeading = new System.Windows.Forms.Label();
            this.labelCompressedHeading = new System.Windows.Forms.Label();
            this.labelCompressedSize = new System.Windows.Forms.Label();
            this.labelDecompressedSize = new System.Windows.Forms.Label();
            this.labelOriginalSize = new System.Windows.Forms.Label();
            this.labelOriginalHeading = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.labelErrorCount = new System.Windows.Forms.Label();
            this.labelDictionaryLength = new System.Windows.Forms.Label();
            this.labelCompressionRatio = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelCompressionTime = new System.Windows.Forms.Label();
            this.labelDecompressionTime = new System.Windows.Forms.Label();
            this.labelDictionaryType = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_Original
            // 
            this.richTextBox_Original.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_Original.BackColor = System.Drawing.Color.White;
            this.richTextBox_Original.Location = new System.Drawing.Point(3, 23);
            this.richTextBox_Original.Name = "richTextBox_Original";
            this.richTextBox_Original.ReadOnly = true;
            this.richTextBox_Original.Size = new System.Drawing.Size(230, 320);
            this.richTextBox_Original.TabIndex = 0;
            this.richTextBox_Original.Text = "";
            // 
            // richTextBox_Compressed
            // 
            this.richTextBox_Compressed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_Compressed.BackColor = System.Drawing.Color.White;
            this.richTextBox_Compressed.Location = new System.Drawing.Point(239, 23);
            this.richTextBox_Compressed.Name = "richTextBox_Compressed";
            this.richTextBox_Compressed.ReadOnly = true;
            this.richTextBox_Compressed.Size = new System.Drawing.Size(230, 320);
            this.richTextBox_Compressed.TabIndex = 1;
            this.richTextBox_Compressed.Text = "";
            // 
            // richTextBox_Decompressed
            // 
            this.richTextBox_Decompressed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_Decompressed.BackColor = System.Drawing.Color.White;
            this.richTextBox_Decompressed.Location = new System.Drawing.Point(475, 23);
            this.richTextBox_Decompressed.Name = "richTextBox_Decompressed";
            this.richTextBox_Decompressed.ReadOnly = true;
            this.richTextBox_Decompressed.Size = new System.Drawing.Size(232, 320);
            this.richTextBox_Decompressed.TabIndex = 2;
            this.richTextBox_Decompressed.Text = "";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.processFileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.resetDisplaysToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(734, 24);
            this.menuStripMain.TabIndex = 3;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadFileToolStripMenuItem.Image")));
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.loadFileToolStripMenuItem.Text = "Load File";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // processFileToolStripMenuItem
            // 
            this.processFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("processFileToolStripMenuItem.Image")));
            this.processFileToolStripMenuItem.Name = "processFileToolStripMenuItem";
            this.processFileToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.processFileToolStripMenuItem.Text = "Process File";
            this.processFileToolStripMenuItem.Click += new System.EventHandler(this.processFileToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fastModeToolStripMenuItem,
            this.uIModeToolStripMenuItem});
            this.optionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("optionsToolStripMenuItem.Image")));
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // fastModeToolStripMenuItem
            // 
            this.fastModeToolStripMenuItem.CheckOnClick = true;
            this.fastModeToolStripMenuItem.Name = "fastModeToolStripMenuItem";
            this.fastModeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fastModeToolStripMenuItem.Text = "Fast Search";
            this.fastModeToolStripMenuItem.Click += new System.EventHandler(this.fastModeToolStripMenuItem_Click);
            // 
            // uIModeToolStripMenuItem
            // 
            this.uIModeToolStripMenuItem.Checked = true;
            this.uIModeToolStripMenuItem.CheckOnClick = true;
            this.uIModeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uIModeToolStripMenuItem.Name = "uIModeToolStripMenuItem";
            this.uIModeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uIModeToolStripMenuItem.Text = "Loop Search";
            this.uIModeToolStripMenuItem.Click += new System.EventHandler(this.uIModeToolStripMenuItem_Click);
            // 
            // resetDisplaysToolStripMenuItem
            // 
            this.resetDisplaysToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("resetDisplaysToolStripMenuItem.Image")));
            this.resetDisplaysToolStripMenuItem.Name = "resetDisplaysToolStripMenuItem";
            this.resetDisplaysToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.resetDisplaysToolStripMenuItem.Text = "Reset Displays";
            this.resetDisplaysToolStripMenuItem.Click += new System.EventHandler(this.resetDisplaysToolStripMenuItem_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel.Controls.Add(this.labelDecompressedHeading, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.labelCompressedHeading, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelCompressedSize, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelDecompressedSize, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.richTextBox_Original, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.richTextBox_Decompressed, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.richTextBox_Compressed, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelOriginalSize, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelOriginalHeading, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(710, 366);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // labelDecompressedHeading
            // 
            this.labelDecompressedHeading.AutoSize = true;
            this.labelDecompressedHeading.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelDecompressedHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecompressedHeading.Location = new System.Drawing.Point(475, 5);
            this.labelDecompressedHeading.Name = "labelDecompressedHeading";
            this.labelDecompressedHeading.Size = new System.Drawing.Size(232, 15);
            this.labelDecompressedHeading.TabIndex = 8;
            this.labelDecompressedHeading.Text = "Decompressed File";
            this.labelDecompressedHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCompressedHeading
            // 
            this.labelCompressedHeading.AutoSize = true;
            this.labelCompressedHeading.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelCompressedHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompressedHeading.Location = new System.Drawing.Point(239, 5);
            this.labelCompressedHeading.Name = "labelCompressedHeading";
            this.labelCompressedHeading.Size = new System.Drawing.Size(230, 15);
            this.labelCompressedHeading.TabIndex = 7;
            this.labelCompressedHeading.Text = "Compressed File";
            this.labelCompressedHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCompressedSize
            // 
            this.labelCompressedSize.AutoSize = true;
            this.labelCompressedSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCompressedSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompressedSize.Location = new System.Drawing.Point(239, 346);
            this.labelCompressedSize.Name = "labelCompressedSize";
            this.labelCompressedSize.Size = new System.Drawing.Size(230, 13);
            this.labelCompressedSize.TabIndex = 5;
            this.labelCompressedSize.Text = "Compressed Size: N/A";
            this.labelCompressedSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDecompressedSize
            // 
            this.labelDecompressedSize.AutoSize = true;
            this.labelDecompressedSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDecompressedSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecompressedSize.Location = new System.Drawing.Point(475, 346);
            this.labelDecompressedSize.Name = "labelDecompressedSize";
            this.labelDecompressedSize.Size = new System.Drawing.Size(232, 13);
            this.labelDecompressedSize.TabIndex = 4;
            this.labelDecompressedSize.Text = "Decompressed Size: N/A";
            this.labelDecompressedSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOriginalSize
            // 
            this.labelOriginalSize.AutoSize = true;
            this.labelOriginalSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOriginalSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOriginalSize.Location = new System.Drawing.Point(3, 346);
            this.labelOriginalSize.Name = "labelOriginalSize";
            this.labelOriginalSize.Size = new System.Drawing.Size(230, 13);
            this.labelOriginalSize.TabIndex = 3;
            this.labelOriginalSize.Text = "Original Size: N/A";
            this.labelOriginalSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOriginalHeading
            // 
            this.labelOriginalHeading.AutoSize = true;
            this.labelOriginalHeading.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelOriginalHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOriginalHeading.Location = new System.Drawing.Point(3, 5);
            this.labelOriginalHeading.Name = "labelOriginalHeading";
            this.labelOriginalHeading.Size = new System.Drawing.Size(230, 15);
            this.labelOriginalHeading.TabIndex = 6;
            this.labelOriginalHeading.Text = "Original Input File";
            this.labelOriginalHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBottom.Controls.Add(this.labelDictionaryType);
            this.panelBottom.Controls.Add(this.labelDecompressionTime);
            this.panelBottom.Controls.Add(this.labelCompressionTime);
            this.panelBottom.Controls.Add(this.labelErrorCount);
            this.panelBottom.Controls.Add(this.labelDictionaryLength);
            this.panelBottom.Controls.Add(this.labelCompressionRatio);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 399);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(734, 84);
            this.panelBottom.TabIndex = 5;
            // 
            // labelErrorCount
            // 
            this.labelErrorCount.AutoSize = true;
            this.labelErrorCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorCount.Location = new System.Drawing.Point(15, 56);
            this.labelErrorCount.Name = "labelErrorCount";
            this.labelErrorCount.Size = new System.Drawing.Size(102, 13);
            this.labelErrorCount.TabIndex = 6;
            this.labelErrorCount.Text = "Error Count: N/A";
            // 
            // labelDictionaryLength
            // 
            this.labelDictionaryLength.AutoSize = true;
            this.labelDictionaryLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDictionaryLength.Location = new System.Drawing.Point(15, 34);
            this.labelDictionaryLength.Name = "labelDictionaryLength";
            this.labelDictionaryLength.Size = new System.Drawing.Size(138, 13);
            this.labelDictionaryLength.TabIndex = 5;
            this.labelDictionaryLength.Text = "Dictionary Entries: N/A";
            // 
            // labelCompressionRatio
            // 
            this.labelCompressionRatio.AutoSize = true;
            this.labelCompressionRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompressionRatio.Location = new System.Drawing.Point(15, 12);
            this.labelCompressionRatio.Name = "labelCompressionRatio";
            this.labelCompressionRatio.Size = new System.Drawing.Size(143, 13);
            this.labelCompressionRatio.TabIndex = 4;
            this.labelCompressionRatio.Text = "Compression Ratio: N/A";
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 483);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(734, 15);
            this.progressBar.TabIndex = 6;
            // 
            // labelCompressionTime
            // 
            this.labelCompressionTime.AutoSize = true;
            this.labelCompressionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompressionTime.Location = new System.Drawing.Point(331, 34);
            this.labelCompressionTime.Name = "labelCompressionTime";
            this.labelCompressionTime.Size = new System.Drawing.Size(140, 13);
            this.labelCompressionTime.TabIndex = 7;
            this.labelCompressionTime.Text = "Compression Time: N/A";
            // 
            // labelDecompressionTime
            // 
            this.labelDecompressionTime.AutoSize = true;
            this.labelDecompressionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecompressionTime.Location = new System.Drawing.Point(331, 56);
            this.labelDecompressionTime.Name = "labelDecompressionTime";
            this.labelDecompressionTime.Size = new System.Drawing.Size(155, 13);
            this.labelDecompressionTime.TabIndex = 8;
            this.labelDecompressionTime.Text = "Decompression Time: N/A";
            // 
            // labelDictionaryType
            // 
            this.labelDictionaryType.AutoSize = true;
            this.labelDictionaryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDictionaryType.Location = new System.Drawing.Point(331, 12);
            this.labelDictionaryType.Name = "labelDictionaryType";
            this.labelDictionaryType.Size = new System.Drawing.Size(127, 13);
            this.labelDictionaryType.TabIndex = 9;
            this.labelDictionaryType.Text = "Dictionary Type: N/A";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 498);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "Coding & Info Theory: LZW Compression Algorithm Demonstration";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Original;
        private System.Windows.Forms.RichTextBox richTextBox_Compressed;
        private System.Windows.Forms.RichTextBox richTextBox_Decompressed;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processFileToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelDecompressedSize;
        private System.Windows.Forms.Label labelOriginalSize;
        private System.Windows.Forms.Label labelCompressedSize;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label labelDictionaryLength;
        private System.Windows.Forms.Label labelCompressionRatio;
        private System.Windows.Forms.Label labelErrorCount;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelDecompressedHeading;
        private System.Windows.Forms.Label labelCompressedHeading;
        private System.Windows.Forms.Label labelOriginalHeading;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uIModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetDisplaysToolStripMenuItem;
        private System.Windows.Forms.Label labelDecompressionTime;
        private System.Windows.Forms.Label labelCompressionTime;
        private System.Windows.Forms.Label labelDictionaryType;
    }
}

