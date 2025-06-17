using DevExpress.XtraEditors;
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
    public partial class ContsFrm : DevExpress.XtraEditors.XtraForm
    {
        public ContsFrm()
        {
            InitializeComponent();
        }

        private void ContsFrm_Load(object sender, EventArgs e)
        {
            double[] data = { 10, 20, 15, 25, 30, 20, 10, 15, 20, 25 };
            sparklineEdit1.EditValue = data;

            List<TokenEditToken> tokens = new List<TokenEditToken>
            {
                new TokenEditToken("Token 1"),
                new TokenEditToken("Token 2"),
                new TokenEditToken("Token 3")
            };

            // Set the tokens to the TokenEdit
            tokenEdit1.Properties.Tokens.AddRange(tokens);

            // imageComboBoxEdit1.Properties.SmallImages.AddImage(Properties.Resources.Icon1); // Assuming Icon1 is an image resource
            // imageComboBoxEdit1.Properties.SmallImages.AddImage(Properties.Resources.Icon2);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= progressBarControl1.Properties.Maximum; i++)
            {
                progressBarControl1.Position = i;
                Application.DoEvents(); 
                System.Threading.Thread.Sleep(50); 
            }
        }

        private void memoEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}