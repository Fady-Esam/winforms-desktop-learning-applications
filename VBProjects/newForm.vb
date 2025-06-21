Imports DevExpress.XtraGrid

Public Class newForm
    Dim dt As New DataTable()
    Shared DBHelperObj As New DBHelper()
    Dim qry As String = "SELECT e.EmployeeID, e.FirstName, e.LastName, e.Salary, e.Age, d.DepartmentID FROM Employees e LEFT JOIN Departments d ON e.DepartmentID = d.DepartmentID"
    Private Sub CallData()
        dt = DBHelperObj.GetData(qry)
        gdc.DataSource = dt

    End Sub

    Private Sub newForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lueDepartments.DataSource = DBHelperObj.GetData("SELECT * FROM Departments")
        CallData()
    End Sub

    'Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
    '    If DBHelperObj.SaveChanges(dt, qry) Then
    '        CallData()
    '        MessageBox.Show("Saved successfully")
    '    End If
    'End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        For Each row As DataRow In dt.Rows
            If row.RowState = DataRowState.Added Then

                DBHelperObj.ExecuteNonQuery("insert into Employees (FirstName, LastName, Salary, Age, DepartmentID) values (@FirstName, @LastName, @Salary, @Age, @DepartmentID);", New Dictionary(Of String, Object) From {{"@FirstName", row("FirstName")}, {"@LastName", row("LastName")}, {"@Salary", row("Salary")}, {"@Age", row("Age")}, {"@DepartmentID", row("DepartmentID")}})
            ElseIf row.RowState = DataRowState.Modified Then

                DBHelperObj.ExecuteNonQuery("update Employees set FirstName = @FirstName, LastName = @LastName, Salary = @Salary, Age = @Age, DepartmentID = @DepartmentID where EmployeeID = @EmployeeID;", New Dictionary(Of String, Object) From {{"@FirstName", row("FirstName")}, {"@LastName", row("LastName")}, {"@Salary", row("Salary")}, {"@Age", row("Age")}, {"@DepartmentID", row("DepartmentID")}, {"@EmployeeID", row("EmployeeID")}})
            ElseIf row.RowState = DataRowState.Deleted Then
                DBHelperObj.ExecuteNonQuery("delete from Employees where EmployeeID = @EmployeeID", New Dictionary(Of String, Object) From {{"@EmployeeID", row("EmployeeID", DataRowVersion.Original)}})
            End If
        Next
        CallData()
        MessageBox.Show("Saved successfully")
    End Sub


    Private Sub gdc_KeyDown(sender As Object, e As KeyEventArgs) Handles gdc.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim view = TryCast(gdc.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            If view Is Nothing Then Return

            Dim selectedRowHandle = view.FocusedRowHandle
            If selectedRowHandle < 0 Then Return ' No valid row selected

            ' Optional: Confirm delete
            If MessageBox.Show("Are you sure to delete the selected row?", "Confirm Delete", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
                Return
            End If

            ' Delete the row
            view.DeleteRow(selectedRowHandle)
        End If
    End Sub

    Private Sub trl_FocusedNodeChanged(sender As Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs)

    End Sub
End Class