Imports DevExpress.XtraEditors.Controls

Public Class ServiceFrm
    Private DBObj As DBHelper = New DBHelper()
    Private Sub GetDepartmentsLue()
        Dim qry As String = "SELECT * FROM DepartmentTbl"
        lueDepartment.Properties.DataSource = DBObj.GetData(qry)
        lueDepartment.Properties.DisplayMember = "Department"
        lueDepartment.Properties.ValueMember = "DepartmentId"
    End Sub
    Private Sub GetCurrencyLue()
        Dim qry As String = "SELECT * FROM CurrencyTbl"
        lueCurrency.Properties.DataSource = DBObj.GetData(qry)
        lueCurrency.Properties.DisplayMember = "Currency"
        lueCurrency.Properties.ValueMember = "CurrencyId"
    End Sub
    Private Sub GetServiceTypesLue()
        Dim qry As String = "SELECT * FROM ServiceTypesTbl"
        lueServiceType.Properties.DataSource = DBObj.GetData(qry)
        lueServiceType.Properties.DisplayMember = "Type"
        lueServiceType.Properties.ValueMember = "ServiceTypeId"

    End Sub

    Private Sub ServiceFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDepartmentsLue()
        GetCurrencyLue()
        GetServiceTypesLue()
        lueServiceType.EditValue = 1
        lueDepartment.EditValue = 1
        lueCurrency.EditValue = 1
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim serviceTypeId As String = If(lueServiceType.EditValue IsNot Nothing AndAlso lueServiceType.EditValue.ToString() <> "", lueServiceType.EditValue.ToString(), "NULL")
        Dim currencyId As String = If(lueCurrency.EditValue IsNot Nothing AndAlso lueCurrency.EditValue.ToString() <> "", lueCurrency.EditValue.ToString(), "NULL")
        Dim departmentId As String = If(lueDepartment.EditValue IsNot Nothing AndAlso lueDepartment.EditValue.ToString() <> "", lueDepartment.EditValue.ToString(), "NULL")
        Dim servNum As String = If(txtServNum.Text <> "", $"'{txtServNum.Text}'", "NULL")
        Dim description As String = If(txtDescription.Text <> "", $"'{txtDescription.Text}'", "NULL")
        Dim amount As String = If(TxtAmount.Text <> "", TxtAmount.Text, "NULL")
        Dim executor As String = If(TxtExecutor.Text <> "", $"'{TxtExecutor.Text}'", "NULL")
        Dim client As String = If(TxtClient.Text <> "", $"'{TxtClient.Text}'", "NULL")

        ' Construct the SQL query using string interpolation
        Dim SaveQry = $"INSERT INTO ServicesTbl
           (ServiceTypeId, CurrencyId, DepartmentId, Num, Description, Amount, Executor, Client)
     VALUES ({serviceTypeId}, {currencyId}, {departmentId}, {servNum}, {description}, {amount}, {executor}, {client});"


        Dim retNum As Integer = DBObj.ExecuteNonQuery(SaveQry)
        If retNum > 0 Then
            MsgBox("Data Saved Successfully")
        End If

    End Sub
End Class