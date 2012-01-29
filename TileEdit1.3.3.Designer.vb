<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmTileEdit
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
	Public WithEvents cmdAdvanced As System.Windows.Forms.Button
	Public WithEvents cmdBitmapSave As System.Windows.Forms.Button
	Public WithEvents cmdOpenTile As System.Windows.Forms.Button
	Public WithEvents picOpenedTile As System.Windows.Forms.PictureBox
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdSave As System.Windows.Forms.Button
	Public WithEvents cmdCompile As System.Windows.Forms.Button
	Public WithEvents cmdWriteTile As System.Windows.Forms.Button
	Public WithEvents frTile As System.Windows.Forms.GroupBox
	Public WithEvents Picture1 As System.Windows.Forms.PictureBox
	Public WithEvents cmdopen As System.Windows.Forms.Button
	Public cdgDialogOpen As System.Windows.Forms.OpenFileDialog
	Public cdgDialogSave As System.Windows.Forms.SaveFileDialog
	Public WithEvents fraControls As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTileEdit))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdAdvanced = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cmdBitmapSave = New System.Windows.Forms.Button
		Me.cmdOpenTile = New System.Windows.Forms.Button
		Me.picOpenedTile = New System.Windows.Forms.PictureBox
		Me.frTile = New System.Windows.Forms.GroupBox
		Me.cmdSave = New System.Windows.Forms.Button
		Me.cmdCompile = New System.Windows.Forms.Button
		Me.cmdWriteTile = New System.Windows.Forms.Button
		Me.fraControls = New System.Windows.Forms.GroupBox
		Me.Picture1 = New System.Windows.Forms.PictureBox
		Me.cmdopen = New System.Windows.Forms.Button
		Me.cdgDialogOpen = New System.Windows.Forms.OpenFileDialog
		Me.cdgDialogSave = New System.Windows.Forms.SaveFileDialog
		Me.Frame1.SuspendLayout()
		Me.frTile.SuspendLayout()
		Me.fraControls.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Tile Utilities"
		Me.ClientSize = New System.Drawing.Size(162, 577)
		Me.Location_Renamed = New System.Drawing.Point(4, 23)
		Me.Icon = CType(resources.GetObject("frmTileEdit.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmTileEdit"
		Me.cmdAdvanced.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAdvanced.Text = "Advanced Mode"
		Me.cmdAdvanced.Font = New System.Drawing.Font("Arial", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAdvanced.Size = New System.Drawing.Size(145, 81)
		Me.cmdAdvanced.Location = New System.Drawing.Point(8, 488)
		Me.cmdAdvanced.TabIndex = 11
		Me.cmdAdvanced.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAdvanced.CausesValidation = True
		Me.cmdAdvanced.Enabled = True
		Me.cmdAdvanced.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAdvanced.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAdvanced.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAdvanced.TabStop = True
		Me.cmdAdvanced.Name = "cmdAdvanced"
		Me.Frame1.Text = "Exported Tile"
		Me.Frame1.Size = New System.Drawing.Size(161, 137)
		Me.Frame1.Location = New System.Drawing.Point(0, 336)
		Me.Frame1.TabIndex = 7
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.cmdBitmapSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdBitmapSave.Size = New System.Drawing.Size(25, 25)
		Me.cmdBitmapSave.Location = New System.Drawing.Point(104, 16)
		Me.cmdBitmapSave.Image = CType(resources.GetObject("cmdBitmapSave.Image"), System.Drawing.Image)
		Me.cmdBitmapSave.TabIndex = 10
		Me.cmdBitmapSave.Visible = False
		Me.cmdBitmapSave.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdBitmapSave.BackColor = System.Drawing.SystemColors.Control
		Me.cmdBitmapSave.CausesValidation = True
		Me.cmdBitmapSave.Enabled = True
		Me.cmdBitmapSave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdBitmapSave.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdBitmapSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdBitmapSave.TabStop = True
		Me.cmdBitmapSave.Name = "cmdBitmapSave"
		Me.cmdOpenTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdOpenTile.Size = New System.Drawing.Size(25, 25)
		Me.cmdOpenTile.Location = New System.Drawing.Point(24, 16)
		Me.cmdOpenTile.Image = CType(resources.GetObject("cmdOpenTile.Image"), System.Drawing.Image)
		Me.cmdOpenTile.TabIndex = 9
		Me.cmdOpenTile.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOpenTile.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOpenTile.CausesValidation = True
		Me.cmdOpenTile.Enabled = True
		Me.cmdOpenTile.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOpenTile.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOpenTile.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOpenTile.TabStop = True
		Me.cmdOpenTile.Name = "cmdOpenTile"
		Me.picOpenedTile.Size = New System.Drawing.Size(72, 69)
		Me.picOpenedTile.Location = New System.Drawing.Point(40, 48)
		Me.picOpenedTile.TabIndex = 8
		Me.picOpenedTile.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picOpenedTile.Dock = System.Windows.Forms.DockStyle.None
		Me.picOpenedTile.BackColor = System.Drawing.SystemColors.Control
		Me.picOpenedTile.CausesValidation = True
		Me.picOpenedTile.Enabled = True
		Me.picOpenedTile.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picOpenedTile.Cursor = System.Windows.Forms.Cursors.Default
		Me.picOpenedTile.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picOpenedTile.TabStop = True
		Me.picOpenedTile.Visible = True
		Me.picOpenedTile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.picOpenedTile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picOpenedTile.Name = "picOpenedTile"
		Me.frTile.Text = "Tile"
		Me.frTile.Size = New System.Drawing.Size(161, 185)
		Me.frTile.Location = New System.Drawing.Point(0, 144)
		Me.frTile.TabIndex = 3
		Me.frTile.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frTile.BackColor = System.Drawing.SystemColors.Control
		Me.frTile.Enabled = True
		Me.frTile.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frTile.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frTile.Visible = True
		Me.frTile.Name = "frTile"
		Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdSave.Size = New System.Drawing.Size(25, 25)
		Me.cmdSave.Location = New System.Drawing.Point(8, 88)
		Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
		Me.cmdSave.TabIndex = 6
		Me.cmdSave.Visible = False
		Me.cmdSave.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSave.CausesValidation = True
		Me.cmdSave.Enabled = True
		Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSave.TabStop = True
		Me.cmdSave.Name = "cmdSave"
		Me.cmdCompile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCompile.Text = "Create Tile Pallette"
		Me.cmdCompile.Size = New System.Drawing.Size(113, 25)
		Me.cmdCompile.Location = New System.Drawing.Point(16, 24)
		Me.cmdCompile.TabIndex = 5
		Me.cmdCompile.Visible = False
		Me.cmdCompile.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCompile.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCompile.CausesValidation = True
		Me.cmdCompile.Enabled = True
		Me.cmdCompile.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCompile.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCompile.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCompile.TabStop = True
		Me.cmdCompile.Name = "cmdCompile"
		Me.cmdWriteTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdWriteTile.Text = "Create Tile"
		Me.cmdWriteTile.Size = New System.Drawing.Size(89, 25)
		Me.cmdWriteTile.Location = New System.Drawing.Point(32, 88)
		Me.cmdWriteTile.TabIndex = 4
		Me.cmdWriteTile.Visible = False
		Me.cmdWriteTile.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdWriteTile.BackColor = System.Drawing.SystemColors.Control
		Me.cmdWriteTile.CausesValidation = True
		Me.cmdWriteTile.Enabled = True
		Me.cmdWriteTile.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdWriteTile.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdWriteTile.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdWriteTile.TabStop = True
		Me.cmdWriteTile.Name = "cmdWriteTile"
		Me.fraControls.Text = "Bitmap Source"
		Me.fraControls.Size = New System.Drawing.Size(161, 137)
		Me.fraControls.Location = New System.Drawing.Point(0, 0)
		Me.fraControls.TabIndex = 1
		Me.fraControls.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraControls.BackColor = System.Drawing.SystemColors.Control
		Me.fraControls.Enabled = True
		Me.fraControls.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraControls.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraControls.Visible = True
		Me.fraControls.Name = "fraControls"
		Me.Picture1.Size = New System.Drawing.Size(72, 69)
		Me.Picture1.Location = New System.Drawing.Point(48, 48)
		Me.Picture1.TabIndex = 2
		Me.Picture1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture1.Dock = System.Windows.Forms.DockStyle.None
		Me.Picture1.BackColor = System.Drawing.SystemColors.Control
		Me.Picture1.CausesValidation = True
		Me.Picture1.Enabled = True
		Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Picture1.TabStop = True
		Me.Picture1.Visible = True
		Me.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Picture1.Name = "Picture1"
		Me.cmdopen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdopen.Size = New System.Drawing.Size(25, 25)
		Me.cmdopen.Location = New System.Drawing.Point(8, 16)
		Me.cmdopen.Image = CType(resources.GetObject("cmdopen.Image"), System.Drawing.Image)
		Me.cmdopen.TabIndex = 0
		Me.cmdopen.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdopen.BackColor = System.Drawing.SystemColors.Control
		Me.cmdopen.CausesValidation = True
		Me.cmdopen.Enabled = True
		Me.cmdopen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdopen.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdopen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdopen.TabStop = True
		Me.cmdopen.Name = "cmdopen"
		Me.Controls.Add(cmdAdvanced)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(frTile)
		Me.Controls.Add(fraControls)
		Me.Frame1.Controls.Add(cmdBitmapSave)
		Me.Frame1.Controls.Add(cmdOpenTile)
		Me.Frame1.Controls.Add(picOpenedTile)
		Me.frTile.Controls.Add(cmdSave)
		Me.frTile.Controls.Add(cmdCompile)
		Me.frTile.Controls.Add(cmdWriteTile)
		Me.fraControls.Controls.Add(Picture1)
		Me.fraControls.Controls.Add(cmdopen)
		Me.Frame1.ResumeLayout(False)
		Me.frTile.ResumeLayout(False)
		Me.fraControls.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class