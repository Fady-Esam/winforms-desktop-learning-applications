using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1
{
    public partial class TimeEditFrm : DevExpress.XtraEditors.XtraForm
    {
        public TimeEditFrm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TimeEditFrm_Load(object sender, EventArgs e)
        {
            barCodeControl1.Symbology = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            Text = "https://www.example.com";
            BreadCrumbNode rootNode = new BreadCrumbNode("Ffdafds");
            breadCrumbEdit1.Properties.Nodes.Add(rootNode);

            // Add child nodes
            BreadCrumbNode childNode1 = new BreadCrumbNode("Child 1");
            BreadCrumbNode childNode2 = new BreadCrumbNode("Child 2");
            rootNode.Properties.Nodes.Add(childNode1);
            rootNode.Properties.Nodes.Add(childNode2);

            childNode1.Properties.Nodes.Add(new BreadCrumbNode("Sub-Child 1.1"));
            childNode1.Properties.Nodes.Add(new BreadCrumbNode("Sub-Child 1.2"));
            childNode2.Properties.Nodes.Add(new BreadCrumbNode("Sub-Child 2.1"));
            childNode2.Properties.Nodes.Add(new BreadCrumbNode("Sub-Child 2.2"));

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            alertControl1 = new AlertControl();

            // Optional: Customize the AlertControl appearance and behavior
            alertControl1.AutoFormDelay = 5000; // Alert will be visible for 5 seconds
            alertControl1.AllowHtmlText = true; // Allows HTML formatting in alert messages

            AlertInfo info = new AlertInfo("Warning", "You Pressed AlertInfo");

            // Show the alert
            alertControl1.Show(this, info);
        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {


        }

        private void buttonEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Search)
            {
                MessageBox.Show("Search button clicked!");
            }
            else if (e.Button.Kind == ButtonPredefines.Clear)
            {
                buttonEdit1.Text = string.Empty;
                MessageBox.Show("Clear button clicked!");
            }
        }

        private void breadCrumbEdit1_PathChanged(object sender, BreadCrumbPathChangedEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}