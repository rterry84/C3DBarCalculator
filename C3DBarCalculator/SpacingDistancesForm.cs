using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C3DBarCalculator
{
    public partial class SpacingDistancesForm : Form
    {
        public SpacingDistancesForm()
        {
            InitializeComponent();
        }

        private List<double> m_DistList = new List<double>();

        public void SetDistanceList(List<double> DistList)
        {
            m_DistList.Clear();
            m_DistList = DistList;

            lbxDistances.Items.Clear();
            foreach (double dDistance in m_DistList)
            {
                string sDistance = System.String.Format("{0:0.0000}", dDistance);
                lbxDistances.Items.Add(sDistance);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
