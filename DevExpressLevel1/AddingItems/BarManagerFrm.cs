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

namespace AddingItems
{
    public partial class BarManagerFrm : DevExpress.XtraBars.TabForm
    {
        public BarManagerFrm()
        {
            InitializeComponent();
        }

        private void tabFormControl1_PageCreated(object sender, DevExpress.XtraBars.PageCreatedEventArgs e)
        {
            e.Page.ContentContainer.Controls.Add(new BarUserControl());
        }
    }
}