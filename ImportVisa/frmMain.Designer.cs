namespace ImportVisa
{
    partial class frmMain
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
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.lbSources = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectTarget = new System.Windows.Forms.Button();
            this.btnSelectSources = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.openSources = new System.Windows.Forms.OpenFileDialog();
            this.openTarget = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtTarget
            // 
            this.txtTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTarget.Location = new System.Drawing.Point(64, 10);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(221, 20);
            this.txtTarget.TabIndex = 0;
            // 
            // lbSources
            // 
            this.lbSources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSources.FormattingEnabled = true;
            this.lbSources.Location = new System.Drawing.Point(64, 45);
            this.lbSources.Name = "lbSources";
            this.lbSources.Size = new System.Drawing.Size(221, 173);
            this.lbSources.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sources:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target:";
            // 
            // btnSelectTarget
            // 
            this.btnSelectTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectTarget.Location = new System.Drawing.Point(291, 10);
            this.btnSelectTarget.Name = "btnSelectTarget";
            this.btnSelectTarget.Size = new System.Drawing.Size(34, 20);
            this.btnSelectTarget.TabIndex = 4;
            this.btnSelectTarget.Text = "...";
            this.btnSelectTarget.UseVisualStyleBackColor = true;
            this.btnSelectTarget.Click += new System.EventHandler(this.btnSelectTarget_Click);
            // 
            // btnSelectSources
            // 
            this.btnSelectSources.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectSources.Location = new System.Drawing.Point(291, 41);
            this.btnSelectSources.Name = "btnSelectSources";
            this.btnSelectSources.Size = new System.Drawing.Size(34, 20);
            this.btnSelectSources.TabIndex = 5;
            this.btnSelectSources.Text = "...";
            this.btnSelectSources.UseVisualStyleBackColor = true;
            this.btnSelectSources.Click += new System.EventHandler(this.btnSelectSources_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImport.Location = new System.Drawing.Point(127, 241);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // openSources
            // 
            this.openSources.FileName = "openFileDialog1";
            this.openSources.Filter = "Excel Files|*.xls";
            this.openSources.Multiselect = true;
            this.openSources.ShowReadOnly = true;
            // 
            // openTarget
            // 
            this.openTarget.FileName = "openFileDialog2";
            this.openTarget.Filter = "Excel Files (xlsx)|*.xlsx";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 275);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnSelectSources);
            this.Controls.Add(this.btnSelectTarget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSources);
            this.Controls.Add(this.txtTarget);
            this.Name = "frmMain";
            this.Text = "Import Visa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.ListBox lbSources;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectTarget;
        private System.Windows.Forms.Button btnSelectSources;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.OpenFileDialog openSources;
        private System.Windows.Forms.OpenFileDialog openTarget;
    }
}