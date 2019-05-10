using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore
{
    public partial class MainAppForm : Form
    {
        public MainAppForm()
        {
            InitializeComponent();
            sidePanel.Height = btn_MyProfile.Height;
        }

        private void btn_MyProfile_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_MyProfile.Height;
            sidePanel.Top = btn_MyProfile.Top;
        }

        private void btn_ShoppingChart_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_ShoppingChart.Height;
            sidePanel.Top = btn_ShoppingChart.Top;
        }
    }
}
