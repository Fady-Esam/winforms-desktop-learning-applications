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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WFs
{
    public partial class CustomersFrm : DevExpress.XtraEditors.XtraForm
    {
        DBClass DBObj = new DBClass();
        public CustomersFrm()
        {
            InitializeComponent();
        }

        private void CustomersFrm_Load(object sender, EventArgs e)
        {
            LimitationAmountTxt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            LimitationAmountTxt.Properties.Mask.EditMask = "n2";
            DiscPercTxt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            DiscPercTxt.Properties.Mask.EditMask = "n2";   
        }

        private void FillLookUpEdit(string query, string valueMember, string displayMember, LookUpEdit name, string caption)
        {
            name.Properties.DataSource = DBObj.dataget(query, "get");
            name.Properties.DisplayMember = displayMember;
            name.Properties.ValueMember = valueMember;
            name.Properties.Columns.Add(new LookUpColumnInfo(displayMember, caption));
        }
    }
}