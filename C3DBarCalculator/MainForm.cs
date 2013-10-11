using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C3DCommonDefs;

namespace C3DBarCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private SpacingDistancesForm m_SDForm = new SpacingDistancesForm();

        private C3DBarSpacing m_BarCalc = new C3DBarSpacing();

        private void OnLoad(object sender, EventArgs e)
        {
            lenTargetSpa.SetLength(new C3DLength(0.0, new C3DInchUnit()));
            lenBegClr.SetLength(new C3DLength(0.0, new C3DInchUnit()));
            lenEndClr.SetLength(new C3DLength(0.0, new C3DInchUnit()));
            FillSpacingOptionComboBox();
        }

        #region ACTION BUTTONS
        private void btnCalc_Click(object sender, EventArgs e)
        {
            string sOption = cmbSpaOptions.Text;
            m_BarCalc.SpacingMethod = m_BarCalc.GetMethodFromString(sOption);
            int nBundle = 0;
            if (int.TryParse(txtBundleCnt.Text, out nBundle))
                m_BarCalc.BundleCount = nBundle;
            else
                m_BarCalc.BundleCount = 1;

            int nBars = 0;
            if (int.TryParse(txtNumBars.Text, out nBars))
                m_BarCalc.NumberOfBars = nBars;
            else
                m_BarCalc.NumberOfBars = 1;

            m_BarCalc.BegDistance = staBegSta.Station;
            m_BarCalc.EndDistance = staEndSta.Station;
            m_BarCalc.BarSize = barSzCtrl.GetBarSize();

            m_BarCalc.TargetSpacing = lenTargetSpa.GetValue();
            m_BarCalc.BegClearance = lenBegClr.GetValue();
            m_BarCalc.EndClearance = lenEndClr.GetValue();

            m_BarCalc.Calculate();

            UpdateListView();
        }

        private void btnSpacing_Click(object sender, EventArgs e)
        {
            List<double> DistList = new List<double>();

            for(int i=0; i <= m_BarCalc.BarSpaces; i++)
            {
                double dDistance;
                m_BarCalc.DistanceAtBarIndex(i, out dDistance);
                DistList.Add(dDistance);
            }

            m_SDForm.SetDistanceList(DistList);
            m_SDForm.Show();
        }
        #endregion

        #region HELPER FUNCTIONS
        private void FillSpacingOptionComboBox()
        {
            List<string> sMethodStrings = m_BarCalc.GetMethodTypeStrings();
            foreach (string sMethod in sMethodStrings)
            {
                cmbSpaOptions.Items.Add(sMethod);
            }
            cmbSpaOptions.Text = sMethodStrings[0];
        }

        private void UpdateListView()
        {
            lstVwResults.Items.Clear();

            ListViewGroup LstVwInpGrp = new ListViewGroup("Input Parameters");
            ListViewGroup LstVwOutGrp = new ListViewGroup("Bar Spacing Results");

            // Total Length
            ListViewItem lvItemTotLen = new ListViewItem();
            lvItemTotLen.Text = "Total Length";
            lvItemTotLen.Group = LstVwInpGrp;
            lvItemTotLen.SubItems.Add(GetLengthString(m_BarCalc.EndDistance, "ft"));
            lstVwResults.Items.Add(lvItemTotLen);

            // Spacing Option
            ListViewItem lvItemSpaOption = new ListViewItem();
            lvItemSpaOption.Text = "Spacing Option";
            lvItemSpaOption.Group = LstVwInpGrp;
            lvItemSpaOption.SubItems.Add(cmbSpaOptions.Text);
            lstVwResults.Items.Add(lvItemSpaOption);

            // Bar Size
            ListViewItem lvItemBarSize = new ListViewItem();
            lvItemBarSize.Text = "Bar Size";
            lvItemBarSize.Group = LstVwInpGrp;
            lvItemBarSize.SubItems.Add(m_BarCalc.BarSize.BarStr);
            lstVwResults.Items.Add(lvItemBarSize);

            // Bar Diameter
            ListViewItem lvItemBarDia = new ListViewItem();
            lvItemBarDia.Text = "Bar Diameter";
            lvItemBarDia.Group = LstVwInpGrp;
            lvItemBarDia.SubItems.Add(GetLengthString(m_BarCalc.BarSize.NominalDiameter, "in"));
            lstVwResults.Items.Add(lvItemBarDia);

            // Bundle Count
            ListViewItem lvItemBundle = new ListViewItem();
            lvItemBundle.Text = "Bundle Count";
            lvItemBundle.Group = LstVwInpGrp;
            lvItemBundle.SubItems.Add(m_BarCalc.BundleCount.ToString());
            lstVwResults.Items.Add(lvItemBundle);

            // Target Spacing
            ListViewItem lvItemTargetSpa = new ListViewItem();
            lvItemTargetSpa.Text = "Target Spacing";
            lvItemTargetSpa.Group = LstVwInpGrp;
            lvItemTargetSpa.SubItems.Add(GetLengthString(m_BarCalc.TargetSpacing, "in"));
            lstVwResults.Items.Add(lvItemTargetSpa);

            // Begin Clearance
            ListViewItem lvItemBegClr = new ListViewItem();
            lvItemBegClr.Text = "Begin Clearance";
            lvItemBegClr.Group = LstVwInpGrp;
            lvItemBegClr.SubItems.Add(GetLengthString(m_BarCalc.BegClearance, "in"));
            lstVwResults.Items.Add(lvItemBegClr);

            // End Clearance
            ListViewItem lvItemEndClr = new ListViewItem();
            lvItemEndClr.Text = "End Clearance";
            lvItemEndClr.Group = LstVwInpGrp;
            lvItemEndClr.SubItems.Add(GetLengthString(m_BarCalc.EndClearance, "in"));
            lstVwResults.Items.Add(lvItemEndClr);

            // Input Parameters Group
            lstVwResults.Groups.Add(LstVwInpGrp);

            // Adjusted Spacing
            ListViewItem lvItemAdjSpa = new ListViewItem();
            lvItemAdjSpa.Text = "Adjusted Spacing";
            lvItemAdjSpa.Group = LstVwOutGrp;
            lvItemAdjSpa.SubItems.Add(GetLengthString(m_BarCalc.AdjustedSpacing, "in"));
            lstVwResults.Items.Add(lvItemAdjSpa);

            // Adjusted Begin Clearance
            ListViewItem lvItemAdjBegClr = new ListViewItem();
            lvItemAdjBegClr.Text = "Adjusted Begin Clearance";
            lvItemAdjBegClr.Group = LstVwOutGrp;
            lvItemAdjBegClr.SubItems.Add(GetLengthString(m_BarCalc.AdjustedBegClearance, "in"));
            lstVwResults.Items.Add(lvItemAdjBegClr);

            // Adjusted Begin Clearance
            ListViewItem lvItemAdjEndClr = new ListViewItem();
            lvItemAdjEndClr.Text = "Adjusted End Clearance";
            lvItemAdjEndClr.Group = LstVwOutGrp;
            lvItemAdjEndClr.SubItems.Add(GetLengthString(m_BarCalc.AdjustedEndClearance, "in"));
            lstVwResults.Items.Add(lvItemAdjEndClr);

            // Number Of Spaces            
            ListViewItem lvItemNoSpaces = new ListViewItem();
            lvItemNoSpaces.Text = "Number Of Spaces";
            lvItemNoSpaces.Group = LstVwOutGrp;
            lvItemNoSpaces.SubItems.Add(m_BarCalc.BarSpaces.ToString());
            lstVwResults.Items.Add(lvItemNoSpaces);

            // Number Of Bars            
            ListViewItem lvItemNoBars = new ListViewItem();
            lvItemNoBars.Text = "Number Of Bars";
            lvItemNoBars.Group = LstVwOutGrp;
            int nBundle = m_BarCalc.BundleCount;
            int nNumStps = m_BarCalc.BarCount/nBundle;
            int nBarCnt = m_BarCalc.BarCount;
            string sNumBars = System.String.Format("{0} x {1} = {2}", nNumStps, nBundle, nBarCnt);
            lvItemNoBars.SubItems.Add(sNumBars);
            lstVwResults.Items.Add(lvItemNoBars);

            // Remainder            
            ListViewItem lvItemRemainder = new ListViewItem();
            lvItemRemainder.Text = "Remainder";
            lvItemRemainder.Group = LstVwOutGrp;
            lvItemRemainder.SubItems.Add(GetLengthString(m_BarCalc.Remainder, "Ft"));
            lstVwResults.Items.Add(lvItemRemainder);

            // Output Bar Spacing Results
            lstVwResults.Groups.Add(LstVwOutGrp);
        }

        private string GetLengthString(double dValue, string sUnit)
        {
            string sValue = System.String.Format("{0:0.0000} {1}", dValue, sUnit);
            return sValue;
        }
        #endregion
    }
}
