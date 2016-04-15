﻿namespace XrmToolBox.Forms
{
    partial class PluginsChecker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginsChecker));
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbLoadPlugins = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbInstall = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tssLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lvPlugins = new System.Windows.Forms.ListView();
            this.colAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCurrent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoadPlugins,
            this.toolStripSeparator1,
            this.tsbInstall});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(998, 31);
            this.tsMain.TabIndex = 0;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbLoadPlugins
            // 
            this.tsbLoadPlugins.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadPlugins.Image")));
            this.tsbLoadPlugins.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadPlugins.Name = "tsbLoadPlugins";
            this.tsbLoadPlugins.Size = new System.Drawing.Size(179, 28);
            this.tsbLoadPlugins.Text = "Reload plugins from NuGet";
            this.tsbLoadPlugins.Click += new System.EventHandler(this.tsbLoadPlugins_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbInstall
            // 
            this.tsbInstall.Image = ((System.Drawing.Image)(resources.GetObject("tsbInstall.Image")));
            this.tsbInstall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInstall.Name = "tsbInstall";
            this.tsbInstall.Size = new System.Drawing.Size(172, 28);
            this.tsbInstall.Text = "Install selected package(s)";
            this.tsbInstall.Click += new System.EventHandler(this.tsbInstall_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssProgress,
            this.tssLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 333);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(998, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssProgress
            // 
            this.tssProgress.Name = "tssProgress";
            this.tssProgress.Size = new System.Drawing.Size(133, 16);
            this.tssProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.tssProgress.Visible = false;
            // 
            // tssLabel
            // 
            this.tssLabel.Name = "tssLabel";
            this.tssLabel.Size = new System.Drawing.Size(988, 17);
            this.tssLabel.Spring = true;
            this.tssLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvPlugins
            // 
            this.lvPlugins.CheckBoxes = true;
            this.lvPlugins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTitle,
            this.colVersion,
            this.colCurrent,
            this.colDescription,
            this.colAuthor,
            this.colAction});
            this.lvPlugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPlugins.GridLines = true;
            this.lvPlugins.Location = new System.Drawing.Point(0, 31);
            this.lvPlugins.Margin = new System.Windows.Forms.Padding(2);
            this.lvPlugins.Name = "lvPlugins";
            this.lvPlugins.Size = new System.Drawing.Size(998, 302);
            this.lvPlugins.TabIndex = 3;
            this.lvPlugins.UseCompatibleStateImageBehavior = false;
            this.lvPlugins.View = System.Windows.Forms.View.Details;
            // 
            // colAction
            // 
            this.colAction.Text = "Action";
            this.colAction.Width = 100;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Title";
            this.colTitle.Width = 217;
            // 
            // colVersion
            // 
            this.colVersion.Text = "Version";
            this.colVersion.Width = 100;
            // 
            // colCurrent
            // 
            this.colCurrent.Text = "Current Version";
            this.colCurrent.Width = 100;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            this.colDescription.Width = 317;
            // 
            // colAuthor
            // 
            this.colAuthor.Text = "Author";
            this.colAuthor.Width = 133;
            // 
            // PluginsChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 355);
            this.Controls.Add(this.lvPlugins);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tsMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PluginsChecker";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Install/Update XrmToolBox plugins";
            this.Load += new System.EventHandler(this.PluginsChecker_Load);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton tsbLoadPlugins;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbInstall;
        private System.Windows.Forms.ToolStripProgressBar tssProgress;
        private System.Windows.Forms.ToolStripStatusLabel tssLabel;
        private System.Windows.Forms.ListView lvPlugins;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colVersion;
        private System.Windows.Forms.ColumnHeader colAuthor;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader colAction;
        private System.Windows.Forms.ColumnHeader colCurrent;
    }
}