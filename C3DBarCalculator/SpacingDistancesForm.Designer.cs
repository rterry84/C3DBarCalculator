namespace C3DBarCalculator
{
    partial class SpacingDistancesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpacingDistancesForm));
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panAction = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbxDistances = new System.Windows.Forms.ListBox();
            this.tblLayout.SuspendLayout();
            this.panAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayout
            // 
            this.tblLayout.ColumnCount = 1;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.Controls.Add(this.panAction, 0, 1);
            this.tblLayout.Controls.Add(this.lbxDistances, 0, 0);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Location = new System.Drawing.Point(0, 0);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 2;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tblLayout.Size = new System.Drawing.Size(258, 378);
            this.tblLayout.TabIndex = 0;
            // 
            // panAction
            // 
            this.panAction.Controls.Add(this.btnClose);
            this.panAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panAction.Location = new System.Drawing.Point(3, 334);
            this.panAction.Name = "panAction";
            this.panAction.Size = new System.Drawing.Size(252, 41);
            this.panAction.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(90, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbxDistances
            // 
            this.lbxDistances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxDistances.FormattingEnabled = true;
            this.lbxDistances.ItemHeight = 16;
            this.lbxDistances.Location = new System.Drawing.Point(3, 3);
            this.lbxDistances.Name = "lbxDistances";
            this.lbxDistances.Size = new System.Drawing.Size(252, 325);
            this.lbxDistances.TabIndex = 1;
            // 
            // SpacingDistancesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 378);
            this.Controls.Add(this.tblLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(276, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(276, 423);
            this.Name = "SpacingDistancesForm";
            this.Text = "Spacing Distances";
            this.tblLayout.ResumeLayout(false);
            this.panAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.Panel panAction;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbxDistances;
    }
}