<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ServiceFrm
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
        Me.BtnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDescription = New System.Windows.Forms.RichTextBox()
        Me.TxtClient = New DevExpress.XtraEditors.TextEdit()
        Me.TxtExecutor = New DevExpress.XtraEditors.TextEdit()
        Me.lueDepartment = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueCurrency = New DevExpress.XtraEditors.LookUpEdit()
        Me.TxtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.lueServiceType = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtServNum = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TxtClient.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtExecutor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCurrency.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueServiceType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServNum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.BtnSave)
        Me.LayoutControl1.Controls.Add(Me.txtDescription)
        Me.LayoutControl1.Controls.Add(Me.TxtClient)
        Me.LayoutControl1.Controls.Add(Me.TxtExecutor)
        Me.LayoutControl1.Controls.Add(Me.lueDepartment)
        Me.LayoutControl1.Controls.Add(Me.lueCurrency)
        Me.LayoutControl1.Controls.Add(Me.TxtAmount)
        Me.LayoutControl1.Controls.Add(Me.lueServiceType)
        Me.LayoutControl1.Controls.Add(Me.txtServNum)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(817, 537)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'BtnSave
        '
        Me.BtnSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.BtnSave.Appearance.Options.UseBackColor = True
        Me.BtnSave.Location = New System.Drawing.Point(608, 397)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(197, 27)
        Me.BtnSave.StyleController = Me.LayoutControl1
        Me.BtnSave.TabIndex = 12
        Me.BtnSave.Text = "Save"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(148, 168)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(657, 225)
        Me.txtDescription.TabIndex = 11
        Me.txtDescription.Text = ""
        '
        'TxtClient
        '
        Me.TxtClient.Location = New System.Drawing.Point(146, 87)
        Me.TxtClient.Name = "TxtClient"
        Me.TxtClient.Properties.Appearance.Options.UseTextOptions = True
        Me.TxtClient.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TxtClient.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TxtClient.Properties.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.TxtClient.Size = New System.Drawing.Size(202, 34)
        Me.TxtClient.StyleController = Me.LayoutControl1
        Me.TxtClient.TabIndex = 10
        '
        'TxtExecutor
        '
        Me.TxtExecutor.Location = New System.Drawing.Point(488, 87)
        Me.TxtExecutor.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtExecutor.Name = "TxtExecutor"
        Me.TxtExecutor.Properties.Appearance.Options.UseTextOptions = True
        Me.TxtExecutor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TxtExecutor.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TxtExecutor.Properties.Padding = New System.Windows.Forms.Padding(0, 9, 0, 0)
        Me.TxtExecutor.Size = New System.Drawing.Size(317, 33)
        Me.TxtExecutor.StyleController = Me.LayoutControl1
        Me.TxtExecutor.TabIndex = 9
        '
        'lueDepartment
        '
        Me.lueDepartment.Location = New System.Drawing.Point(148, 129)
        Me.lueDepartment.Name = "lueDepartment"
        Me.lueDepartment.Properties.Appearance.Options.UseTextOptions = True
        Me.lueDepartment.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lueDepartment.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lueDepartment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDepartment.Properties.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.lueDepartment.Size = New System.Drawing.Size(657, 34)
        Me.lueDepartment.StyleController = Me.LayoutControl1
        Me.lueDepartment.TabIndex = 8
        '
        'lueCurrency
        '
        Me.lueCurrency.Location = New System.Drawing.Point(488, 49)
        Me.lueCurrency.Name = "lueCurrency"
        Me.lueCurrency.Properties.Appearance.Options.UseTextOptions = True
        Me.lueCurrency.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lueCurrency.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lueCurrency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCurrency.Properties.Padding = New System.Windows.Forms.Padding(0, 7, 0, 0)
        Me.lueCurrency.Size = New System.Drawing.Size(317, 31)
        Me.lueCurrency.StyleController = Me.LayoutControl1
        Me.lueCurrency.TabIndex = 7
        '
        'TxtAmount
        '
        Me.TxtAmount.Location = New System.Drawing.Point(148, 49)
        Me.TxtAmount.Name = "TxtAmount"
        Me.TxtAmount.Properties.Appearance.Options.UseTextOptions = True
        Me.TxtAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TxtAmount.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.TxtAmount.Properties.Padding = New System.Windows.Forms.Padding(0, 7, 0, 0)
        Me.TxtAmount.Size = New System.Drawing.Size(200, 31)
        Me.TxtAmount.StyleController = Me.LayoutControl1
        Me.TxtAmount.TabIndex = 6
        '
        'lueServiceType
        '
        Me.lueServiceType.Location = New System.Drawing.Point(488, 12)
        Me.lueServiceType.Name = "lueServiceType"
        Me.lueServiceType.Properties.Appearance.Options.UseTextOptions = True
        Me.lueServiceType.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lueServiceType.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lueServiceType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueServiceType.Properties.Padding = New System.Windows.Forms.Padding(0, 7, 0, 0)
        Me.lueServiceType.Size = New System.Drawing.Size(317, 31)
        Me.lueServiceType.StyleController = Me.LayoutControl1
        Me.lueServiceType.TabIndex = 5
        '
        'txtServNum
        '
        Me.txtServNum.Location = New System.Drawing.Point(148, 12)
        Me.txtServNum.Name = "txtServNum"
        Me.txtServNum.Properties.Appearance.Options.UseTextOptions = True
        Me.txtServNum.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtServNum.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtServNum.Properties.Padding = New System.Windows.Forms.Padding(0, 7, 0, 0)
        Me.txtServNum.Size = New System.Drawing.Size(200, 31)
        Me.txtServNum.StyleController = Me.LayoutControl1
        Me.txtServNum.TabIndex = 4
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.EmptySpaceItem2, Me.LayoutControlItem9, Me.LayoutControlItem7, Me.LayoutControlItem5, Me.EmptySpaceItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(817, 537)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.Control = Me.txtServNum
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(202, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 2, 2, 2)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(340, 37)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Service Number"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(120, 18)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.Control = Me.lueServiceType
        Me.LayoutControlItem1.Location = New System.Drawing.Point(340, 0)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(202, 26)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.OptionsPrint.AppearanceItem.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem1.OptionsPrint.AppearanceItem.Options.UseFont = True
        Me.LayoutControlItem1.OptionsPrint.AppearanceItemControl.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem1.OptionsPrint.AppearanceItemControl.Options.UseFont = True
        Me.LayoutControlItem1.OptionsPrint.AppearanceItemText.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem1.OptionsPrint.AppearanceItemText.Options.UseFont = True
        Me.LayoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 2, 2, 2)
        Me.LayoutControlItem1.Size = New System.Drawing.Size(457, 37)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Service Type"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(120, 18)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem3.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem3.Control = Me.TxtAmount
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 37)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(202, 26)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 2, 2, 2)
        Me.LayoutControlItem3.Size = New System.Drawing.Size(340, 38)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "Amount"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(120, 18)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem4.Control = Me.lueCurrency
        Me.LayoutControlItem4.Location = New System.Drawing.Point(340, 37)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(202, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 2, 2, 2)
        Me.LayoutControlItem4.Size = New System.Drawing.Size(457, 38)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "Currency"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(120, 18)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem6.Control = Me.TxtExecutor
        Me.LayoutControlItem6.Location = New System.Drawing.Point(340, 75)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(202, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 2, 2, 2)
        Me.LayoutControlItem6.Size = New System.Drawing.Size(457, 42)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Executor"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(120, 18)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem8.Control = Me.txtDescription
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 156)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(165, 29)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 2, 2, 2)
        Me.LayoutControlItem8.Size = New System.Drawing.Size(797, 229)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "Description"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(120, 18)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 385)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(596, 31)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.BtnSave
        Me.LayoutControlItem9.Location = New System.Drawing.Point(596, 385)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(201, 31)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem7.Control = Me.TxtClient
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 75)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(200, 26)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 2, 2, 2)
        Me.LayoutControlItem7.Size = New System.Drawing.Size(340, 42)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Client"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(120, 18)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem5.Control = Me.lueDepartment
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 117)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(202, 26)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 2, 2, 2)
        Me.LayoutControlItem5.Size = New System.Drawing.Size(797, 39)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Department"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(120, 18)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 416)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(797, 101)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'ServiceFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 537)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ServiceFrm"
        Me.Text = "ServiceFrm"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TxtClient.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtExecutor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCurrency.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueServiceType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServNum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtServNum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lueServiceType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lueDepartment As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueCurrency As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TxtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TxtClient As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtExecutor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtDescription As RichTextBox
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
