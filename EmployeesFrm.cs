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

namespace WFs
{
    public partial class EmployeesFrm : DevExpress.XtraEditors.XtraForm
    {
        DataTable GenderDt, NationalityDt;
        public EmployeesFrm()
        {
            InitializeComponent();
        }

        private void EmployeesFrm_Load(object sender, EventArgs e)
        {
            GenderDataTable();
            NationalityDataTable();
        }
        public void GenderDataTable()
        {
            GenderDt = new DataTable();
            GenderDt.Columns.Add("Gender", typeof(string));
            GenderDt.Rows.Add("Male");
            GenderDt.Rows.Add("Female");
            lueGender.Properties.DataSource = GenderDt;
        }
        public void NationalityDataTable()
        {
            NationalityDt = new DataTable();
            NationalityDt.Columns.Add("ID", typeof(int));
            NationalityDt.Columns.Add("Name", typeof(string));
            NationalityDt.Rows.Add(1, "Egyptian");
            lueNationality.Properties.ValueMember = "ID";
            lueNationality.Properties.DisplayMember = "Name";
            lueNationality.Properties.DataSource = NationalityDt;
        }
    }
}