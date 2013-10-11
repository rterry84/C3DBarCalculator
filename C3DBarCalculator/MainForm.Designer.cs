namespace C3DBarCalculator
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Input Data", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Bar Spacing", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.txtNumBars = new System.Windows.Forms.TextBox();
            this.labNumBars = new System.Windows.Forms.Label();
            this.txtBundleCnt = new System.Windows.Forms.TextBox();
            this.labBundleCnt = new System.Windows.Forms.Label();
            this.labEndClr = new System.Windows.Forms.Label();
            this.lenEndClr = new C3DCommonCtrls.LengthTextBox();
            this.labBegClr = new System.Windows.Forms.Label();
            this.lenBegClr = new C3DCommonCtrls.LengthTextBox();
            this.labTargetSpa = new System.Windows.Forms.Label();
            this.lenTargetSpa = new C3DCommonCtrls.LengthTextBox();
            this.labSpaMethod = new System.Windows.Forms.Label();
            this.cmbSpaOptions = new System.Windows.Forms.ComboBox();
            this.barSzCtrl = new C3DCommonCtrls.BarSizeCtrl();
            this.labEndSta = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lstVwResults = new System.Windows.Forms.ListView();
            this.cHdrVariable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHdrValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSpacing = new System.Windows.Forms.Button();
            this.labBegSta = new System.Windows.Forms.Label();
            this.staBegSta = new C3DCommonCtrls.StationCtrl();
            this.staEndSta = new C3DCommonCtrls.StationCtrl();
            this.grpInput.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.staEndSta);
            this.grpInput.Controls.Add(this.staBegSta);
            this.grpInput.Controls.Add(this.labBegSta);
            this.grpInput.Controls.Add(this.txtNumBars);
            this.grpInput.Controls.Add(this.labNumBars);
            this.grpInput.Controls.Add(this.txtBundleCnt);
            this.grpInput.Controls.Add(this.labBundleCnt);
            this.grpInput.Controls.Add(this.labEndClr);
            this.grpInput.Controls.Add(this.lenEndClr);
            this.grpInput.Controls.Add(this.labBegClr);
            this.grpInput.Controls.Add(this.lenBegClr);
            this.grpInput.Controls.Add(this.labTargetSpa);
            this.grpInput.Controls.Add(this.lenTargetSpa);
            this.grpInput.Controls.Add(this.labSpaMethod);
            this.grpInput.Controls.Add(this.cmbSpaOptions);
            this.grpInput.Controls.Add(this.barSzCtrl);
            this.grpInput.Controls.Add(this.labEndSta);
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(496, 267);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input Options";
            // 
            // txtNumBars
            // 
            this.txtNumBars.Location = new System.Drawing.Point(182, 147);
            this.txtNumBars.Name = "txtNumBars";
            this.txtNumBars.Size = new System.Drawing.Size(57, 22);
            this.txtNumBars.TabIndex = 8;
            this.txtNumBars.Text = "1";
            // 
            // labNumBars
            // 
            this.labNumBars.AutoSize = true;
            this.labNumBars.Location = new System.Drawing.Point(70, 150);
            this.labNumBars.Name = "labNumBars";
            this.labNumBars.Size = new System.Drawing.Size(107, 17);
            this.labNumBars.TabIndex = 7;
            this.labNumBars.Text = "Number of Bars";
            // 
            // txtBundleCnt
            // 
            this.txtBundleCnt.Location = new System.Drawing.Point(182, 119);
            this.txtBundleCnt.Name = "txtBundleCnt";
            this.txtBundleCnt.Size = new System.Drawing.Size(57, 22);
            this.txtBundleCnt.TabIndex = 6;
            this.txtBundleCnt.Text = "1";
            // 
            // labBundleCnt
            // 
            this.labBundleCnt.AutoSize = true;
            this.labBundleCnt.Location = new System.Drawing.Point(82, 122);
            this.labBundleCnt.Name = "labBundleCnt";
            this.labBundleCnt.Size = new System.Drawing.Size(93, 17);
            this.labBundleCnt.TabIndex = 5;
            this.labBundleCnt.Text = "Bundle Count";
            // 
            // labEndClr
            // 
            this.labEndClr.AutoSize = true;
            this.labEndClr.Location = new System.Drawing.Point(77, 234);
            this.labEndClr.Name = "labEndClr";
            this.labEndClr.Size = new System.Drawing.Size(101, 17);
            this.labEndClr.TabIndex = 13;
            this.labEndClr.Text = "End Clearance";
            // 
            // lenEndClr
            // 
            this.lenEndClr.KeepEnteredPrecision = false;
            this.lenEndClr.Location = new System.Drawing.Point(181, 229);
            this.lenEndClr.MaximumSize = new System.Drawing.Size(300, 30);
            this.lenEndClr.MinimumSize = new System.Drawing.Size(125, 30);
            this.lenEndClr.Name = "lenEndClr";
            this.lenEndClr.Precision = 4;
            this.lenEndClr.Size = new System.Drawing.Size(125, 30);
            this.lenEndClr.TabIndex = 14;
            // 
            // labBegClr
            // 
            this.labBegClr.AutoSize = true;
            this.labBegClr.Location = new System.Drawing.Point(66, 206);
            this.labBegClr.Name = "labBegClr";
            this.labBegClr.Size = new System.Drawing.Size(112, 17);
            this.labBegClr.TabIndex = 11;
            this.labBegClr.Text = "Begin Clearance";
            // 
            // lenBegClr
            // 
            this.lenBegClr.KeepEnteredPrecision = false;
            this.lenBegClr.Location = new System.Drawing.Point(181, 201);
            this.lenBegClr.MaximumSize = new System.Drawing.Size(300, 30);
            this.lenBegClr.MinimumSize = new System.Drawing.Size(125, 30);
            this.lenBegClr.Name = "lenBegClr";
            this.lenBegClr.Precision = 4;
            this.lenBegClr.Size = new System.Drawing.Size(125, 30);
            this.lenBegClr.TabIndex = 12;
            // 
            // labTargetSpa
            // 
            this.labTargetSpa.AutoSize = true;
            this.labTargetSpa.Location = new System.Drawing.Point(73, 178);
            this.labTargetSpa.Name = "labTargetSpa";
            this.labTargetSpa.Size = new System.Drawing.Size(105, 17);
            this.labTargetSpa.TabIndex = 9;
            this.labTargetSpa.Text = "Target Spacing";
            // 
            // lenTargetSpa
            // 
            this.lenTargetSpa.KeepEnteredPrecision = false;
            this.lenTargetSpa.Location = new System.Drawing.Point(181, 173);
            this.lenTargetSpa.MaximumSize = new System.Drawing.Size(300, 30);
            this.lenTargetSpa.MinimumSize = new System.Drawing.Size(125, 30);
            this.lenTargetSpa.Name = "lenTargetSpa";
            this.lenTargetSpa.Precision = 4;
            this.lenTargetSpa.Size = new System.Drawing.Size(125, 30);
            this.lenTargetSpa.TabIndex = 10;
            // 
            // labSpaMethod
            // 
            this.labSpaMethod.AutoSize = true;
            this.labSpaMethod.Location = new System.Drawing.Point(73, 59);
            this.labSpaMethod.Name = "labSpaMethod";
            this.labSpaMethod.Size = new System.Drawing.Size(105, 17);
            this.labSpaMethod.TabIndex = 2;
            this.labSpaMethod.Text = "Spacing Option";
            // 
            // cmbSpaOptions
            // 
            this.cmbSpaOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpaOptions.FormattingEnabled = true;
            this.cmbSpaOptions.Location = new System.Drawing.Point(182, 56);
            this.cmbSpaOptions.Name = "cmbSpaOptions";
            this.cmbSpaOptions.Size = new System.Drawing.Size(296, 24);
            this.cmbSpaOptions.TabIndex = 3;
            // 
            // barSzCtrl
            // 
            this.barSzCtrl.Location = new System.Drawing.Point(113, 83);
            this.barSzCtrl.Name = "barSzCtrl";
            this.barSzCtrl.Size = new System.Drawing.Size(165, 32);
            this.barSzCtrl.TabIndex = 4;
            // 
            // labEndSta
            // 
            this.labEndSta.AutoSize = true;
            this.labEndSta.Location = new System.Drawing.Point(247, 24);
            this.labEndSta.Name = "labEndSta";
            this.labEndSta.Size = new System.Drawing.Size(81, 17);
            this.labEndSta.TabIndex = 0;
            this.labEndSta.Text = "End Station";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(218, 285);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(86, 31);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // grpResults
            // 
            this.grpResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.grpResults.Controls.Add(this.lstVwResults);
            this.grpResults.Location = new System.Drawing.Point(12, 316);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(496, 404);
            this.grpResults.TabIndex = 2;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results";
            // 
            // lstVwResults
            // 
            this.lstVwResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lstVwResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHdrVariable,
            this.cHdrValue});
            this.lstVwResults.FullRowSelect = true;
            this.lstVwResults.GridLines = true;
            listViewGroup1.Header = "Input Data";
            listViewGroup1.Name = "lstVwInputGrp";
            listViewGroup2.Header = "Bar Spacing";
            listViewGroup2.Name = "lstVwOutputGrp";
            this.lstVwResults.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lstVwResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstVwResults.Location = new System.Drawing.Point(17, 23);
            this.lstVwResults.Name = "lstVwResults";
            this.lstVwResults.Size = new System.Drawing.Size(461, 367);
            this.lstVwResults.TabIndex = 0;
            this.lstVwResults.UseCompatibleStateImageBehavior = false;
            this.lstVwResults.View = System.Windows.Forms.View.Details;
            // 
            // cHdrVariable
            // 
            this.cHdrVariable.Text = "Variable";
            this.cHdrVariable.Width = 200;
            // 
            // cHdrValue
            // 
            this.cHdrValue.Text = "Value";
            this.cHdrValue.Width = 256;
            // 
            // btnSpacing
            // 
            this.btnSpacing.Location = new System.Drawing.Point(344, 287);
            this.btnSpacing.Name = "btnSpacing";
            this.btnSpacing.Size = new System.Drawing.Size(157, 29);
            this.btnSpacing.TabIndex = 3;
            this.btnSpacing.Text = "Spacing Distances...";
            this.btnSpacing.UseVisualStyleBackColor = true;
            this.btnSpacing.Click += new System.EventHandler(this.btnSpacing_Click);
            // 
            // labBegSta
            // 
            this.labBegSta.AutoSize = true;
            this.labBegSta.Location = new System.Drawing.Point(24, 24);
            this.labBegSta.Name = "labBegSta";
            this.labBegSta.Size = new System.Drawing.Size(92, 17);
            this.labBegSta.TabIndex = 15;
            this.labBegSta.Text = "Begin Station";
            // 
            // staBegSta
            // 
            this.staBegSta.Location = new System.Drawing.Point(119, 20);
            this.staBegSta.Name = "staBegSta";
            this.staBegSta.Size = new System.Drawing.Size(111, 30);
            this.staBegSta.Station = 0D;
            this.staBegSta.TabIndex = 16;
            // 
            // staEndSta
            // 
            this.staEndSta.Location = new System.Drawing.Point(334, 20);
            this.staEndSta.Name = "staEndSta";
            this.staEndSta.Size = new System.Drawing.Size(111, 30);
            this.staEndSta.Station = 0D;
            this.staEndSta.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 735);
            this.Controls.Add(this.btnSpacing);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.grpInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 900);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(540, 780);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crimson3DX Bar Spacing Calculator";
            this.Load += new System.EventHandler(this.OnLoad);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label labEndClr;
        private C3DCommonCtrls.LengthTextBox lenEndClr;
        private System.Windows.Forms.Label labBegClr;
        private C3DCommonCtrls.LengthTextBox lenBegClr;
        private System.Windows.Forms.Label labTargetSpa;
        private C3DCommonCtrls.LengthTextBox lenTargetSpa;
        private System.Windows.Forms.Label labSpaMethod;
        private System.Windows.Forms.ComboBox cmbSpaOptions;
        private C3DCommonCtrls.BarSizeCtrl barSzCtrl;
        private System.Windows.Forms.Label labEndSta;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.ListView lstVwResults;
        private System.Windows.Forms.ColumnHeader cHdrVariable;
        private System.Windows.Forms.ColumnHeader cHdrValue;
        private System.Windows.Forms.TextBox txtBundleCnt;
        private System.Windows.Forms.Label labBundleCnt;
        private System.Windows.Forms.TextBox txtNumBars;
        private System.Windows.Forms.Label labNumBars;
        private System.Windows.Forms.Button btnSpacing;
        private C3DCommonCtrls.StationCtrl staEndSta;
        private C3DCommonCtrls.StationCtrl staBegSta;
        private System.Windows.Forms.Label labBegSta;
    }
}

