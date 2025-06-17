using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFs
{
    public partial class ScheduleFrm : DevExpress.XtraEditors.XtraForm
    {
        private SchedulerControl schedulerControl;
        private SqlDataAdapter appointmentsAdapter;
        private SqlDataAdapter resourcesAdapter;
        private DataSet AppointmentsDataSet;
        private DataTable appointmentsTable;
        private DataTable resourcesTable;
        private SchedulerDataStorage schedulerDataStorage;
        private static DBClass DBObj = new DBClass();
        private SqlConnection connection = DBObj.sqlConn;
        public ScheduleFrm()
        {
            InitializeComponent();
            schedulerControl = schedulerControl1;
        }


        public void CreateDataSet()
        {
            AppointmentsDataSet = new DataSet();

            // Create Appointments table
            appointmentsTable = new DataTable("Appointments");
            appointmentsTable.Columns.Add("UniqueID", typeof(int));
            appointmentsTable.Columns.Add("Type", typeof(int));
            appointmentsTable.Columns.Add("StartDate", typeof(DateTime));
            appointmentsTable.Columns.Add("EndDate", typeof(DateTime));
            appointmentsTable.Columns.Add("AllDay", typeof(bool));
            appointmentsTable.Columns.Add("Subject", typeof(string));
            appointmentsTable.Columns.Add("Location", typeof(string));
            appointmentsTable.Columns.Add("Description", typeof(string));
            appointmentsTable.Columns.Add("Status", typeof(int));
            appointmentsTable.Columns.Add("Label", typeof(int));
            appointmentsTable.Columns.Add("ResourceID", typeof(int));
            appointmentsTable.Columns.Add("ReminderInfo", typeof(string));
            appointmentsTable.Columns.Add("RecurrenceInfo", typeof(string));
            appointmentsTable.Columns.Add("TimeZoneId", typeof(string));

            // Create Resources table
            resourcesTable = new DataTable("Resources");
            resourcesTable.Columns.Add("UniqueID", typeof(int));
            resourcesTable.Columns.Add("ResourceID", typeof(int));
            resourcesTable.Columns.Add("ResourceName", typeof(string));
            resourcesTable.Columns.Add("Color", typeof(int));
            resourcesTable.Columns.Add("Image", typeof(byte[]));

            AppointmentsDataSet.Tables.Add(appointmentsTable);
            AppointmentsDataSet.Tables.Add(resourcesTable);


            // Trigger the DataStorage to refresh its data
            schedulerControl1.DataStorage.Appointments.DataSource = appointmentsTable;
            schedulerControl1.DataStorage.Resources.DataSource = resourcesTable;
            schedulerControl1.DataStorage.RefreshData();
            schedulerControl1.Refresh();
        }

        public void LoadData(DataSet dataSet)
        {
            DBObj.HandleDataAdapter("SELECT * FROM Appointments", ref appointmentsAdapter);
            DBObj.HandleDataAdapter("SELECT * FROM Resources", ref resourcesAdapter);

            appointmentsAdapter.Fill(dataSet, "Appointments");
            resourcesAdapter.Fill(dataSet, "Resources");
        }

        public void BindToDataSet(DataSet dataSet)
        {
            schedulerDataStorage = new SchedulerDataStorage();

            // Configure Appointment DataSource
            schedulerDataStorage.Appointments.DataSource = dataSet.Tables["Appointments"];
            schedulerDataStorage.Appointments.Mappings.AppointmentId = "UniqueID";
            schedulerDataStorage.Appointments.Mappings.Subject = "Subject";
            schedulerDataStorage.Appointments.Mappings.AllDay = "AllDay";
            schedulerDataStorage.Appointments.Mappings.Type = "Type";
            schedulerDataStorage.Appointments.Mappings.Status = "Status";
            schedulerDataStorage.Appointments.Mappings.TimeZoneId = "TimeZoneId";
            schedulerDataStorage.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            schedulerDataStorage.Appointments.Mappings.Start = "StartDate";
            schedulerDataStorage.Appointments.Mappings.End = "EndDate";
            schedulerDataStorage.Appointments.Mappings.Location = "Location";
            schedulerDataStorage.Appointments.Mappings.Description = "Description";
            schedulerDataStorage.Appointments.Mappings.Label = "Label";
            schedulerDataStorage.Appointments.Mappings.ResourceId = "ResourceID";
            schedulerDataStorage.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            // Configure Resource DataSource

            schedulerDataStorage.Resources.DataSource = dataSet.Tables["Resources"];
            schedulerDataStorage.Resources.Mappings.Id = "ResourceID";
            schedulerDataStorage.Resources.Mappings.Caption = "ResourceName";
            schedulerDataStorage.Resources.Mappings.Color = "Color";
            schedulerDataStorage.Resources.Mappings.Image = "Image";

            schedulerControl.DataStorage = schedulerDataStorage;
            schedulerDataStorage.AppointmentsChanged += OnAppointmentChangedInsertedDeleted;
            schedulerDataStorage.AppointmentsInserted += OnAppointmentChangedInsertedDeleted;
            schedulerDataStorage.AppointmentsDeleted += OnAppointmentChangedInsertedDeleted;
        }
        private void ScheduleFrm_Load(object sender, EventArgs e)
        {
            CreateDataSet();
            LoadData(AppointmentsDataSet);
            BindToDataSet(AppointmentsDataSet);

            schedulerControl1.Start = DateTime.Today;
            schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
            schedulerControl1.DayView.TopRowTime = new TimeSpan(10, 0, 0);
            schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            schedulerControl1.DayView.ResourcesPerPage = 2;
            schedulerControl1.DayView.TimeIndicatorDisplayOptions.ShowOverAppointment = true;
            this.schedulerDataStorage1.AppointmentsChanged += OnAppointmentChangedInsertedDeleted;
            this.schedulerDataStorage1.AppointmentsInserted += OnAppointmentChangedInsertedDeleted;
            this.schedulerDataStorage1.AppointmentsDeleted += OnAppointmentChangedInsertedDeleted;
        }
        private void OnAppointmentChangedInsertedDeleted(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                appointmentsAdapter.Update(appointmentsTable);
                AppointmentsDataSet.AcceptChanges();
                appointmentsTable.AcceptChanges();
                AppointmentsDataSet.Clear();
                LoadData(AppointmentsDataSet);
                schedulerControl1.DataStorage.RefreshData();
                schedulerControl1.Refresh();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "From Schedule Operations");
            }
            connection.Close();
        }

    }
}




