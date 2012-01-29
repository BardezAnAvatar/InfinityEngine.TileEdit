<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAdvancedTile
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents cmdBasicTraining As System.Windows.Forms.Button
	Public WithEvents chkHeader As System.Windows.Forms.CheckBox
	Public WithEvents cmdNewTile As System.Windows.Forms.Button
	Public WithEvents picOpenedTile As System.Windows.Forms.PictureBox
	Public WithEvents cboTileListSet As System.Windows.Forms.ComboBox
	Public WithEvents cmdOpenBitmap As System.Windows.Forms.Button
	Public WithEvents cmdSaveTIS As System.Windows.Forms.Button
	Public WithEvents CmdInsert As System.Windows.Forms.Button
	Public WithEvents cmdOpenTile As System.Windows.Forms.Button
	Public WithEvents cmdSaveTile As System.Windows.Forms.Button
	Public WithEvents cmdSaveBitmap As System.Windows.Forms.Button
	Public WithEvents picCurrentTile As System.Windows.Forms.PictureBox
	Public WithEvents cboTileBox As System.Windows.Forms.ComboBox
	Public WithEvents cmdOpenTIS As System.Windows.Forms.Button
	Public cdgDialogOpen As System.Windows.Forms.OpenFileDialog
	Public cdgDialogSave As System.Windows.Forms.SaveFileDialog
	Public WithEvents fraTIS As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAdvancedTile))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdBasicTraining = New System.Windows.Forms.Button
		Me.chkHeader = New System.Windows.Forms.CheckBox
		Me.fraTIS = New System.Windows.Forms.GroupBox
		Me.cmdNewTile = New System.Windows.Forms.Button
		Me.picOpenedTile = New System.Windows.Forms.PictureBox
		Me.cboTileListSet = New System.Windows.Forms.ComboBox
		Me.cmdOpenBitmap = New System.Windows.Forms.Button
		Me.cmdSaveTIS = New System.Windows.Forms.Button
		Me.CmdInsert = New System.Windows.Forms.Button
		Me.cmdOpenTile = New System.Windows.Forms.Button
		Me.cmdSaveTile = New System.Windows.Forms.Button
		Me.cmdSaveBitmap = New System.Windows.Forms.Button
		Me.picCurrentTile = New System.Windows.Forms.PictureBox
		Me.cboTileBox = New System.Windows.Forms.ComboBox
		Me.cmdOpenTIS = New System.Windows.Forms.Button
		Me.cdgDialogOpen = New System.Windows.Forms.OpenFileDialog
		Me.cdgDialogSave = New System.Windows.Forms.SaveFileDialog
		Me.fraTIS.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Advanced Tile Utilities"
		Me.ClientSize = New System.Drawing.Size(185, 477)
		Me.Location_Renamed = New System.Drawing.Point(4, 23)
		Me.Icon = CType(resources.GetObject("frmAdvancedTile.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmAdvancedTile"
		Me.cmdBasicTraining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdBasicTraining.Text = "Basic Mode"
		Me.cmdBasicTraining.Font = New System.Drawing.Font("Arial", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdBasicTraining.Size = New System.Drawing.Size(169, 65)
		Me.cmdBasicTraining.Location = New System.Drawing.Point(8, 408)
		Me.cmdBasicTraining.TabIndex = 10
		Me.cmdBasicTraining.BackColor = System.Drawing.SystemColors.Control
		Me.cmdBasicTraining.CausesValidation = True
		Me.cmdBasicTraining.Enabled = True
		Me.cmdBasicTraining.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdBasicTraining.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdBasicTraining.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdBasicTraining.TabStop = True
		Me.cmdBasicTraining.Name = "cmdBasicTraining"
		Me.chkHeader.Text = "TIS has header"
		Me.chkHeader.Size = New System.Drawing.Size(97, 17)
		Me.chkHeader.Location = New System.Drawing.Point(48, 24)
		Me.chkHeader.TabIndex = 2
		Me.chkHeader.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkHeader.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkHeader.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkHeader.BackColor = System.Drawing.SystemColors.Control
		Me.chkHeader.CausesValidation = True
		Me.chkHeader.Enabled = True
		Me.chkHeader.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkHeader.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkHeader.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkHeader.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkHeader.TabStop = True
		Me.chkHeader.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkHeader.Visible = True
		Me.chkHeader.Name = "chkHeader"
		Me.fraTIS.Text = "Source Tileset"
		Me.fraTIS.Size = New System.Drawing.Size(185, 401)
		Me.fraTIS.Location = New System.Drawing.Point(0, 0)
		Me.fraTIS.TabIndex = 0
		Me.fraTIS.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraTIS.BackColor = System.Drawing.SystemColors.Control
		Me.fraTIS.Enabled = True
		Me.fraTIS.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraTIS.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraTIS.Visible = True
		Me.fraTIS.Name = "fraTIS"
		Me.cmdNewTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdNewTile.Text = "Create New Tile"
		Me.cmdNewTile.Size = New System.Drawing.Size(169, 57)
		Me.cmdNewTile.Location = New System.Drawing.Point(8, 312)
		Me.cmdNewTile.TabIndex = 14
		Me.cmdNewTile.Visible = False
		Me.cmdNewTile.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdNewTile.BackColor = System.Drawing.SystemColors.Control
		Me.cmdNewTile.CausesValidation = True
		Me.cmdNewTile.Enabled = True
		Me.cmdNewTile.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdNewTile.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdNewTile.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdNewTile.TabStop = True
		Me.cmdNewTile.Name = "cmdNewTile"
		Me.picOpenedTile.Size = New System.Drawing.Size(72, 69)
		Me.picOpenedTile.Location = New System.Drawing.Point(8, 232)
		Me.picOpenedTile.TabIndex = 13
		Me.picOpenedTile.Visible = False
		Me.picOpenedTile.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picOpenedTile.Dock = System.Windows.Forms.DockStyle.None
		Me.picOpenedTile.BackColor = System.Drawing.SystemColors.Control
		Me.picOpenedTile.CausesValidation = True
		Me.picOpenedTile.Enabled = True
		Me.picOpenedTile.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picOpenedTile.Cursor = System.Windows.Forms.Cursors.Default
		Me.picOpenedTile.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picOpenedTile.TabStop = True
		Me.picOpenedTile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.picOpenedTile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picOpenedTile.Name = "picOpenedTile"
		Me.cboTileListSet.Size = New System.Drawing.Size(89, 21)
		Me.cboTileListSet.Location = New System.Drawing.Point(88, 280)
		Me.cboTileListSet.TabIndex = 12
		Me.cboTileListSet.Text = "Tile List"
		Me.cboTileListSet.Visible = False
		Me.cboTileListSet.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboTileListSet.BackColor = System.Drawing.SystemColors.Window
		Me.cboTileListSet.CausesValidation = True
		Me.cboTileListSet.Enabled = True
		Me.cboTileListSet.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboTileListSet.IntegralHeight = True
		Me.cboTileListSet.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboTileListSet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboTileListSet.Sorted = False
		Me.cboTileListSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboTileListSet.TabStop = True
		Me.cboTileListSet.Name = "cboTileListSet"
		Me.cmdOpenBitmap.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdOpenBitmap.Text = "Open Bitmap"
		Me.cmdOpenBitmap.Size = New System.Drawing.Size(81, 41)
		Me.cmdOpenBitmap.Location = New System.Drawing.Point(96, 184)
		Me.cmdOpenBitmap.Image = CType(resources.GetObject("cmdOpenBitmap.Image"), System.Drawing.Image)
		Me.cmdOpenBitmap.TabIndex = 11
		Me.cmdOpenBitmap.Visible = False
		Me.cmdOpenBitmap.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOpenBitmap.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOpenBitmap.CausesValidation = True
		Me.cmdOpenBitmap.Enabled = True
		Me.cmdOpenBitmap.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOpenBitmap.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOpenBitmap.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOpenBitmap.TabStop = True
		Me.cmdOpenBitmap.Name = "cmdOpenBitmap"
		Me.cmdSaveTIS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdSaveTIS.Text = "Save Tileset"
		Me.cmdSaveTIS.Size = New System.Drawing.Size(81, 33)
		Me.cmdSaveTIS.Location = New System.Drawing.Point(8, 128)
		Me.cmdSaveTIS.Image = CType(resources.GetObject("cmdSaveTIS.Image"), System.Drawing.Image)
		Me.cmdSaveTIS.TabIndex = 9
		Me.cmdSaveTIS.Visible = False
		Me.cmdSaveTIS.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSaveTIS.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSaveTIS.CausesValidation = True
		Me.cmdSaveTIS.Enabled = True
		Me.cmdSaveTIS.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSaveTIS.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSaveTIS.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSaveTIS.TabStop = True
		Me.cmdSaveTIS.Name = "cmdSaveTIS"
		Me.CmdInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CmdInsert.Text = "Insert Tile At Tile"
		Me.CmdInsert.Size = New System.Drawing.Size(81, 41)
		Me.CmdInsert.Location = New System.Drawing.Point(96, 232)
		Me.CmdInsert.TabIndex = 8
		Me.CmdInsert.Visible = False
		Me.CmdInsert.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmdInsert.BackColor = System.Drawing.SystemColors.Control
		Me.CmdInsert.CausesValidation = True
		Me.CmdInsert.Enabled = True
		Me.CmdInsert.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdInsert.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdInsert.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdInsert.TabStop = True
		Me.CmdInsert.Name = "CmdInsert"
		Me.cmdOpenTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdOpenTile.Text = "Open Tile"
		Me.cmdOpenTile.Size = New System.Drawing.Size(81, 41)
		Me.cmdOpenTile.Location = New System.Drawing.Point(8, 184)
		Me.cmdOpenTile.Image = CType(resources.GetObject("cmdOpenTile.Image"), System.Drawing.Image)
		Me.cmdOpenTile.TabIndex = 7
		Me.cmdOpenTile.Visible = False
		Me.cmdOpenTile.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOpenTile.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOpenTile.CausesValidation = True
		Me.cmdOpenTile.Enabled = True
		Me.cmdOpenTile.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOpenTile.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOpenTile.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOpenTile.TabStop = True
		Me.cmdOpenTile.Name = "cmdOpenTile"
		Me.cmdSaveTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdSaveTile.Text = "Save Tile"
		Me.cmdSaveTile.Size = New System.Drawing.Size(81, 33)
		Me.cmdSaveTile.Location = New System.Drawing.Point(96, 128)
		Me.cmdSaveTile.Image = CType(resources.GetObject("cmdSaveTile.Image"), System.Drawing.Image)
		Me.cmdSaveTile.TabIndex = 6
		Me.cmdSaveTile.Visible = False
		Me.cmdSaveTile.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSaveTile.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSaveTile.CausesValidation = True
		Me.cmdSaveTile.Enabled = True
		Me.cmdSaveTile.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSaveTile.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSaveTile.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSaveTile.TabStop = True
		Me.cmdSaveTile.Name = "cmdSaveTile"
		Me.cmdSaveBitmap.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdSaveBitmap.Text = "Save Bitmap"
		Me.cmdSaveBitmap.Size = New System.Drawing.Size(81, 33)
		Me.cmdSaveBitmap.Location = New System.Drawing.Point(96, 88)
		Me.cmdSaveBitmap.Image = CType(resources.GetObject("cmdSaveBitmap.Image"), System.Drawing.Image)
		Me.cmdSaveBitmap.TabIndex = 5
		Me.cmdSaveBitmap.Visible = False
		Me.cmdSaveBitmap.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSaveBitmap.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSaveBitmap.CausesValidation = True
		Me.cmdSaveBitmap.Enabled = True
		Me.cmdSaveBitmap.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSaveBitmap.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSaveBitmap.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSaveBitmap.TabStop = True
		Me.cmdSaveBitmap.Name = "cmdSaveBitmap"
		Me.picCurrentTile.Size = New System.Drawing.Size(72, 69)
		Me.picCurrentTile.Location = New System.Drawing.Point(8, 56)
		Me.picCurrentTile.TabIndex = 4
		Me.picCurrentTile.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picCurrentTile.Dock = System.Windows.Forms.DockStyle.None
		Me.picCurrentTile.BackColor = System.Drawing.SystemColors.Control
		Me.picCurrentTile.CausesValidation = True
		Me.picCurrentTile.Enabled = True
		Me.picCurrentTile.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picCurrentTile.Cursor = System.Windows.Forms.Cursors.Default
		Me.picCurrentTile.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picCurrentTile.TabStop = True
		Me.picCurrentTile.Visible = True
		Me.picCurrentTile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.picCurrentTile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picCurrentTile.Name = "picCurrentTile"
		Me.cboTileBox.Size = New System.Drawing.Size(89, 21)
		Me.cboTileBox.Location = New System.Drawing.Point(88, 56)
		Me.cboTileBox.TabIndex = 3
		Me.cboTileBox.Text = "Tile List"
		Me.cboTileBox.Visible = False
		Me.cboTileBox.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboTileBox.BackColor = System.Drawing.SystemColors.Window
		Me.cboTileBox.CausesValidation = True
		Me.cboTileBox.Enabled = True
		Me.cboTileBox.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboTileBox.IntegralHeight = True
		Me.cboTileBox.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboTileBox.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboTileBox.Sorted = False
		Me.cboTileBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboTileBox.TabStop = True
		Me.cboTileBox.Name = "cboTileBox"
		Me.cmdOpenTIS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdOpenTIS.Size = New System.Drawing.Size(25, 25)
		Me.cmdOpenTIS.Location = New System.Drawing.Point(8, 16)
		Me.cmdOpenTIS.Image = CType(resources.GetObject("cmdOpenTIS.Image"), System.Drawing.Image)
		Me.cmdOpenTIS.TabIndex = 1
		Me.cmdOpenTIS.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOpenTIS.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOpenTIS.CausesValidation = True
		Me.cmdOpenTIS.Enabled = True
		Me.cmdOpenTIS.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOpenTIS.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOpenTIS.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOpenTIS.TabStop = True
		Me.cmdOpenTIS.Name = "cmdOpenTIS"
		Me.Controls.Add(cmdBasicTraining)
		Me.Controls.Add(chkHeader)
		Me.Controls.Add(fraTIS)
		Me.fraTIS.Controls.Add(cmdNewTile)
		Me.fraTIS.Controls.Add(picOpenedTile)
		Me.fraTIS.Controls.Add(cboTileListSet)
		Me.fraTIS.Controls.Add(cmdOpenBitmap)
		Me.fraTIS.Controls.Add(cmdSaveTIS)
		Me.fraTIS.Controls.Add(CmdInsert)
		Me.fraTIS.Controls.Add(cmdOpenTile)
		Me.fraTIS.Controls.Add(cmdSaveTile)
		Me.fraTIS.Controls.Add(cmdSaveBitmap)
		Me.fraTIS.Controls.Add(picCurrentTile)
		Me.fraTIS.Controls.Add(cboTileBox)
		Me.fraTIS.Controls.Add(cmdOpenTIS)
		Me.fraTIS.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class