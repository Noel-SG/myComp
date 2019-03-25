using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;


namespace myComp {
    public partial class home : Form {
        public home() {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e) {

            GeneralInformation();
            ProcessorInformation();

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e) {

        }

        void GeneralInformation() {
            String q1 = Environment.UserName;
            txtFLDUsrLogged.Text = Convert.ToString(q1);

            String q2 = Environment.MachineName;
            txtFLDDeviceName.Text = Convert.ToString(q2);

            String q3 = (Environment.OSVersion.ToString());
            txtFLDOS.Text = q3;

            String q4 = Environment.OSVersion.Platform.ToString();
            txtFLDOSPlatform.Text = q4;

            String q5 = Environment.OSVersion.Version.ToString();
            txtFLDOSVersion.Text = q5;
        }

        void ProcessorInformation() {
            //txtFLDProcessorManufacturer = HardwareInfo.GetCPUManufacturer();

            int processorCount = Environment.ProcessorCount;
            txtFLDProcessorCount.Text = Convert.ToString(processorCount);


        }

        private void button2_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
