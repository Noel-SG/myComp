using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myComp {
    public partial class home : Form {
        public home() {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e) {
            String q1 = Environment.UserName;
            txtFLDUsrLogged.Text = Convert.ToString(q1);

            String q2 = Environment.MachineName;
            txtFLDDeviceName.Text = Convert.ToString(q2);

            String q8 = (Environment.OSVersion.ToString());
            txtFLDOS.Text = q8;

            String q9 = Environment.OSVersion.Platform.ToString();
            txtFLDOSPlatform.Text = q9;

            String q10 = Environment.OSVersion.Version.ToString();
            txtFLDOSVersion.Text = q10;

        }
    }
}
