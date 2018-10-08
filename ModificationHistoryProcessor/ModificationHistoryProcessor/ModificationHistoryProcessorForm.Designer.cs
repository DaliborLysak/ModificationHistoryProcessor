namespace ModificationHistoryProcessor
{
    partial class ModificationHistoryProcessorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificationHistoryProcessorForm));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.PageProcessing = new System.Windows.Forms.TabPage();
            this.toolStripProcessing = new System.Windows.Forms.ToolStrip();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.propertyGridSettings = new System.Windows.Forms.PropertyGrid();
            this.splitContainerProcessing = new System.Windows.Forms.SplitContainer();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.richTextBoxGet = new System.Windows.Forms.RichTextBox();
            this.toolStripButtonProcessLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonWriteToFiles = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClearFiles = new System.Windows.Forms.ToolStripButton();
            this.tabControlMain.SuspendLayout();
            this.PageProcessing.SuspendLayout();
            this.toolStripProcessing.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerProcessing)).BeginInit();
            this.splitContainerProcessing.Panel1.SuspendLayout();
            this.splitContainerProcessing.Panel2.SuspendLayout();
            this.splitContainerProcessing.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.PageProcessing);
            this.tabControlMain.Controls.Add(this.tabPageSettings);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1120, 275);
            this.tabControlMain.TabIndex = 4;
            // 
            // PageProcessing
            // 
            this.PageProcessing.Controls.Add(this.splitContainerProcessing);
            this.PageProcessing.Controls.Add(this.toolStripProcessing);
            this.PageProcessing.Location = new System.Drawing.Point(4, 22);
            this.PageProcessing.Name = "PageProcessing";
            this.PageProcessing.Padding = new System.Windows.Forms.Padding(3);
            this.PageProcessing.Size = new System.Drawing.Size(1112, 249);
            this.PageProcessing.TabIndex = 0;
            this.PageProcessing.Text = "Processing";
            this.PageProcessing.UseVisualStyleBackColor = true;
            // 
            // toolStripProcessing
            // 
            this.toolStripProcessing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonProcessLine,
            this.toolStripButtonWriteToFiles,
            this.toolStripButtonClearFiles});
            this.toolStripProcessing.Location = new System.Drawing.Point(3, 3);
            this.toolStripProcessing.Name = "toolStripProcessing";
            this.toolStripProcessing.Size = new System.Drawing.Size(1106, 25);
            this.toolStripProcessing.TabIndex = 6;
            this.toolStripProcessing.Text = "toolStrip2";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.propertyGridSettings);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(1112, 249);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // propertyGridSettings
            // 
            this.propertyGridSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridSettings.Location = new System.Drawing.Point(3, 3);
            this.propertyGridSettings.Name = "propertyGridSettings";
            this.propertyGridSettings.Size = new System.Drawing.Size(1106, 243);
            this.propertyGridSettings.TabIndex = 8;
            // 
            // splitContainerProcessing
            // 
            this.splitContainerProcessing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerProcessing.Location = new System.Drawing.Point(3, 28);
            this.splitContainerProcessing.Name = "splitContainerProcessing";
            this.splitContainerProcessing.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerProcessing.Panel1
            // 
            this.splitContainerProcessing.Panel1.Controls.Add(this.richTextBoxGet);
            // 
            // splitContainerProcessing.Panel2
            // 
            this.splitContainerProcessing.Panel2.Controls.Add(this.listBoxFiles);
            this.splitContainerProcessing.Size = new System.Drawing.Size(1106, 218);
            this.splitContainerProcessing.SplitterDistance = 73;
            this.splitContainerProcessing.TabIndex = 9;
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.AllowDrop = true;
            this.listBoxFiles.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(0, 0);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(1106, 141);
            this.listBoxFiles.TabIndex = 9;
            this.listBoxFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxFiles_DragDrop);
            this.listBoxFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxFiles_DragEnter);
            // 
            // richTextBoxGet
            // 
            this.richTextBoxGet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxGet.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxGet.Name = "richTextBoxGet";
            this.richTextBoxGet.Size = new System.Drawing.Size(1106, 73);
            this.richTextBoxGet.TabIndex = 8;
            this.richTextBoxGet.Text = "";
            // 
            // toolStripButtonProcessLine
            // 
            this.toolStripButtonProcessLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonProcessLine.Image = global::ModificationHistoryProcessor.Properties.Resources.Arrow_Right;
            this.toolStripButtonProcessLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonProcessLine.Name = "toolStripButtonProcessLine";
            this.toolStripButtonProcessLine.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonProcessLine.ToolTipText = "Process Line Data";
            this.toolStripButtonProcessLine.Click += new System.EventHandler(this.toolStripButtonProcessLine_Click);
            // 
            // toolStripButtonWriteToFiles
            // 
            this.toolStripButtonWriteToFiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonWriteToFiles.Image = global::ModificationHistoryProcessor.Properties.Resources.Save;
            this.toolStripButtonWriteToFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonWriteToFiles.Name = "toolStripButtonWriteToFiles";
            this.toolStripButtonWriteToFiles.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonWriteToFiles.ToolTipText = "Write To Files";
            this.toolStripButtonWriteToFiles.Click += new System.EventHandler(this.toolStripButtonWriteToFiles_Click);
            // 
            // toolStripButtonClearFiles
            // 
            this.toolStripButtonClearFiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClearFiles.Image = global::ModificationHistoryProcessor.Properties.Resources.Delete;
            this.toolStripButtonClearFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClearFiles.Name = "toolStripButtonClearFiles";
            this.toolStripButtonClearFiles.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonClearFiles.ToolTipText = "Clear Files";
            this.toolStripButtonClearFiles.Click += new System.EventHandler(this.ToolStripButtonClearFiles_Click);
            // 
            // ModificationHistoryProcessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 275);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificationHistoryProcessorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification History Processor";
            this.Load += new System.EventHandler(this.ModificationHistoryProcessorForm_Load);
            this.Shown += new System.EventHandler(this.ModificationHistoryProcessorForm_Shown);
            this.tabControlMain.ResumeLayout(false);
            this.PageProcessing.ResumeLayout(false);
            this.PageProcessing.PerformLayout();
            this.toolStripProcessing.ResumeLayout(false);
            this.toolStripProcessing.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.splitContainerProcessing.Panel1.ResumeLayout(false);
            this.splitContainerProcessing.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerProcessing)).EndInit();
            this.splitContainerProcessing.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage PageProcessing;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.PropertyGrid propertyGridSettings;
        private System.Windows.Forms.ToolStrip toolStripProcessing;
        private System.Windows.Forms.ToolStripButton toolStripButtonProcessLine;
        private System.Windows.Forms.SplitContainer splitContainerProcessing;
        private System.Windows.Forms.RichTextBox richTextBoxGet;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.ToolStripButton toolStripButtonWriteToFiles;
        private System.Windows.Forms.ToolStripButton toolStripButtonClearFiles;
    }
}

