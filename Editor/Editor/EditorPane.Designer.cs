namespace Editor
{
    partial class EditorPane
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
			  System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorPane));
			  this.Issue_Label = new System.Windows.Forms.Label();
			  this.EditArea = new System.Windows.Forms.TextBox();
			  this.Tools = new System.Windows.Forms.ToolStrip();
			  this.SaveAndCommit = new System.Windows.Forms.ToolStripButton();
			  this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			  this.ReasonLabel = new System.Windows.Forms.ToolStripLabel();
			  this.Reason = new System.Windows.Forms.ToolStripComboBox();
			  this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			  this.IssueLabel = new System.Windows.Forms.ToolStripLabel();
			  this.Issue = new System.Windows.Forms.ToolStripTextBox();
			  this.Tools.SuspendLayout();
			  this.SuspendLayout();
			  // 
			  // Issue_Label
			  // 
			  this.Issue_Label.AccessibleDescription = "Issue";
			  this.Issue_Label.AccessibleName = "Label for Issue Tracking Box";
			  this.Issue_Label.AutoSize = true;
			  this.Issue_Label.Location = new System.Drawing.Point(219, 9);
			  this.Issue_Label.Name = "Issue_Label";
			  this.Issue_Label.Size = new System.Drawing.Size(32, 13);
			  this.Issue_Label.TabIndex = 2;
			  this.Issue_Label.Text = "Issue";
			  // 
			  // EditArea
			  // 
			  this.EditArea.Location = new System.Drawing.Point(12, 32);
			  this.EditArea.Multiline = true;
			  this.EditArea.Name = "EditArea";
			  this.EditArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			  this.EditArea.Size = new System.Drawing.Size(617, 218);
			  this.EditArea.TabIndex = 4;
			  // 
			  // Tools
			  // 
			  this.Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveAndCommit,
            this.toolStripSeparator1,
            this.ReasonLabel,
            this.Reason,
            this.toolStripSeparator2,
            this.IssueLabel,
            this.Issue});
			  this.Tools.Location = new System.Drawing.Point(0, 0);
			  this.Tools.Name = "Tools";
			  this.Tools.Size = new System.Drawing.Size(641, 25);
			  this.Tools.TabIndex = 5;
			  this.Tools.Text = "toolStrip1";
			  // 
			  // SaveAndCommit
			  // 
			  this.SaveAndCommit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			  this.SaveAndCommit.Image = ((System.Drawing.Image)(resources.GetObject("SaveAndCommit.Image")));
			  this.SaveAndCommit.ImageTransparentColor = System.Drawing.Color.Magenta;
			  this.SaveAndCommit.Name = "SaveAndCommit";
			  this.SaveAndCommit.Size = new System.Drawing.Size(55, 22);
			  this.SaveAndCommit.Text = "Commit";
			  this.SaveAndCommit.Click += new System.EventHandler(this.SaveAndCommit_Click);
			  // 
			  // toolStripSeparator1
			  // 
			  this.toolStripSeparator1.Name = "toolStripSeparator1";
			  this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			  // 
			  // ReasonLabel
			  // 
			  this.ReasonLabel.Name = "ReasonLabel";
			  this.ReasonLabel.Size = new System.Drawing.Size(92, 22);
			  this.ReasonLabel.Text = "Commit Reason";
			  // 
			  // Reason
			  // 
			  this.Reason.Name = "Reason";
			  this.Reason.Size = new System.Drawing.Size(121, 25);
			  // 
			  // toolStripSeparator2
			  // 
			  this.toolStripSeparator2.Name = "toolStripSeparator2";
			  this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			  // 
			  // IssueLabel
			  // 
			  this.IssueLabel.Name = "IssueLabel";
			  this.IssueLabel.Size = new System.Drawing.Size(33, 22);
			  this.IssueLabel.Text = "Issue";
			  // 
			  // Issue
			  // 
			  this.Issue.Name = "Issue";
			  this.Issue.Size = new System.Drawing.Size(300, 25);
			  // 
			  // EditorPane
			  // 
			  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			  this.ClientSize = new System.Drawing.Size(641, 262);
			  this.Controls.Add(this.Tools);
			  this.Controls.Add(this.EditArea);
			  this.Controls.Add(this.Issue_Label);
			  this.DoubleBuffered = true;
			  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			  this.Name = "EditorPane";
			  this.Text = "WalrusCommit";
			  this.TopMost = true;
			  this.Tools.ResumeLayout(false);
			  this.Tools.PerformLayout();
			  this.ResumeLayout(false);
			  this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Issue_Label;
        private System.Windows.Forms.TextBox EditArea;
        private System.Windows.Forms.ToolStrip Tools;
        private System.Windows.Forms.ToolStripButton SaveAndCommit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel ReasonLabel;
        private System.Windows.Forms.ToolStripComboBox Reason;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel IssueLabel;
        private System.Windows.Forms.ToolStripTextBox Issue;
    }
}

