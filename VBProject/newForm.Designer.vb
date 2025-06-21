<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class newForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.gdc = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FirstName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LastName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Age = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Salary = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Department = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lueDepartments = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.gdc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDepartments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnSave)
        Me.LayoutControl1.Controls.Add(Me.gdc)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(874, 567)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(672, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(190, 27)
        Me.btnSave.StyleController = Me.LayoutControl1
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        '
        'gdc
        '
        Me.gdc.Location = New System.Drawing.Point(12, 43)
        Me.gdc.MainView = Me.GridView1
        Me.gdc.Name = "gdc"
        Me.gdc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lueDepartments})
        Me.gdc.Size = New System.Drawing.Size(850, 512)
        Me.gdc.TabIndex = 4
        Me.gdc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ID, Me.FirstName, Me.LastName, Me.Age, Me.Salary, Me.Department})
        Me.GridView1.GridControl = Me.gdc
        Me.GridView1.Name = "GridView1"
        Me.GridView1.NewItemRowText = "Add New Item"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'ID
        '
        Me.ID.Caption = "ID"
        Me.ID.FieldName = "EmployeeID"
        Me.ID.MinWidth = 25
        Me.ID.Name = "ID"
        Me.ID.OptionsColumn.AllowEdit = False
        Me.ID.Visible = True
        Me.ID.VisibleIndex = 0
        Me.ID.Width = 94
        '
        'FirstName
        '
        Me.FirstName.Caption = "First Name"
        Me.FirstName.FieldName = "FirstName"
        Me.FirstName.MinWidth = 25
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Visible = True
        Me.FirstName.VisibleIndex = 1
        Me.FirstName.Width = 94
        '
        'LastName
        '
        Me.LastName.Caption = "Last Name"
        Me.LastName.FieldName = "LastName"
        Me.LastName.MinWidth = 25
        Me.LastName.Name = "LastName"
        Me.LastName.Visible = True
        Me.LastName.VisibleIndex = 2
        Me.LastName.Width = 94
        '
        'Age
        '
        Me.Age.Caption = "Age"
        Me.Age.FieldName = "Age"
        Me.Age.MinWidth = 25
        Me.Age.Name = "Age"
        Me.Age.Visible = True
        Me.Age.VisibleIndex = 3
        Me.Age.Width = 94
        '
        'Salary
        '
        Me.Salary.Caption = "Salary"
        Me.Salary.FieldName = "Salary"
        Me.Salary.MinWidth = 25
        Me.Salary.Name = "Salary"
        Me.Salary.Visible = True
        Me.Salary.VisibleIndex = 4
        Me.Salary.Width = 94
        '
        'Department
        '
        Me.Department.Caption = "Department"
        Me.Department.ColumnEdit = Me.lueDepartments
        Me.Department.FieldName = "DepartmentID"
        Me.Department.MinWidth = 25
        Me.Department.Name = "Department"
        Me.Department.Visible = True
        Me.Department.VisibleIndex = 5
        Me.Department.Width = 94
        '
        'lueDepartments
        '
        Me.lueDepartments.AutoHeight = False
        Me.lueDepartments.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDepartments.DisplayMember = "Name"
        Me.lueDepartments.Name = "lueDepartments"
        Me.lueDepartments.ValueMember = "DepartmentID"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(874, 567)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.gdc
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 31)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(854, 516)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnSave
        Me.LayoutControlItem2.Location = New System.Drawing.Point(660, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(194, 31)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(660, 31)
        '
        'newForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 567)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "newForm"
        Me.Text = "newForm"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.gdc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDepartments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents gdc As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FirstName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LastName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Age As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Salary As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Department As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lueDepartments As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
