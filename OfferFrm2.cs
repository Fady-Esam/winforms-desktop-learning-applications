using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace WFs
{
    public partial class OfferFrm2 : DevExpress.XtraEditors.XtraForm
    {
        DBClass dbObj = new DBClass();
        public OfferFrm2()
        {
            InitializeComponent();
        }


         private int ContractID = 1;
         private int BranchID = 2;
        private void fetchData(int id)
        {
            string query = "SELECT * FROM tblhbContractOffers WHERE ContractID = " + id;

            DataTable dt = dbObj.dataget(query, "get");
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[dt.Rows.Count - 1];
                txtMax.Text = dr["Max"].ToString();
                txtMin.Text = dr["Min"].ToString();
                txtRollFrom.Text = dr["RollingFrom"].ToString();
                txtRollTo.Text = dr["RollingTo"].ToString();
                txtAge.Text = dr["Age"].ToString();
                dtBookFrom.Text = dr["BookFrom"].ToString();
                dtBookTo.Text = dr["BookTo"].ToString();
                cbApplicableOn.Text = dr["ApplicableOn"].ToString();
                cbApplyAs.Text = dr["ApplyAs"].ToString();
                cbApplyTo.Text = dr["ApplyTo"].ToString();
                cbCalculationMethod.Text = dr["CalculationMethod"].ToString();
                cbOfferType.Text = dr["OfferType"].ToString();
                cbBoard.Text = dr["Board"].ToString();
                cbRoomCategory.Text = dr["RoomCategory"].ToString();
                cbApplicableOn.Text = dr["ApplicableOn"].ToString();
                cbCalculationMethod.Text = dr["CalculationMethod"].ToString();
                offerId = int.Parse(dr["hbContractOfferID"].ToString());
            }
        }



        private void OfferFrm2_Load(object sender, EventArgs e)
        {
            int[] OfferTypeData = { 1, 2, 3};
            cbOfferType.Properties.DataSource = OfferTypeData;
            int[] BoardData = { 1, 2, 3};
            cbBoard.Properties.DataSource = BoardData;
            int[] RoomCategoryData = { 1, 2, 3};
            cbRoomCategory.Properties.DataSource = RoomCategoryData;
            int[] ApplicableOnData = {1, 2, 3};
            cbApplicableOn.Properties.DataSource = ApplicableOnData;
            int[] ApplyAsData = { 1, 2, 3};
            cbApplyAs.Properties.DataSource = ApplyAsData;
            int[] CalculationMethodData = { 1, 2, 3};
            cbCalculationMethod.Properties.DataSource = CalculationMethodData;
            int[] ApplyToData = { 1, 2, 3};
            cbApplyTo.Properties.DataSource = ApplyToData;
            // fetchData(ContractID);
        }
        private int offerId = -1;
        private void getOfferTypes()
        {
            string query = "SELECT * FROM tblhbContractOfferType";
            cbOfferType.Properties.DataSource = dbObj.dataget(query, "get");
            cbOfferType.Properties.ValueMember = "OfferTypeID";
            cbOfferType.Properties.DisplayMember = "OfferTypeName";
            // cbOfferType.Properties.Columns.Add(new LookUpColumnInfo("OfferTypeName", "Offer Type"));
        }
        private void getRoomCategories()
        {    
            string query = "SELECT * FROM tblhbRoomCategory";
            cbRoomCategory.Properties.DataSource = dbObj.dataget(query, "get");
            cbRoomCategory.Properties.ValueMember = "hRoomCategoryID";
            cbRoomCategory.Properties.DisplayMember = "RoomCategory";
            cbRoomCategory.Properties.Columns.Add(new LookUpColumnInfo("RoomCategory", "Room Category"));
        }
        private void getBoards()
        {
            string query = "SELECT * FROM tblhbContractBoard";
            cbBoard.Properties.DataSource = dbObj.dataget(query, "get");
            cbBoard.Properties.ValueMember = "BoardID";
            cbBoard.Properties.DisplayMember = "BoardName";
            cbBoard.Properties.Columns.Add(new LookUpColumnInfo("BoardName", "Board"));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (offerId ==  -1)
            {
                
                string query1 = "INSERT INTO tblhbContractOffers (OfferType, ContractID, Min, Max, BookFrom, BookTo, RollingFrom, RollingTo, RoomCategory, Board, ApplicableOn, ApplyAs, CalculationMethod, ApplyTo, Age, BranchID) " +
                    $"VALUES ({cbOfferType.Text}, {ContractID}, {int.Parse(txtMin.Text.ToString())}, {int.Parse(txtMax.Text.ToString())} , '{DateTime.Parse(dtBookFrom.Text)}', '{DateTime.Parse(dtBookTo.Text)}', {decimal.Parse(txtRollFrom.Text.ToString())}, {decimal.Parse(txtRollTo.Text.ToString())}, {cbRoomCategory.Text}, {cbBoard.Text}, {cbApplicableOn.Text}, {cbApplyAs.Text}, {cbCalculationMethod.Text}, {cbApplyTo.Text}, {txtAge.Text}, {BranchID} ); SELECT SCOPE_IDENTITY();";
                offerId = dbObj.saveway(query1);
                MessageBox.Show(query1);
                // fetchData(ContractID);
                XtraMessageBox.Show("تم تحديث البيانات بنجاح", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                // fetchData(ContractID);
                string query2 = $"UPDATE tblhbContractOffers SET OfferType = {cbOfferType.Text}, ContractID = {ContractID}, Min = {int.Parse(txtMin.Text.ToString())}, Max = {int.Parse(txtMax.Text.ToString())}, " +
                    $"BookFrom = '{DateTime.Parse(dtBookFrom.Text)}', BookTo = '{DateTime.Parse(dtBookTo.Text)}', RollingFrom = {decimal.Parse(txtRollFrom.Text.ToString())}, RollingTo = {decimal.Parse(txtRollTo.Text.ToString())}, RoomCategory = {cbRoomCategory.Text}, " +
                    $"Board = {cbBoard.Text}, ApplicableOn = {cbApplicableOn.Text}, ApplyAs = {cbApplyAs.Text}, CalculationMethod = {cbCalculationMethod.Text}, ApplyTo = {cbApplyTo.Text}, Age = {txtAge.Text}, BranchID = {BranchID} WHERE hbContractOfferID = {offerId}";
                MessageBox.Show(query2);
                dbObj.saveway(query2);
                XtraMessageBox.Show("تم تحديث البيانات بنجاح", "تحديث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbApplyTo1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}