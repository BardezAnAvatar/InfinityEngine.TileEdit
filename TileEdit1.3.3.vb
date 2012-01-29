Option Strict Off
Option Explicit On
Friend Class frmTileEdit
	Inherits System.Windows.Forms.Form
	Public BMPLocation As String
	
	Dim LocationLocationLocation As String
	Dim blnzero As Boolean
	Public RGBtemp As Integer
	Public Analyze As String
	Public G, R, B As Byte
	Const A As Byte = 0
	Public pixel As Integer
	'UPGRADE_NOTE: Location was upgraded to Location_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Location_Renamed As Integer
	Dim i, j As Short
	Dim X, Y As Integer
	
	
	
	Private Declare Function BlockInput Lib "USER32.DLL" (ByVal fBlockIt As Integer) As Integer
	
	
	
	
	Private Sub cmdAdvanced_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAdvanced.Click
		Me.Close()
		frmAdvancedTile.Show()
	End Sub
	
	Private Sub cmdCompile_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCompile.Click
		BlockInput(True)
		RGB002 = 0
		RGB003 = 0
		RGB004 = 0
		RGB005 = 0
		RGB006 = 0
		RGB007 = 0
		RGB008 = 0
		RGB009 = 0
		RGB010 = 0
		RGB011 = 0
		RGB012 = 0
		RGB013 = 0
		RGB014 = 0
		RGB015 = 0
		RGB016 = 0
		RGB017 = 0
		RGB018 = 0
		RGB019 = 0
		RGB020 = 0
		RGB021 = 0
		RGB022 = 0
		RGB023 = 0
		RGB024 = 0
		RGB025 = 0
		RGB026 = 0
		RGB027 = 0
		RGB028 = 0
		RGB029 = 0
		RGB030 = 0
		RGB031 = 0
		RGB032 = 0
		RGB033 = 0
		RGB034 = 0
		RGB035 = 0
		RGB036 = 0
		RGB037 = 0
		RGB038 = 0
		RGB039 = 0
		RGB040 = 0
		RGB041 = 0
		RGB042 = 0
		RGB043 = 0
		RGB044 = 0
		RGB045 = 0
		RGB046 = 0
		RGB047 = 0
		RGB048 = 0
		RGB049 = 0
		RGB050 = 0
		RGB051 = 0
		RGB052 = 0
		RGB053 = 0
		RGB054 = 0
		RGB055 = 0
		RGB056 = 0
		RGB057 = 0
		RGB058 = 0
		RGB059 = 0
		RGB060 = 0
		RGB061 = 0
		RGB062 = 0
		RGB063 = 0
		RGB064 = 0
		RGB065 = 0
		RGB066 = 0
		RGB067 = 0
		RGB068 = 0
		RGB069 = 0
		RGB070 = 0
		RGB071 = 0
		RGB072 = 0
		RGB073 = 0
		RGB074 = 0
		RGB075 = 0
		RGB076 = 0
		RGB077 = 0
		RGB078 = 0
		RGB079 = 0
		RGB080 = 0
		RGB081 = 0
		RGB082 = 0
		RGB083 = 0
		RGB084 = 0
		RGB085 = 0
		RGB086 = 0
		RGB087 = 0
		RGB088 = 0
		RGB089 = 0
		RGB090 = 0
		RGB091 = 0
		RGB092 = 0
		RGB093 = 0
		RGB094 = 0
		RGB095 = 0
		RGB096 = 0
		RGB097 = 0
		RGB098 = 0
		RGB099 = 0
		RGB100 = 0
		RGB101 = 0
		RGB102 = 0
		RGB103 = 0
		RGB104 = 0
		RGB105 = 0
		RGB106 = 0
		RGB107 = 0
		RGB108 = 0
		RGB109 = 0
		RGB110 = 0
		RGB111 = 0
		RGB112 = 0
		RGB113 = 0
		RGB114 = 0
		RGB115 = 0
		RGB116 = 0
		RGB117 = 0
		RGB118 = 0
		RGB119 = 0
		RGB120 = 0
		RGB121 = 0
		RGB122 = 0
		RGB123 = 0
		RGB124 = 0
		RGB125 = 0
		RGB126 = 0
		RGB127 = 0
		RGB128 = 0
		RGB129 = 0
		RGB130 = 0
		RGB131 = 0
		RGB132 = 0
		RGB133 = 0
		RGB134 = 0
		RGB135 = 0
		RGB136 = 0
		RGB137 = 0
		RGB138 = 0
		RGB139 = 0
		RGB140 = 0
		RGB141 = 0
		RGB142 = 0
		RGB143 = 0
		RGB144 = 0
		RGB145 = 0
		RGB146 = 0
		RGB147 = 0
		RGB148 = 0
		RGB149 = 0
		RGB150 = 0
		RGB151 = 0
		RGB152 = 0
		RGB153 = 0
		RGB154 = 0
		RGB155 = 0
		RGB156 = 0
		RGB157 = 0
		RGB158 = 0
		RGB159 = 0
		RGB160 = 0
		RGB161 = 0
		RGB162 = 0
		RGB163 = 0
		RGB164 = 0
		RGB165 = 0
		RGB166 = 0
		RGB167 = 0
		RGB168 = 0
		RGB169 = 0
		RGB170 = 0
		RGB171 = 0
		RGB172 = 0
		RGB173 = 0
		RGB174 = 0
		RGB175 = 0
		RGB176 = 0
		RGB177 = 0
		RGB178 = 0
		RGB179 = 0
		RGB180 = 0
		RGB181 = 0
		RGB182 = 0
		RGB183 = 0
		RGB184 = 0
		RGB185 = 0
		RGB186 = 0
		RGB187 = 0
		RGB188 = 0
		RGB189 = 0
		RGB190 = 0
		RGB191 = 0
		RGB192 = 0
		RGB193 = 0
		RGB194 = 0
		RGB195 = 0
		RGB196 = 0
		RGB197 = 0
		RGB198 = 0
		RGB199 = 0
		RGB200 = 0
		RGB201 = 0
		RGB202 = 0
		RGB203 = 0
		RGB204 = 0
		RGB205 = 0
		RGB206 = 0
		RGB207 = 0
		RGB208 = 0
		RGB209 = 0
		RGB210 = 0
		RGB211 = 0
		RGB212 = 0
		RGB213 = 0
		RGB214 = 0
		RGB215 = 0
		RGB216 = 0
		RGB217 = 0
		RGB218 = 0
		RGB219 = 0
		RGB220 = 0
		RGB221 = 0
		RGB222 = 0
		RGB223 = 0
		RGB224 = 0
		RGB225 = 0
		RGB226 = 0
		RGB227 = 0
		RGB228 = 0
		RGB229 = 0
		RGB230 = 0
		RGB231 = 0
		RGB232 = 0
		RGB233 = 0
		RGB234 = 0
		RGB235 = 0
		RGB236 = 0
		RGB237 = 0
		RGB238 = 0
		RGB239 = 0
		RGB240 = 0
		RGB241 = 0
		RGB242 = 0
		RGB243 = 0
		RGB244 = 0
		RGB245 = 0
		RGB246 = 0
		RGB247 = 0
		RGB248 = 0
		RGB249 = 0
		RGB250 = 0
		RGB251 = 0
		RGB252 = 0
		RGB253 = 0
		RGB254 = 0
		RGB255 = 0
		RGB256 = 0
		
		X = Picture1.ClientRectangle.Width
		Y = Picture1.ClientRectangle.Height
		For i = 0 To Y - 1
			System.Windows.Forms.Application.DoEvents()
			For j = 0 To X - 1
				System.Windows.Forms.Application.DoEvents()
				'UPGRADE_ISSUE: PictureBox property Picture1.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				pixel = GetPixel(Picture1.hDC, j, i)
				
				If pixel <> RGB002 Or pixel <> RGB003 Or pixel <> RGB004 Or pixel <> RGB005 Or pixel <> RGB006 Or pixel <> RGB007 Or pixel <> RGB008 Or pixel <> RGB009 Or pixel <> RGB010 Or pixel <> RGB011 Or pixel <> RGB012 Or pixel <> RGB013 Or pixel <> RGB014 Or pixel <> RGB015 Or pixel <> RGB016 Or pixel <> RGB017 Or pixel <> RGB018 Or pixel <> RGB019 Or pixel <> RGB020 Or pixel <> RGB021 Or pixel <> RGB022 Or pixel <> RGB023 Or pixel <> RGB024 Or pixel <> RGB025 Or pixel <> RGB026 Or pixel <> RGB027 Or pixel <> RGB028 Or pixel <> RGB029 Or pixel <> RGB030 Or pixel <> RGB031 Or pixel <> RGB032 Or pixel <> RGB033 Or pixel <> RGB034 Or pixel <> RGB035 Or pixel <> RGB036 Or pixel <> RGB037 Or pixel <> RGB038 Or pixel <> RGB039 Or pixel <> RGB040 Or pixel <> RGB041 Or pixel <> RGB042 Or pixel <> RGB043 Or pixel <> RGB044 Or pixel <> RGB045 Or pixel <> RGB046 Or pixel <> RGB047 Or pixel <> RGB048 Or pixel <> RGB049 Or pixel <> RGB050 Then
					WritePallette()
				ElseIf pixel <> RGB051 Or pixel <> RGB052 Or pixel <> RGB053 Or pixel <> RGB054 Or pixel <> RGB055 Or pixel <> RGB056 Or pixel <> RGB057 Or pixel <> RGB058 Or pixel <> RGB059 Or pixel <> RGB060 Or pixel <> RGB061 Or pixel <> RGB062 Or pixel <> RGB063 Or pixel <> RGB064 Or pixel <> RGB065 Or pixel <> RGB066 Or pixel <> RGB067 Or pixel <> RGB068 Or pixel <> RGB069 Or pixel <> RGB070 Or pixel <> RGB071 Or pixel <> RGB072 Or pixel <> RGB073 Or pixel <> RGB074 Or pixel <> RGB075 Or pixel <> RGB076 Or pixel <> RGB077 Or pixel <> RGB078 Or pixel <> RGB079 Or pixel <> RGB080 Or pixel <> RGB081 Or pixel <> RGB082 Or pixel <> RGB083 Or pixel <> RGB084 Or pixel <> RGB085 Or pixel <> RGB086 Or pixel <> RGB087 Or pixel <> RGB088 Or pixel <> RGB089 Or pixel <> RGB090 Or pixel <> RGB091 Or pixel <> RGB092 Or pixel <> RGB093 Or pixel <> RGB094 Or pixel <> RGB095 Or pixel <> RGB096 Or pixel <> RGB097 Or pixel <> RGB098 Or pixel <> RGB099 Or pixel <> RGB100 Then 
					WritePallette()
				ElseIf pixel <> RGB101 Or pixel <> RGB102 Or pixel <> RGB103 Or pixel <> RGB104 Or pixel <> RGB105 Or pixel <> RGB106 Or pixel <> RGB107 Or pixel <> RGB108 Or pixel <> RGB109 Or pixel <> RGB110 Or pixel <> RGB111 Or pixel <> RGB112 Or pixel <> RGB113 Or pixel <> RGB114 Or pixel <> RGB115 Or pixel <> RGB116 Or pixel <> RGB117 Or pixel <> RGB118 Or pixel <> RGB119 Or pixel <> RGB120 Or pixel <> RGB121 Or pixel <> RGB122 Or pixel <> RGB123 Or pixel <> RGB124 Or pixel <> RGB125 Or pixel <> RGB126 Or pixel <> RGB127 Or pixel <> RGB128 Or pixel <> RGB129 Or pixel <> RGB130 Or pixel <> RGB131 Or pixel <> RGB132 Or pixel <> RGB133 Or pixel <> RGB134 Or pixel <> RGB135 Or pixel <> RGB136 Or pixel <> RGB137 Or pixel <> RGB138 Or pixel <> RGB139 Or pixel <> RGB140 Or pixel <> RGB141 Or pixel <> RGB142 Or pixel <> RGB143 Or pixel <> RGB144 Or pixel <> RGB145 Or pixel <> RGB146 Or pixel <> RGB147 Or pixel <> RGB148 Or pixel <> RGB149 Or pixel <> RGB150 Then 
					WritePallette()
				ElseIf pixel <> RGB151 Or pixel <> RGB152 Or pixel <> RGB153 Or pixel <> RGB154 Or pixel <> RGB155 Or pixel <> RGB156 Or pixel <> RGB157 Or pixel <> RGB158 Or pixel <> RGB159 Or pixel <> RGB160 Or pixel <> RGB161 Or pixel <> RGB162 Or pixel <> RGB163 Or pixel <> RGB164 Or pixel <> RGB165 Or pixel <> RGB166 Or pixel <> RGB167 Or pixel <> RGB168 Or pixel <> RGB169 Or pixel <> RGB170 Or pixel <> RGB171 Or pixel <> RGB172 Or pixel <> RGB173 Or pixel <> RGB174 Or pixel <> RGB175 Or pixel <> RGB176 Or pixel <> RGB177 Or pixel <> RGB178 Or pixel <> RGB179 Or pixel <> RGB180 Or pixel <> RGB181 Or pixel <> RGB182 Or pixel <> RGB183 Or pixel <> RGB184 Or pixel <> RGB185 Or pixel <> RGB186 Or pixel <> RGB187 Or pixel <> RGB188 Or pixel <> RGB189 Or pixel <> RGB190 Or pixel <> RGB191 Or pixel <> RGB192 Or pixel <> RGB193 Or pixel <> RGB194 Or pixel <> RGB195 Or pixel <> RGB196 Or pixel <> RGB197 Or pixel <> RGB198 Or pixel <> RGB199 Or pixel <> RGB200 Then 
					WritePallette()
				ElseIf pixel <> RGB201 Or pixel <> RGB202 Or pixel <> RGB203 Or pixel <> RGB204 Or pixel <> RGB205 Or pixel <> RGB206 Or pixel <> RGB207 Or pixel <> RGB208 Or pixel <> RGB209 Or pixel <> RGB210 Or pixel <> RGB211 Or pixel <> RGB212 Or pixel <> RGB213 Or pixel <> RGB214 Or pixel <> RGB215 Or pixel <> RGB216 Or pixel <> RGB217 Or pixel <> RGB218 Or pixel <> RGB219 Or pixel <> RGB220 Or pixel <> RGB221 Or pixel <> RGB222 Or pixel <> RGB223 Or pixel <> RGB224 Or pixel <> RGB225 Or pixel <> RGB226 Or pixel <> RGB227 Or pixel <> RGB228 Or pixel <> RGB229 Or pixel <> RGB230 Or pixel <> RGB231 Or pixel <> RGB232 Or pixel <> RGB233 Or pixel <> RGB234 Or pixel <> RGB235 Or pixel <> RGB236 Or pixel <> RGB237 Or pixel <> RGB238 Or pixel <> RGB239 Or pixel <> RGB240 Or pixel <> RGB241 Or pixel <> RGB242 Or pixel <> RGB243 Or pixel <> RGB244 Or pixel <> RGB245 Or pixel <> RGB246 Or pixel <> RGB247 Or pixel <> RGB248 Or pixel <> RGB249 Or pixel <> RGB250 Then 
					WritePallette()
				ElseIf pixel <> RGB251 Or pixel <> RGB252 Or pixel <> RGB253 Or pixel <> RGB254 Or pixel <> RGB255 Or pixel <> RGB256 Or pixel <> RGB257 Then 
					Call WritePallette()
				End If
			Next 
		Next 
		
		Call ReallyRitePallette()
		
		Picture1.Refresh()
		cmdSave.Visible = True
		BlockInput(False)
		
		MsgBox("DONE")
	End Sub
	
	Private Sub cmdopen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdopen.Click
		
		On Error Resume Next
		'UPGRADE_WARNING: CommonDialog variable was not upgraded Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
		With cdgDialog
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			.CancelError = True
			'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			.Filter = "Bitmaps (.bmp);JPEGs (.jpg)"
			.FileName = "*.bmp;*.jpg;*.jpeg"
			.ShowDialog()
			If Err.Number = 0 Then
				If .FileName <> vbNullString Then
					Picture1.Image = System.Drawing.Image.FromFile(cdgDialogOpen.FileName)
				End If
			End If
		End With
		
		cmdCompile.Visible = True
	End Sub
	
	
	Private Sub Long_Dec()
		
		B = RGBtemp Mod 256
		G = (RGBtemp \ 256) Mod 256
		R = ((RGBtemp \ 256) \ 256) Mod 256
		
	End Sub
	
	Private Sub cmdOpenTile_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOpenTile.Click
		On Error Resume Next
		'UPGRADE_WARNING: CommonDialog variable was not upgraded Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
		With cdgDialog
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			.CancelError = True
			'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			.Filter = "Infinity Engine tiles (*.IEt)"
			.FileName = "*.IEt"
			.ShowDialog()
			If Err.Number = 0 Then
				If .FileName <> vbNullString Then
					BMPLocation = cdgDialogOpen.FileName
					picOpenedTile.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\blank.bmp")
				End If
			End If
		End With
		Tile_Open()
		cmdBitmapSave.Visible = True
	End Sub
	
	Private Sub cmdSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.Click
		
		On Error Resume Next
		'UPGRADE_WARNING: CommonDialog variable was not upgraded Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
		With cdgDialog
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			.CancelError = True
			'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			.Filter = "Infinity Engine Tiles (*.IEt)"
			.FileName = "*.IEt"
			.ShowDialog()
			If Err.Number = 0 Then
				If .FileName <> vbNullString Then
				End If
			End If
			
		End With
		LocationLocationLocation = cdgDialogOpen.FileName
		Call WriteTile()
	End Sub
	
	
	Public Sub WritePallette()
		
		RGB001 = 65280
		
		If blnzero = True And pixel = 0 Then
		ElseIf pixel = RGB001 Or pixel = RGB002 Or pixel = RGB003 Or pixel = RGB004 Or pixel = RGB005 Or pixel = RGB006 Or pixel = RGB007 Or pixel = RGB008 Or pixel = RGB009 Or pixel = RGB010 Or pixel = RGB011 Or pixel = RGB012 Or pixel = RGB013 Or pixel = RGB014 Or pixel = RGB015 Or pixel = RGB016 Or pixel = RGB017 Or pixel = RGB018 Or pixel = RGB019 Or pixel = RGB020 Or pixel = RGB021 Or pixel = RGB022 Or pixel = RGB023 Or pixel = RGB024 Or pixel = RGB025 Or pixel = RGB026 Or pixel = RGB027 Or pixel = RGB028 Or pixel = RGB029 Or pixel = RGB030 Or pixel = RGB031 Or pixel = RGB032 Or pixel = RGB033 Or pixel = RGB034 Or pixel = RGB035 Or pixel = RGB036 Or pixel = RGB037 Or pixel = RGB038 Or pixel = RGB039 Or pixel = RGB040 Or pixel = RGB041 Or pixel = RGB042 Or pixel = RGB043 Or pixel = RGB044 Or pixel = RGB045 Or pixel = RGB046 Or pixel = RGB047 Or pixel = RGB048 Or pixel = RGB049 Or pixel = RGB050 Then 
		ElseIf pixel = RGB051 Or pixel = RGB052 Or pixel = RGB053 Or pixel = RGB054 Or pixel = RGB055 Or pixel = RGB056 Or pixel = RGB057 Or pixel = RGB058 Or pixel = RGB059 Or pixel = RGB060 Or pixel = RGB061 Or pixel = RGB062 Or pixel = RGB063 Or pixel = RGB064 Or pixel = RGB065 Or pixel = RGB066 Or pixel = RGB067 Or pixel = RGB068 Or pixel = RGB069 Or pixel = RGB070 Or pixel = RGB071 Or pixel = RGB072 Or pixel = RGB073 Or pixel = RGB074 Or pixel = RGB075 Or pixel = RGB076 Or pixel = RGB077 Or pixel = RGB078 Or pixel = RGB079 Or pixel = RGB080 Or pixel = RGB081 Or pixel = RGB082 Or pixel = RGB083 Or pixel = RGB084 Or pixel = RGB085 Or pixel = RGB086 Or pixel = RGB087 Or pixel = RGB088 Or pixel = RGB089 Or pixel = RGB090 Or pixel = RGB091 Or pixel = RGB092 Or pixel = RGB093 Or pixel = RGB094 Or pixel = RGB095 Or pixel = RGB096 Or pixel = RGB097 Or pixel = RGB098 Or pixel = RGB099 Or pixel = RGB100 Then 
		ElseIf pixel = RGB101 Or pixel = RGB102 Or pixel = RGB103 Or pixel = RGB104 Or pixel = RGB105 Or pixel = RGB106 Or pixel = RGB107 Or pixel = RGB108 Or pixel = RGB109 Or pixel = RGB110 Or pixel = RGB111 Or pixel = RGB112 Or pixel = RGB113 Or pixel = RGB114 Or pixel = RGB115 Or pixel = RGB116 Or pixel = RGB117 Or pixel = RGB118 Or pixel = RGB119 Or pixel = RGB120 Or pixel = RGB121 Or pixel = RGB122 Or pixel = RGB123 Or pixel = RGB124 Or pixel = RGB125 Or pixel = RGB126 Or pixel = RGB127 Or pixel = RGB128 Or pixel = RGB129 Or pixel = RGB130 Or pixel = RGB131 Or pixel = RGB132 Or pixel = RGB133 Or pixel = RGB134 Or pixel = RGB135 Or pixel = RGB136 Or pixel = RGB137 Or pixel = RGB138 Or pixel = RGB139 Or pixel = RGB140 Or pixel = RGB141 Or pixel = RGB142 Or pixel = RGB143 Or pixel = RGB144 Or pixel = RGB145 Or pixel = RGB146 Or pixel = RGB147 Or pixel = RGB148 Or pixel = RGB149 Or pixel = RGB150 Then 
		ElseIf pixel = RGB151 Or pixel = RGB152 Or pixel = RGB153 Or pixel = RGB154 Or pixel = RGB155 Or pixel = RGB156 Or pixel = RGB157 Or pixel = RGB158 Or pixel = RGB159 Or pixel = RGB160 Or pixel = RGB161 Or pixel = RGB162 Or pixel = RGB163 Or pixel = RGB164 Or pixel = RGB165 Or pixel = RGB166 Or pixel = RGB167 Or pixel = RGB168 Or pixel = RGB169 Or pixel = RGB170 Or pixel = RGB171 Or pixel = RGB172 Or pixel = RGB173 Or pixel = RGB174 Or pixel = RGB175 Or pixel = RGB176 Or pixel = RGB177 Or pixel = RGB178 Or pixel = RGB179 Or pixel = RGB180 Or pixel = RGB181 Or pixel = RGB182 Or pixel = RGB183 Or pixel = RGB184 Or pixel = RGB185 Or pixel = RGB186 Or pixel = RGB187 Or pixel = RGB188 Or pixel = RGB189 Or pixel = RGB190 Or pixel = RGB191 Or pixel = RGB192 Or pixel = RGB193 Or pixel = RGB194 Or pixel = RGB195 Or pixel = RGB196 Or pixel = RGB197 Or pixel = RGB198 Or pixel = RGB199 Or pixel = RGB200 Then 
		ElseIf pixel = RGB201 Or pixel = RGB202 Or pixel = RGB203 Or pixel = RGB204 Or pixel = RGB205 Or pixel = RGB206 Or pixel = RGB207 Or pixel = RGB208 Or pixel = RGB209 Or pixel = RGB210 Or pixel = RGB211 Or pixel = RGB212 Or pixel = RGB213 Or pixel = RGB214 Or pixel = RGB215 Or pixel = RGB216 Or pixel = RGB217 Or pixel = RGB218 Or pixel = RGB219 Or pixel = RGB220 Or pixel = RGB221 Or pixel = RGB222 Or pixel = RGB223 Or pixel = RGB224 Or pixel = RGB225 Or pixel = RGB226 Or pixel = RGB227 Or pixel = RGB228 Or pixel = RGB229 Or pixel = RGB230 Or pixel = RGB231 Or pixel = RGB232 Or pixel = RGB233 Or pixel = RGB234 Or pixel = RGB235 Or pixel = RGB236 Or pixel = RGB237 Or pixel = RGB238 Or pixel = RGB239 Or pixel = RGB240 Or pixel = RGB241 Or pixel = RGB242 Or pixel = RGB243 Or pixel = RGB244 Or pixel = RGB245 Or pixel = RGB246 Or pixel = RGB247 Or pixel = RGB248 Or pixel = RGB249 Or pixel = RGB250 Then 
		ElseIf pixel = RGB251 Or pixel = RGB252 Or pixel = RGB253 Or pixel = RGB254 Or pixel = RGB255 Or pixel = RGB256 Or pixel = RGB257 Then 
		Else
			If RGB002 = 0 Then
				RGB002 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB003 = 0 Then 
				RGB003 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB004 = 0 Then 
				RGB004 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB005 = 0 Then 
				RGB005 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB006 = 0 Then 
				RGB006 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB007 = 0 Then 
				RGB007 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB008 = 0 Then 
				RGB008 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB009 = 0 Then 
				RGB009 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB010 = 0 Then 
				RGB010 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB011 = 0 Then 
				RGB011 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB012 = 0 Then 
				RGB012 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB013 = 0 Then 
				RGB013 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB014 = 0 Then 
				RGB014 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB015 = 0 Then 
				RGB015 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB016 = 0 Then 
				RGB016 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB017 = 0 Then 
				RGB017 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB018 = 0 Then 
				RGB018 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB019 = 0 Then 
				RGB019 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB020 = 0 Then 
				RGB020 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB021 = 0 Then 
				RGB021 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB022 = 0 Then 
				RGB022 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB023 = 0 Then 
				RGB023 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB024 = 0 Then 
				RGB024 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB025 = 0 Then 
				RGB025 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB026 = 0 Then 
				RGB026 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB027 = 0 Then 
				RGB027 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB028 = 0 Then 
				RGB028 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB029 = 0 Then 
				RGB029 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB030 = 0 Then 
				RGB030 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB031 = 0 Then 
				RGB031 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB032 = 0 Then 
				RGB032 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB033 = 0 Then 
				RGB033 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB034 = 0 Then 
				RGB034 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB035 = 0 Then 
				RGB035 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB036 = 0 Then 
				RGB036 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB037 = 0 Then 
				RGB037 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB038 = 0 Then 
				RGB038 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB039 = 0 Then 
				RGB039 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB040 = 0 Then 
				RGB040 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB041 = 0 Then 
				RGB041 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB042 = 0 Then 
				RGB042 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB043 = 0 Then 
				RGB043 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB044 = 0 Then 
				RGB044 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB045 = 0 Then 
				RGB045 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB046 = 0 Then 
				RGB046 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB047 = 0 Then 
				RGB047 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB048 = 0 Then 
				RGB048 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB049 = 0 Then 
				RGB049 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB050 = 0 Then 
				RGB050 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB051 = 0 Then 
				RGB051 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB052 = 0 Then 
				RGB052 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB053 = 0 Then 
				RGB053 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB054 = 0 Then 
				RGB054 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB055 = 0 Then 
				RGB055 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB056 = 0 Then 
				RGB056 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB057 = 0 Then 
				RGB057 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB058 = 0 Then 
				RGB058 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB059 = 0 Then 
				RGB059 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB060 = 0 Then 
				RGB060 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB061 = 0 Then 
				RGB061 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB062 = 0 Then 
				RGB062 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB063 = 0 Then 
				RGB063 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB064 = 0 Then 
				RGB064 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB065 = 0 Then 
				RGB065 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB066 = 0 Then 
				RGB066 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB067 = 0 Then 
				RGB067 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB068 = 0 Then 
				RGB068 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB069 = 0 Then 
				RGB069 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB070 = 0 Then 
				RGB070 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB071 = 0 Then 
				RGB071 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB072 = 0 Then 
				RGB072 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB073 = 0 Then 
				RGB073 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB074 = 0 Then 
				RGB074 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB075 = 0 Then 
				RGB075 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB076 = 0 Then 
				RGB076 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB077 = 0 Then 
				RGB077 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB078 = 0 Then 
				RGB078 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB079 = 0 Then 
				RGB079 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB080 = 0 Then 
				RGB080 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB081 = 0 Then 
				RGB081 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB082 = 0 Then 
				RGB082 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB083 = 0 Then 
				RGB083 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB084 = 0 Then 
				RGB084 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB085 = 0 Then 
				RGB085 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB086 = 0 Then 
				RGB086 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB087 = 0 Then 
				RGB087 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB088 = 0 Then 
				RGB088 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB089 = 0 Then 
				RGB089 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB090 = 0 Then 
				RGB090 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB091 = 0 Then 
				RGB091 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB092 = 0 Then 
				RGB092 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB093 = 0 Then 
				RGB093 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB094 = 0 Then 
				RGB094 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB095 = 0 Then 
				RGB095 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB096 = 0 Then 
				RGB096 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB097 = 0 Then 
				RGB097 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB098 = 0 Then 
				RGB098 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB099 = 0 Then 
				RGB099 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB100 = 0 Then 
				RGB100 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB101 = 0 Then 
				RGB101 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB102 = 0 Then 
				RGB102 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB103 = 0 Then 
				RGB103 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB104 = 0 Then 
				RGB104 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB105 = 0 Then 
				RGB105 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB106 = 0 Then 
				RGB106 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB107 = 0 Then 
				RGB107 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB108 = 0 Then 
				RGB108 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB109 = 0 Then 
				RGB109 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB110 = 0 Then 
				RGB110 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB111 = 0 Then 
				RGB111 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB112 = 0 Then 
				RGB112 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB113 = 0 Then 
				RGB113 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB114 = 0 Then 
				RGB114 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB115 = 0 Then 
				RGB115 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB116 = 0 Then 
				RGB116 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB117 = 0 Then 
				RGB117 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB118 = 0 Then 
				RGB118 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB119 = 0 Then 
				RGB119 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB120 = 0 Then 
				RGB120 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB121 = 0 Then 
				RGB121 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB122 = 0 Then 
				RGB122 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB123 = 0 Then 
				RGB123 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB124 = 0 Then 
				RGB124 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB125 = 0 Then 
				RGB125 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB126 = 0 Then 
				RGB126 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB127 = 0 Then 
				RGB127 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB128 = 0 Then 
				RGB128 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB129 = 0 Then 
				RGB129 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB130 = 0 Then 
				RGB130 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB131 = 0 Then 
				RGB131 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB132 = 0 Then 
				RGB132 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB133 = 0 Then 
				RGB133 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB134 = 0 Then 
				RGB134 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB135 = 0 Then 
				RGB135 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB136 = 0 Then 
				RGB136 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB137 = 0 Then 
				RGB137 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB138 = 0 Then 
				RGB138 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB139 = 0 Then 
				RGB139 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB140 = 0 Then 
				RGB140 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB141 = 0 Then 
				RGB141 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB142 = 0 Then 
				RGB142 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB143 = 0 Then 
				RGB143 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB144 = 0 Then 
				RGB144 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB145 = 0 Then 
				RGB145 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB146 = 0 Then 
				RGB146 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB147 = 0 Then 
				RGB147 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB148 = 0 Then 
				RGB148 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB149 = 0 Then 
				RGB149 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB150 = 0 Then 
				RGB150 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB151 = 0 Then 
				RGB151 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB152 = 0 Then 
				RGB152 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB153 = 0 Then 
				RGB153 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB154 = 0 Then 
				RGB154 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB155 = 0 Then 
				RGB155 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB156 = 0 Then 
				RGB156 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB157 = 0 Then 
				RGB157 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB158 = 0 Then 
				RGB158 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB159 = 0 Then 
				RGB159 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB160 = 0 Then 
				RGB160 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB161 = 0 Then 
				RGB161 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB162 = 0 Then 
				RGB162 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB163 = 0 Then 
				RGB163 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB164 = 0 Then 
				RGB164 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB165 = 0 Then 
				RGB165 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB166 = 0 Then 
				RGB166 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB167 = 0 Then 
				RGB167 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB168 = 0 Then 
				RGB168 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB169 = 0 Then 
				RGB169 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB170 = 0 Then 
				RGB170 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB171 = 0 Then 
				RGB171 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB172 = 0 Then 
				RGB172 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB173 = 0 Then 
				RGB173 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB174 = 0 Then 
				RGB174 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB175 = 0 Then 
				RGB175 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB176 = 0 Then 
				RGB176 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB177 = 0 Then 
				RGB177 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB178 = 0 Then 
				RGB178 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB179 = 0 Then 
				RGB179 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB180 = 0 Then 
				RGB180 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB181 = 0 Then 
				RGB181 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB182 = 0 Then 
				RGB182 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB183 = 0 Then 
				RGB183 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB184 = 0 Then 
				RGB184 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB185 = 0 Then 
				RGB185 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB186 = 0 Then 
				RGB186 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB187 = 0 Then 
				RGB187 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB188 = 0 Then 
				RGB188 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB189 = 0 Then 
				RGB189 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB190 = 0 Then 
				RGB190 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB191 = 0 Then 
				RGB191 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB192 = 0 Then 
				RGB192 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB193 = 0 Then 
				RGB193 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB194 = 0 Then 
				RGB194 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB195 = 0 Then 
				RGB195 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB196 = 0 Then 
				RGB196 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB197 = 0 Then 
				RGB197 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB198 = 0 Then 
				RGB198 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB199 = 0 Then 
				RGB199 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB200 = 0 Then 
				RGB200 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB201 = 0 Then 
				RGB201 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB202 = 0 Then 
				RGB202 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB203 = 0 Then 
				RGB203 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB204 = 0 Then 
				RGB204 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB205 = 0 Then 
				RGB205 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB206 = 0 Then 
				RGB206 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB207 = 0 Then 
				RGB207 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB208 = 0 Then 
				RGB208 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB209 = 0 Then 
				RGB209 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB210 = 0 Then 
				RGB210 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB211 = 0 Then 
				RGB211 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB212 = 0 Then 
				RGB212 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB213 = 0 Then 
				RGB213 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB214 = 0 Then 
				RGB214 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB215 = 0 Then 
				RGB215 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB216 = 0 Then 
				RGB216 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB217 = 0 Then 
				RGB217 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB218 = 0 Then 
				RGB218 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB219 = 0 Then 
				RGB219 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB220 = 0 Then 
				RGB220 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB221 = 0 Then 
				RGB221 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB222 = 0 Then 
				RGB222 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB223 = 0 Then 
				RGB223 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB224 = 0 Then 
				RGB224 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB225 = 0 Then 
				RGB225 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB226 = 0 Then 
				RGB226 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB227 = 0 Then 
				RGB227 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB228 = 0 Then 
				RGB228 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB229 = 0 Then 
				RGB229 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB230 = 0 Then 
				RGB230 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB231 = 0 Then 
				RGB231 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB232 = 0 Then 
				RGB232 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB233 = 0 Then 
				RGB233 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB234 = 0 Then 
				RGB234 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB235 = 0 Then 
				RGB235 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB236 = 0 Then 
				RGB236 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB237 = 0 Then 
				RGB237 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB238 = 0 Then 
				RGB238 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB239 = 0 Then 
				RGB239 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB240 = 0 Then 
				RGB240 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB241 = 0 Then 
				RGB241 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB242 = 0 Then 
				RGB242 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB243 = 0 Then 
				RGB243 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB244 = 0 Then 
				RGB244 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB245 = 0 Then 
				RGB245 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB246 = 0 Then 
				RGB246 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB247 = 0 Then 
				RGB247 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB248 = 0 Then 
				RGB248 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB249 = 0 Then 
				RGB249 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB250 = 0 Then 
				RGB250 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB251 = 0 Then 
				RGB251 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB252 = 0 Then 
				RGB252 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB253 = 0 Then 
				RGB253 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB254 = 0 Then 
				RGB254 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB255 = 0 Then 
				RGB255 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB256 = 0 Then 
				RGB256 = pixel
				If pixel = 0 Then blnzero = True
			ElseIf RGB256 = 0 Then 
				RGB257 = pixel
				If pixel = 0 Then blnzero = True
			End If
			If RGB257 <> 0 Then MsgBox("You done fucked up, boyo, 'cause there be too many fuckin' colors in this bitch")
		End If
		
	End Sub
	
	Public Sub ReallyRitePallette()
		
		Dim temp As Byte
		
		'Kill "h:\temp\temp.tmp"
		
		FileOpen(1, My.Application.Info.DirectoryPath & "\temp.tmp", OpenMode.Binary)
		'Open "h:\temp\temp.tmp" For Binary As 1
		
		RGBtemp = RGB001
		Location_Renamed = Location_Renamed + 1
		
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB002
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB003
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB004
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB005
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB006
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB007
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB008
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB009
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB010
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB011
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB012
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB013
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB014
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB015
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB016
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB017
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB018
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB019
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB020
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB021
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB022
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB023
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB024
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB025
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB026
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB027
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB028
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB029
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB030
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB031
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB032
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB033
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB034
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB035
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB036
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB037
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB038
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB039
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB040
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB041
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB042
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB043
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB044
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB045
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB046
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB047
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB048
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB049
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB050
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB051
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB052
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB053
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB054
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB055
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB056
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB057
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB058
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB059
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB060
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB061
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB062
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB063
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB064
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB065
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB066
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB067
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB068
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB069
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB070
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB071
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB072
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB073
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB074
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB075
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB076
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB077
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB078
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB079
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB080
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB081
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB082
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB083
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB084
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB085
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB086
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB087
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB088
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB089
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB090
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB091
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB092
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB093
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB094
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB095
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB096
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB097
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB098
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB099
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB100
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB101
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB102
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB103
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB104
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB105
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB106
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB107
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB108
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB109
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB110
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB111
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB112
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB113
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB114
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB115
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB116
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB117
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB118
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB119
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB120
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB121
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB122
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB123
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB124
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB125
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB126
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB127
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB128
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB129
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB130
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB131
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB132
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB133
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB134
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB135
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB136
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB137
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB138
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB139
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB140
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB141
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB142
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB143
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB144
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB145
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB146
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB147
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB148
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB149
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB150
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB151
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB152
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB153
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB154
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB155
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB156
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB157
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB158
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB159
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB160
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB161
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB162
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB163
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB164
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB165
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB166
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB167
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB168
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB169
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB170
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB171
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB172
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB173
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB174
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB175
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB176
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB177
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB178
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB179
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB180
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB181
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB182
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB183
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB184
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB185
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB186
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB187
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB188
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB189
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB190
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB191
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB192
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB193
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB194
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB195
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB196
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB197
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB198
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB199
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB200
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB201
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB202
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB203
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB204
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB205
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB206
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB207
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB208
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB209
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB210
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB211
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB212
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB213
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB214
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB215
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB216
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB217
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB218
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB219
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB220
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB221
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB222
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB223
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB224
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB225
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB226
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB227
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB228
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB229
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB230
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB231
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB232
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB233
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB234
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB235
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB236
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB237
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB238
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB239
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB240
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB241
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB242
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB243
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB244
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB245
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB246
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB247
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB248
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB249
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB250
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB251
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB252
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB253
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB254
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB255
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		RGBtemp = RGB256
		Call Long_Dec()
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, R, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, G, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, B, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(1, A, Location_Renamed)
		Location_Renamed = Location_Renamed + 1
		
		
		FileClose(1)
		Location_Renamed = 0
	End Sub
	
	Private Sub WriteTile()
		
		ReDim Tile(4096)
		Dim count As Integer
		Dim FileDump() As Byte
		ReDim FileDump(1024)
		
		
		X = Picture1.ClientRectangle.Width
		Y = Picture1.ClientRectangle.Height
		For i = 0 To Y - 1
			System.Windows.Forms.Application.DoEvents()
			For j = 0 To X - 1
				System.Windows.Forms.Application.DoEvents()
				'UPGRADE_ISSUE: PictureBox property Picture1.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				pixel = GetPixel(Picture1.hDC, j, i)
				If pixel = RGB001 Then
					Tile(count) = 0
				ElseIf pixel = RGB002 Then 
					Tile(count) = 1
				ElseIf pixel = RGB003 Then 
					Tile(count) = 2
				ElseIf pixel = RGB004 Then 
					Tile(count) = 3
				ElseIf pixel = RGB005 Then 
					Tile(count) = 4
				ElseIf pixel = RGB006 Then 
					Tile(count) = 5
				ElseIf pixel = RGB007 Then 
					Tile(count) = 6
				ElseIf pixel = RGB008 Then 
					Tile(count) = 7
				ElseIf pixel = RGB009 Then 
					Tile(count) = 8
				ElseIf pixel = RGB010 Then 
					Tile(count) = 9
				ElseIf pixel = RGB011 Then 
					Tile(count) = 10
				ElseIf pixel = RGB012 Then 
					Tile(count) = 11
				ElseIf pixel = RGB013 Then 
					Tile(count) = 12
				ElseIf pixel = RGB014 Then 
					Tile(count) = 13
				ElseIf pixel = RGB015 Then 
					Tile(count) = 14
				ElseIf pixel = RGB016 Then 
					Tile(count) = 15
				ElseIf pixel = RGB017 Then 
					Tile(count) = 16
				ElseIf pixel = RGB018 Then 
					Tile(count) = 17
				ElseIf pixel = RGB019 Then 
					Tile(count) = 18
				ElseIf pixel = RGB020 Then 
					Tile(count) = 19
				ElseIf pixel = RGB021 Then 
					Tile(count) = 20
				ElseIf pixel = RGB022 Then 
					Tile(count) = 21
				ElseIf pixel = RGB023 Then 
					Tile(count) = 22
				ElseIf pixel = RGB024 Then 
					Tile(count) = 23
				ElseIf pixel = RGB025 Then 
					Tile(count) = 24
				ElseIf pixel = RGB026 Then 
					Tile(count) = 25
				ElseIf pixel = RGB027 Then 
					Tile(count) = 26
				ElseIf pixel = RGB028 Then 
					Tile(count) = 27
				ElseIf pixel = RGB029 Then 
					Tile(count) = 28
				ElseIf pixel = RGB030 Then 
					Tile(count) = 29
				ElseIf pixel = RGB031 Then 
					Tile(count) = 30
				ElseIf pixel = RGB032 Then 
					Tile(count) = 31
				ElseIf pixel = RGB033 Then 
					Tile(count) = 32
				ElseIf pixel = RGB034 Then 
					Tile(count) = 33
				ElseIf pixel = RGB035 Then 
					Tile(count) = 34
				ElseIf pixel = RGB036 Then 
					Tile(count) = 35
				ElseIf pixel = RGB037 Then 
					Tile(count) = 36
				ElseIf pixel = RGB038 Then 
					Tile(count) = 37
				ElseIf pixel = RGB039 Then 
					Tile(count) = 38
				ElseIf pixel = RGB040 Then 
					Tile(count) = 39
				ElseIf pixel = RGB041 Then 
					Tile(count) = 40
				ElseIf pixel = RGB042 Then 
					Tile(count) = 41
				ElseIf pixel = RGB043 Then 
					Tile(count) = 42
				ElseIf pixel = RGB044 Then 
					Tile(count) = 43
				ElseIf pixel = RGB045 Then 
					Tile(count) = 44
				ElseIf pixel = RGB046 Then 
					Tile(count) = 45
				ElseIf pixel = RGB047 Then 
					Tile(count) = 46
				ElseIf pixel = RGB048 Then 
					Tile(count) = 47
				ElseIf pixel = RGB049 Then 
					Tile(count) = 48
				ElseIf pixel = RGB050 Then 
					Tile(count) = 49
				ElseIf pixel = RGB051 Then 
					Tile(count) = 50
				ElseIf pixel = RGB052 Then 
					Tile(count) = 51
				ElseIf pixel = RGB053 Then 
					Tile(count) = 52
				ElseIf pixel = RGB054 Then 
					Tile(count) = 53
				ElseIf pixel = RGB055 Then 
					Tile(count) = 54
				ElseIf pixel = RGB056 Then 
					Tile(count) = 55
				ElseIf pixel = RGB057 Then 
					Tile(count) = 56
				ElseIf pixel = RGB058 Then 
					Tile(count) = 57
				ElseIf pixel = RGB059 Then 
					Tile(count) = 58
				ElseIf pixel = RGB060 Then 
					Tile(count) = 59
				ElseIf pixel = RGB061 Then 
					Tile(count) = 60
				ElseIf pixel = RGB062 Then 
					Tile(count) = 61
				ElseIf pixel = RGB063 Then 
					Tile(count) = 62
				ElseIf pixel = RGB064 Then 
					Tile(count) = 63
				ElseIf pixel = RGB065 Then 
					Tile(count) = 64
				ElseIf pixel = RGB066 Then 
					Tile(count) = 65
				ElseIf pixel = RGB067 Then 
					Tile(count) = 66
				ElseIf pixel = RGB068 Then 
					Tile(count) = 67
				ElseIf pixel = RGB069 Then 
					Tile(count) = 68
				ElseIf pixel = RGB070 Then 
					Tile(count) = 69
				ElseIf pixel = RGB071 Then 
					Tile(count) = 70
				ElseIf pixel = RGB072 Then 
					Tile(count) = 71
				ElseIf pixel = RGB073 Then 
					Tile(count) = 72
				ElseIf pixel = RGB074 Then 
					Tile(count) = 73
				ElseIf pixel = RGB075 Then 
					Tile(count) = 74
				ElseIf pixel = RGB076 Then 
					Tile(count) = 75
				ElseIf pixel = RGB077 Then 
					Tile(count) = 76
				ElseIf pixel = RGB078 Then 
					Tile(count) = 77
				ElseIf pixel = RGB079 Then 
					Tile(count) = 78
				ElseIf pixel = RGB080 Then 
					Tile(count) = 79
				ElseIf pixel = RGB081 Then 
					Tile(count) = 80
				ElseIf pixel = RGB082 Then 
					Tile(count) = 81
				ElseIf pixel = RGB083 Then 
					Tile(count) = 82
				ElseIf pixel = RGB084 Then 
					Tile(count) = 83
				ElseIf pixel = RGB085 Then 
					Tile(count) = 84
				ElseIf pixel = RGB086 Then 
					Tile(count) = 85
				ElseIf pixel = RGB087 Then 
					Tile(count) = 86
				ElseIf pixel = RGB088 Then 
					Tile(count) = 87
				ElseIf pixel = RGB089 Then 
					Tile(count) = 88
				ElseIf pixel = RGB090 Then 
					Tile(count) = 89
				ElseIf pixel = RGB091 Then 
					Tile(count) = 90
				ElseIf pixel = RGB092 Then 
					Tile(count) = 91
				ElseIf pixel = RGB093 Then 
					Tile(count) = 92
				ElseIf pixel = RGB094 Then 
					Tile(count) = 93
				ElseIf pixel = RGB095 Then 
					Tile(count) = 94
				ElseIf pixel = RGB096 Then 
					Tile(count) = 95
				ElseIf pixel = RGB097 Then 
					Tile(count) = 96
				ElseIf pixel = RGB098 Then 
					Tile(count) = 97
				ElseIf pixel = RGB099 Then 
					Tile(count) = 98
				ElseIf pixel = RGB100 Then 
					Tile(count) = 99
				ElseIf pixel = RGB101 Then 
					Tile(count) = 100
				ElseIf pixel = RGB102 Then 
					Tile(count) = 101
				ElseIf pixel = RGB103 Then 
					Tile(count) = 102
				ElseIf pixel = RGB104 Then 
					Tile(count) = 103
				ElseIf pixel = RGB105 Then 
					Tile(count) = 104
				ElseIf pixel = RGB106 Then 
					Tile(count) = 105
				ElseIf pixel = RGB107 Then 
					Tile(count) = 106
				ElseIf pixel = RGB108 Then 
					Tile(count) = 107
				ElseIf pixel = RGB109 Then 
					Tile(count) = 108
				ElseIf pixel = RGB110 Then 
					Tile(count) = 109
				ElseIf pixel = RGB111 Then 
					Tile(count) = 110
				ElseIf pixel = RGB112 Then 
					Tile(count) = 111
				ElseIf pixel = RGB113 Then 
					Tile(count) = 112
				ElseIf pixel = RGB114 Then 
					Tile(count) = 113
				ElseIf pixel = RGB115 Then 
					Tile(count) = 114
				ElseIf pixel = RGB116 Then 
					Tile(count) = 115
				ElseIf pixel = RGB117 Then 
					Tile(count) = 116
				ElseIf pixel = RGB118 Then 
					Tile(count) = 117
				ElseIf pixel = RGB119 Then 
					Tile(count) = 118
				ElseIf pixel = RGB120 Then 
					Tile(count) = 119
				ElseIf pixel = RGB121 Then 
					Tile(count) = 120
				ElseIf pixel = RGB122 Then 
					Tile(count) = 121
				ElseIf pixel = RGB123 Then 
					Tile(count) = 122
				ElseIf pixel = RGB124 Then 
					Tile(count) = 123
				ElseIf pixel = RGB125 Then 
					Tile(count) = 124
				ElseIf pixel = RGB126 Then 
					Tile(count) = 125
				ElseIf pixel = RGB127 Then 
					Tile(count) = 126
				ElseIf pixel = RGB128 Then 
					Tile(count) = 127
				ElseIf pixel = RGB129 Then 
					Tile(count) = 128
				ElseIf pixel = RGB130 Then 
					Tile(count) = 129
				ElseIf pixel = RGB131 Then 
					Tile(count) = 130
				ElseIf pixel = RGB132 Then 
					Tile(count) = 131
				ElseIf pixel = RGB133 Then 
					Tile(count) = 132
				ElseIf pixel = RGB134 Then 
					Tile(count) = 133
				ElseIf pixel = RGB135 Then 
					Tile(count) = 134
				ElseIf pixel = RGB136 Then 
					Tile(count) = 135
				ElseIf pixel = RGB137 Then 
					Tile(count) = 136
				ElseIf pixel = RGB138 Then 
					Tile(count) = 137
				ElseIf pixel = RGB139 Then 
					Tile(count) = 138
				ElseIf pixel = RGB140 Then 
					Tile(count) = 139
				ElseIf pixel = RGB141 Then 
					Tile(count) = 140
				ElseIf pixel = RGB142 Then 
					Tile(count) = 141
				ElseIf pixel = RGB143 Then 
					Tile(count) = 142
				ElseIf pixel = RGB144 Then 
					Tile(count) = 143
				ElseIf pixel = RGB145 Then 
					Tile(count) = 144
				ElseIf pixel = RGB146 Then 
					Tile(count) = 145
				ElseIf pixel = RGB147 Then 
					Tile(count) = 146
				ElseIf pixel = RGB148 Then 
					Tile(count) = 147
				ElseIf pixel = RGB149 Then 
					Tile(count) = 148
				ElseIf pixel = RGB150 Then 
					Tile(count) = 149
				ElseIf pixel = RGB151 Then 
					Tile(count) = 150
				ElseIf pixel = RGB152 Then 
					Tile(count) = 151
				ElseIf pixel = RGB153 Then 
					Tile(count) = 152
				ElseIf pixel = RGB154 Then 
					Tile(count) = 153
				ElseIf pixel = RGB155 Then 
					Tile(count) = 154
				ElseIf pixel = RGB156 Then 
					Tile(count) = 155
				ElseIf pixel = RGB157 Then 
					Tile(count) = 156
				ElseIf pixel = RGB158 Then 
					Tile(count) = 157
				ElseIf pixel = RGB159 Then 
					Tile(count) = 158
				ElseIf pixel = RGB160 Then 
					Tile(count) = 159
				ElseIf pixel = RGB161 Then 
					Tile(count) = 160
				ElseIf pixel = RGB162 Then 
					Tile(count) = 161
				ElseIf pixel = RGB163 Then 
					Tile(count) = 162
				ElseIf pixel = RGB164 Then 
					Tile(count) = 163
				ElseIf pixel = RGB165 Then 
					Tile(count) = 164
				ElseIf pixel = RGB166 Then 
					Tile(count) = 165
				ElseIf pixel = RGB167 Then 
					Tile(count) = 166
				ElseIf pixel = RGB168 Then 
					Tile(count) = 167
				ElseIf pixel = RGB169 Then 
					Tile(count) = 168
				ElseIf pixel = RGB170 Then 
					Tile(count) = 169
				ElseIf pixel = RGB171 Then 
					Tile(count) = 170
				ElseIf pixel = RGB172 Then 
					Tile(count) = 171
				ElseIf pixel = RGB173 Then 
					Tile(count) = 172
				ElseIf pixel = RGB174 Then 
					Tile(count) = 173
				ElseIf pixel = RGB175 Then 
					Tile(count) = 174
				ElseIf pixel = RGB176 Then 
					Tile(count) = 175
				ElseIf pixel = RGB177 Then 
					Tile(count) = 176
				ElseIf pixel = RGB178 Then 
					Tile(count) = 177
				ElseIf pixel = RGB179 Then 
					Tile(count) = 178
				ElseIf pixel = RGB180 Then 
					Tile(count) = 179
				ElseIf pixel = RGB181 Then 
					Tile(count) = 180
				ElseIf pixel = RGB182 Then 
					Tile(count) = 181
				ElseIf pixel = RGB183 Then 
					Tile(count) = 182
				ElseIf pixel = RGB184 Then 
					Tile(count) = 183
				ElseIf pixel = RGB185 Then 
					Tile(count) = 184
				ElseIf pixel = RGB186 Then 
					Tile(count) = 185
				ElseIf pixel = RGB187 Then 
					Tile(count) = 186
				ElseIf pixel = RGB188 Then 
					Tile(count) = 187
				ElseIf pixel = RGB189 Then 
					Tile(count) = 188
				ElseIf pixel = RGB190 Then 
					Tile(count) = 189
				ElseIf pixel = RGB191 Then 
					Tile(count) = 190
				ElseIf pixel = RGB192 Then 
					Tile(count) = 191
				ElseIf pixel = RGB193 Then 
					Tile(count) = 192
				ElseIf pixel = RGB194 Then 
					Tile(count) = 193
				ElseIf pixel = RGB195 Then 
					Tile(count) = 194
				ElseIf pixel = RGB196 Then 
					Tile(count) = 195
				ElseIf pixel = RGB197 Then 
					Tile(count) = 196
				ElseIf pixel = RGB198 Then 
					Tile(count) = 197
				ElseIf pixel = RGB199 Then 
					Tile(count) = 198
				ElseIf pixel = RGB200 Then 
					Tile(count) = 199
				ElseIf pixel = RGB201 Then 
					Tile(count) = 200
				ElseIf pixel = RGB202 Then 
					Tile(count) = 201
				ElseIf pixel = RGB203 Then 
					Tile(count) = 202
				ElseIf pixel = RGB204 Then 
					Tile(count) = 203
				ElseIf pixel = RGB205 Then 
					Tile(count) = 204
				ElseIf pixel = RGB206 Then 
					Tile(count) = 205
				ElseIf pixel = RGB207 Then 
					Tile(count) = 206
				ElseIf pixel = RGB208 Then 
					Tile(count) = 207
				ElseIf pixel = RGB209 Then 
					Tile(count) = 208
				ElseIf pixel = RGB210 Then 
					Tile(count) = 209
				ElseIf pixel = RGB211 Then 
					Tile(count) = 210
				ElseIf pixel = RGB212 Then 
					Tile(count) = 211
				ElseIf pixel = RGB213 Then 
					Tile(count) = 212
				ElseIf pixel = RGB214 Then 
					Tile(count) = 213
				ElseIf pixel = RGB215 Then 
					Tile(count) = 214
				ElseIf pixel = RGB216 Then 
					Tile(count) = 215
				ElseIf pixel = RGB217 Then 
					Tile(count) = 216
				ElseIf pixel = RGB218 Then 
					Tile(count) = 217
				ElseIf pixel = RGB219 Then 
					Tile(count) = 218
				ElseIf pixel = RGB220 Then 
					Tile(count) = 219
				ElseIf pixel = RGB221 Then 
					Tile(count) = 220
				ElseIf pixel = RGB222 Then 
					Tile(count) = 221
				ElseIf pixel = RGB223 Then 
					Tile(count) = 222
				ElseIf pixel = RGB224 Then 
					Tile(count) = 223
				ElseIf pixel = RGB225 Then 
					Tile(count) = 224
				ElseIf pixel = RGB226 Then 
					Tile(count) = 225
				ElseIf pixel = RGB227 Then 
					Tile(count) = 226
				ElseIf pixel = RGB228 Then 
					Tile(count) = 227
				ElseIf pixel = RGB229 Then 
					Tile(count) = 228
				ElseIf pixel = RGB230 Then 
					Tile(count) = 229
				ElseIf pixel = RGB231 Then 
					Tile(count) = 230
				ElseIf pixel = RGB232 Then 
					Tile(count) = 231
				ElseIf pixel = RGB233 Then 
					Tile(count) = 232
				ElseIf pixel = RGB234 Then 
					Tile(count) = 233
				ElseIf pixel = RGB235 Then 
					Tile(count) = 234
				ElseIf pixel = RGB236 Then 
					Tile(count) = 235
				ElseIf pixel = RGB237 Then 
					Tile(count) = 236
				ElseIf pixel = RGB238 Then 
					Tile(count) = 237
				ElseIf pixel = RGB239 Then 
					Tile(count) = 238
				ElseIf pixel = RGB240 Then 
					Tile(count) = 239
				ElseIf pixel = RGB241 Then 
					Tile(count) = 240
				ElseIf pixel = RGB242 Then 
					Tile(count) = 241
				ElseIf pixel = RGB243 Then 
					Tile(count) = 242
				ElseIf pixel = RGB244 Then 
					Tile(count) = 243
				ElseIf pixel = RGB245 Then 
					Tile(count) = 244
				ElseIf pixel = RGB246 Then 
					Tile(count) = 245
				ElseIf pixel = RGB247 Then 
					Tile(count) = 246
				ElseIf pixel = RGB248 Then 
					Tile(count) = 247
				ElseIf pixel = RGB249 Then 
					Tile(count) = 248
				ElseIf pixel = RGB250 Then 
					Tile(count) = 249
				ElseIf pixel = RGB251 Then 
					Tile(count) = 250
				ElseIf pixel = RGB252 Then 
					Tile(count) = 251
				ElseIf pixel = RGB253 Then 
					Tile(count) = 252
				ElseIf pixel = RGB254 Then 
					Tile(count) = 253
				ElseIf pixel = RGB255 Then 
					Tile(count) = 254
				ElseIf pixel = RGB256 Then 
					Tile(count) = 255
				End If
				count = count + 1
				Debug.Print(Tile(4068))
			Next 
		Next 
		
		
		Dim position As Integer
		FileOpen(6, My.Application.Info.DirectoryPath & "\temp.tmp", OpenMode.Binary, OpenAccess.Read)
		'Open "h:\temp\temp.tmp" For Binary Access Read As 6
		For position = 1 To 1024
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FileGet(6, FileDump(position - 1), position)
		Next 
		
		FileClose(6)
		
		
		
		Dim Pallette() As Byte
		'UPGRADE_NOTE: Size was upgraded to Size_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Size_Renamed As Integer
		ReDim Pallette(1024)
		count = 1
		Dim countZ As Integer
		Dim temp As String
		
		FileOpen(1, LocationLocationLocation, OpenMode.Binary)
		
		Dim Dump As Integer
		countZ = 1024 + 1
		For Dump = 1 To 1024
			'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FilePut(1, FileDump(Dump - 1), Dump)
		Next 
		
		For count = 0 To 4095
			'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FilePut(1, Tile(count), countZ)
			countZ = countZ + 1
		Next 
		
		FileClose(1)
		'size = size + 1
		
		
		
		MsgBox("DONE")
		
		
	End Sub
	
	
	Public Sub Tile_Open()
		
		Dim File() As Byte
		ReDim File(5120)
		Dim Pallette() As Integer
		ReDim Pallette(256)
		Dim Looper, Looping As Integer
		Dim Tempb, Tempa, Tempc As Byte
		Dim position As Integer
		
		FileOpen(3, (BMPLocation), OpenMode.Binary, OpenAccess.Read)
		For position = 1 To 5120
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FileGet(3, File(position - 1), position)
		Next 
		FileClose(3)
		RGB001 = RGB(File(2), File(1), File(0))
		RGB002 = RGB(File(6), File(5), File(4))
		RGB003 = RGB(File(10), File(9), File(8))
		RGB004 = RGB(File(14), File(13), File(12))
		RGB005 = RGB(File(18), File(17), File(16))
		RGB006 = RGB(File(22), File(21), File(20))
		RGB007 = RGB(File(26), File(25), File(24))
		RGB008 = RGB(File(30), File(29), File(28))
		RGB009 = RGB(File(34), File(33), File(32))
		RGB010 = RGB(File(38), File(37), File(36))
		RGB011 = RGB(File(42), File(41), File(40))
		RGB012 = RGB(File(46), File(45), File(44))
		RGB013 = RGB(File(50), File(49), File(48))
		RGB014 = RGB(File(54), File(53), File(52))
		RGB015 = RGB(File(58), File(57), File(56))
		RGB016 = RGB(File(62), File(61), File(60))
		RGB017 = RGB(File(66), File(65), File(64))
		RGB018 = RGB(File(70), File(69), File(68))
		RGB019 = RGB(File(74), File(73), File(72))
		RGB020 = RGB(File(78), File(77), File(76))
		RGB021 = RGB(File(82), File(81), File(80))
		RGB022 = RGB(File(86), File(85), File(84))
		RGB023 = RGB(File(90), File(89), File(88))
		RGB024 = RGB(File(94), File(93), File(92))
		RGB025 = RGB(File(98), File(97), File(96))
		RGB026 = RGB(File(102), File(101), File(100))
		RGB027 = RGB(File(106), File(105), File(104))
		RGB028 = RGB(File(110), File(109), File(108))
		RGB029 = RGB(File(114), File(113), File(112))
		RGB030 = RGB(File(118), File(117), File(116))
		RGB031 = RGB(File(122), File(121), File(120))
		RGB032 = RGB(File(126), File(125), File(124))
		RGB033 = RGB(File(130), File(129), File(128))
		RGB034 = RGB(File(134), File(133), File(132))
		RGB035 = RGB(File(138), File(137), File(136))
		RGB036 = RGB(File(142), File(141), File(140))
		RGB037 = RGB(File(146), File(145), File(144))
		RGB038 = RGB(File(150), File(149), File(148))
		RGB039 = RGB(File(154), File(153), File(152))
		RGB040 = RGB(File(158), File(157), File(156))
		RGB041 = RGB(File(162), File(161), File(160))
		RGB042 = RGB(File(166), File(165), File(164))
		RGB043 = RGB(File(170), File(169), File(168))
		RGB044 = RGB(File(174), File(173), File(172))
		RGB045 = RGB(File(178), File(177), File(176))
		RGB046 = RGB(File(182), File(181), File(180))
		RGB047 = RGB(File(186), File(185), File(184))
		RGB048 = RGB(File(190), File(189), File(188))
		RGB049 = RGB(File(194), File(193), File(192))
		RGB050 = RGB(File(198), File(197), File(196))
		RGB051 = RGB(File(202), File(201), File(200))
		RGB052 = RGB(File(206), File(205), File(204))
		RGB053 = RGB(File(210), File(209), File(208))
		RGB054 = RGB(File(214), File(213), File(212))
		RGB055 = RGB(File(218), File(217), File(216))
		RGB056 = RGB(File(222), File(221), File(220))
		RGB057 = RGB(File(226), File(225), File(224))
		RGB058 = RGB(File(230), File(229), File(228))
		RGB059 = RGB(File(234), File(233), File(232))
		RGB060 = RGB(File(238), File(237), File(236))
		RGB061 = RGB(File(242), File(241), File(240))
		RGB062 = RGB(File(246), File(245), File(244))
		RGB063 = RGB(File(250), File(249), File(248))
		RGB064 = RGB(File(254), File(253), File(252))
		RGB065 = RGB(File(258), File(257), File(256))
		RGB066 = RGB(File(262), File(261), File(260))
		RGB067 = RGB(File(266), File(265), File(264))
		RGB068 = RGB(File(270), File(269), File(268))
		RGB069 = RGB(File(274), File(273), File(272))
		RGB070 = RGB(File(278), File(277), File(276))
		RGB071 = RGB(File(282), File(281), File(280))
		RGB072 = RGB(File(286), File(285), File(284))
		RGB073 = RGB(File(290), File(289), File(288))
		RGB074 = RGB(File(294), File(293), File(292))
		RGB075 = RGB(File(298), File(297), File(296))
		RGB076 = RGB(File(302), File(301), File(300))
		RGB077 = RGB(File(306), File(305), File(304))
		RGB078 = RGB(File(310), File(309), File(308))
		RGB079 = RGB(File(314), File(313), File(312))
		RGB080 = RGB(File(318), File(317), File(316))
		RGB081 = RGB(File(322), File(321), File(320))
		RGB082 = RGB(File(326), File(325), File(324))
		RGB083 = RGB(File(330), File(329), File(328))
		RGB084 = RGB(File(334), File(333), File(332))
		RGB085 = RGB(File(338), File(337), File(336))
		RGB086 = RGB(File(342), File(341), File(340))
		RGB087 = RGB(File(346), File(345), File(344))
		RGB088 = RGB(File(350), File(349), File(348))
		RGB089 = RGB(File(354), File(353), File(352))
		RGB090 = RGB(File(358), File(357), File(356))
		RGB091 = RGB(File(362), File(361), File(360))
		RGB092 = RGB(File(366), File(365), File(364))
		RGB093 = RGB(File(370), File(369), File(368))
		RGB094 = RGB(File(374), File(373), File(372))
		RGB095 = RGB(File(378), File(377), File(376))
		RGB096 = RGB(File(382), File(381), File(380))
		RGB097 = RGB(File(386), File(385), File(384))
		RGB098 = RGB(File(390), File(389), File(388))
		RGB099 = RGB(File(394), File(393), File(392))
		RGB100 = RGB(File(398), File(397), File(396))
		RGB101 = RGB(File(402), File(401), File(400))
		RGB102 = RGB(File(406), File(405), File(404))
		RGB103 = RGB(File(410), File(409), File(408))
		RGB104 = RGB(File(414), File(413), File(412))
		RGB105 = RGB(File(418), File(417), File(416))
		RGB106 = RGB(File(422), File(421), File(420))
		RGB107 = RGB(File(426), File(425), File(424))
		RGB108 = RGB(File(430), File(429), File(428))
		RGB109 = RGB(File(434), File(433), File(432))
		RGB110 = RGB(File(438), File(437), File(436))
		RGB111 = RGB(File(442), File(441), File(440))
		RGB112 = RGB(File(446), File(445), File(444))
		RGB113 = RGB(File(450), File(449), File(448))
		RGB114 = RGB(File(454), File(453), File(452))
		RGB115 = RGB(File(458), File(457), File(456))
		RGB116 = RGB(File(462), File(461), File(460))
		RGB117 = RGB(File(466), File(465), File(464))
		RGB118 = RGB(File(470), File(469), File(468))
		RGB119 = RGB(File(474), File(473), File(472))
		RGB120 = RGB(File(478), File(477), File(476))
		RGB121 = RGB(File(482), File(481), File(480))
		RGB122 = RGB(File(486), File(485), File(484))
		RGB123 = RGB(File(490), File(489), File(488))
		RGB124 = RGB(File(494), File(493), File(492))
		RGB125 = RGB(File(498), File(497), File(496))
		RGB126 = RGB(File(502), File(501), File(500))
		RGB127 = RGB(File(506), File(505), File(504))
		RGB128 = RGB(File(510), File(509), File(508))
		RGB129 = RGB(File(514), File(513), File(512))
		RGB130 = RGB(File(518), File(517), File(516))
		RGB131 = RGB(File(522), File(521), File(520))
		RGB132 = RGB(File(526), File(525), File(524))
		RGB133 = RGB(File(530), File(529), File(528))
		RGB134 = RGB(File(534), File(533), File(532))
		RGB135 = RGB(File(538), File(537), File(536))
		RGB136 = RGB(File(542), File(541), File(540))
		RGB137 = RGB(File(546), File(545), File(544))
		RGB138 = RGB(File(550), File(549), File(548))
		RGB139 = RGB(File(554), File(553), File(552))
		RGB140 = RGB(File(558), File(557), File(556))
		RGB141 = RGB(File(562), File(561), File(560))
		RGB142 = RGB(File(566), File(565), File(564))
		RGB143 = RGB(File(570), File(569), File(568))
		RGB144 = RGB(File(574), File(573), File(572))
		RGB145 = RGB(File(578), File(577), File(576))
		RGB146 = RGB(File(582), File(581), File(580))
		RGB147 = RGB(File(586), File(585), File(584))
		RGB148 = RGB(File(590), File(589), File(588))
		RGB149 = RGB(File(594), File(593), File(592))
		RGB150 = RGB(File(598), File(597), File(596))
		RGB151 = RGB(File(602), File(601), File(600))
		RGB152 = RGB(File(606), File(605), File(604))
		RGB153 = RGB(File(610), File(609), File(608))
		RGB154 = RGB(File(614), File(613), File(612))
		RGB155 = RGB(File(618), File(617), File(616))
		RGB156 = RGB(File(622), File(621), File(620))
		RGB157 = RGB(File(626), File(625), File(624))
		RGB158 = RGB(File(630), File(629), File(628))
		RGB159 = RGB(File(634), File(633), File(632))
		RGB160 = RGB(File(638), File(637), File(636))
		RGB161 = RGB(File(642), File(641), File(640))
		RGB162 = RGB(File(646), File(645), File(644))
		RGB163 = RGB(File(650), File(649), File(648))
		RGB164 = RGB(File(654), File(653), File(652))
		RGB165 = RGB(File(658), File(657), File(656))
		RGB166 = RGB(File(662), File(661), File(660))
		RGB167 = RGB(File(666), File(665), File(664))
		RGB168 = RGB(File(670), File(669), File(668))
		RGB169 = RGB(File(674), File(673), File(672))
		RGB170 = RGB(File(678), File(677), File(676))
		RGB171 = RGB(File(682), File(681), File(680))
		RGB172 = RGB(File(686), File(685), File(684))
		RGB173 = RGB(File(690), File(689), File(688))
		RGB174 = RGB(File(694), File(693), File(692))
		RGB175 = RGB(File(698), File(697), File(696))
		RGB176 = RGB(File(702), File(701), File(700))
		RGB177 = RGB(File(706), File(705), File(704))
		RGB178 = RGB(File(710), File(709), File(708))
		RGB179 = RGB(File(714), File(713), File(712))
		RGB180 = RGB(File(718), File(717), File(716))
		RGB181 = RGB(File(722), File(721), File(720))
		RGB182 = RGB(File(726), File(725), File(724))
		RGB183 = RGB(File(730), File(729), File(728))
		RGB184 = RGB(File(734), File(733), File(732))
		RGB185 = RGB(File(738), File(737), File(736))
		RGB186 = RGB(File(742), File(741), File(740))
		RGB187 = RGB(File(746), File(745), File(744))
		RGB188 = RGB(File(750), File(749), File(748))
		RGB189 = RGB(File(754), File(753), File(752))
		RGB190 = RGB(File(758), File(757), File(756))
		RGB191 = RGB(File(762), File(761), File(760))
		RGB192 = RGB(File(766), File(765), File(764))
		RGB193 = RGB(File(770), File(769), File(768))
		RGB194 = RGB(File(774), File(773), File(772))
		RGB195 = RGB(File(778), File(777), File(776))
		RGB196 = RGB(File(782), File(781), File(780))
		RGB197 = RGB(File(786), File(785), File(784))
		RGB198 = RGB(File(790), File(789), File(788))
		RGB199 = RGB(File(794), File(793), File(792))
		RGB200 = RGB(File(798), File(797), File(796))
		RGB201 = RGB(File(802), File(801), File(800))
		RGB202 = RGB(File(806), File(805), File(804))
		RGB203 = RGB(File(810), File(809), File(808))
		RGB204 = RGB(File(814), File(813), File(812))
		RGB205 = RGB(File(818), File(817), File(816))
		RGB206 = RGB(File(822), File(821), File(820))
		RGB207 = RGB(File(826), File(825), File(824))
		RGB208 = RGB(File(830), File(829), File(828))
		RGB209 = RGB(File(834), File(833), File(832))
		RGB210 = RGB(File(838), File(837), File(836))
		RGB211 = RGB(File(842), File(841), File(840))
		RGB212 = RGB(File(846), File(845), File(844))
		RGB213 = RGB(File(850), File(849), File(848))
		RGB214 = RGB(File(854), File(853), File(852))
		RGB215 = RGB(File(858), File(857), File(856))
		RGB216 = RGB(File(862), File(861), File(860))
		RGB217 = RGB(File(866), File(865), File(864))
		RGB218 = RGB(File(870), File(869), File(868))
		RGB219 = RGB(File(874), File(873), File(872))
		RGB220 = RGB(File(878), File(877), File(876))
		RGB221 = RGB(File(882), File(881), File(880))
		RGB222 = RGB(File(886), File(885), File(884))
		RGB223 = RGB(File(890), File(889), File(888))
		RGB224 = RGB(File(894), File(893), File(892))
		RGB225 = RGB(File(898), File(897), File(896))
		RGB226 = RGB(File(902), File(901), File(900))
		RGB227 = RGB(File(906), File(905), File(904))
		RGB228 = RGB(File(910), File(909), File(908))
		RGB229 = RGB(File(914), File(913), File(912))
		RGB230 = RGB(File(918), File(917), File(916))
		RGB231 = RGB(File(922), File(921), File(920))
		RGB232 = RGB(File(926), File(925), File(924))
		RGB233 = RGB(File(930), File(929), File(928))
		RGB234 = RGB(File(934), File(933), File(932))
		RGB235 = RGB(File(938), File(937), File(936))
		RGB236 = RGB(File(942), File(941), File(940))
		RGB237 = RGB(File(946), File(945), File(944))
		RGB238 = RGB(File(950), File(949), File(948))
		RGB239 = RGB(File(954), File(953), File(952))
		RGB240 = RGB(File(958), File(957), File(956))
		RGB241 = RGB(File(962), File(961), File(960))
		RGB242 = RGB(File(966), File(965), File(964))
		RGB243 = RGB(File(970), File(969), File(968))
		RGB244 = RGB(File(974), File(973), File(972))
		RGB245 = RGB(File(978), File(977), File(976))
		RGB246 = RGB(File(982), File(981), File(980))
		RGB247 = RGB(File(986), File(985), File(984))
		RGB248 = RGB(File(990), File(989), File(988))
		RGB249 = RGB(File(994), File(993), File(992))
		RGB250 = RGB(File(998), File(997), File(996))
		RGB251 = RGB(File(1002), File(1001), File(1000))
		RGB252 = RGB(File(1006), File(1005), File(1004))
		RGB253 = RGB(File(1010), File(1009), File(1008))
		RGB254 = RGB(File(1014), File(1013), File(1012))
		RGB255 = RGB(File(1018), File(1017), File(1016))
		RGB256 = RGB(File(1022), File(1021), File(1020))
		
		Looper = 1024
		Looping = 0
		
		
		j = 0
		i = 0
		For Looper = 1024 To 5119
			If File(Looper) = 0 Then
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB001)
			ElseIf File(Looper) = 1 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB002)
			ElseIf File(Looper) = 2 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB003)
			ElseIf File(Looper) = 3 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB004)
			ElseIf File(Looper) = 4 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB005)
			ElseIf File(Looper) = 5 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB006)
			ElseIf File(Looper) = 6 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB007)
			ElseIf File(Looper) = 7 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB008)
			ElseIf File(Looper) = 8 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB009)
			ElseIf File(Looper) = 9 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB010)
			ElseIf File(Looper) = 10 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB011)
			ElseIf File(Looper) = 11 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB012)
			ElseIf File(Looper) = 12 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB013)
			ElseIf File(Looper) = 13 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB014)
			ElseIf File(Looper) = 14 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB015)
			ElseIf File(Looper) = 15 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB016)
			ElseIf File(Looper) = 16 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB017)
			ElseIf File(Looper) = 17 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB018)
			ElseIf File(Looper) = 18 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB019)
			ElseIf File(Looper) = 19 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB020)
			ElseIf File(Looper) = 20 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB021)
			ElseIf File(Looper) = 21 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB022)
			ElseIf File(Looper) = 22 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB023)
			ElseIf File(Looper) = 23 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB024)
			ElseIf File(Looper) = 24 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB025)
			ElseIf File(Looper) = 25 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB026)
			ElseIf File(Looper) = 26 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB027)
			ElseIf File(Looper) = 27 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB028)
			ElseIf File(Looper) = 28 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB029)
			ElseIf File(Looper) = 29 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB030)
			ElseIf File(Looper) = 30 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB031)
			ElseIf File(Looper) = 31 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB032)
			ElseIf File(Looper) = 32 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB033)
			ElseIf File(Looper) = 33 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB034)
			ElseIf File(Looper) = 34 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB035)
			ElseIf File(Looper) = 35 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB036)
			ElseIf File(Looper) = 36 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB037)
			ElseIf File(Looper) = 37 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB038)
			ElseIf File(Looper) = 38 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB039)
			ElseIf File(Looper) = 39 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB040)
			ElseIf File(Looper) = 40 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB041)
			ElseIf File(Looper) = 41 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB042)
			ElseIf File(Looper) = 42 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB043)
			ElseIf File(Looper) = 43 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB044)
			ElseIf File(Looper) = 44 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB045)
			ElseIf File(Looper) = 45 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB046)
			ElseIf File(Looper) = 46 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB047)
			ElseIf File(Looper) = 47 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB048)
			ElseIf File(Looper) = 48 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB049)
			ElseIf File(Looper) = 49 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB050)
			ElseIf File(Looper) = 50 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB051)
			ElseIf File(Looper) = 51 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB052)
			ElseIf File(Looper) = 52 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB053)
			ElseIf File(Looper) = 53 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB054)
			ElseIf File(Looper) = 54 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB055)
			ElseIf File(Looper) = 55 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB056)
			ElseIf File(Looper) = 56 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB057)
			ElseIf File(Looper) = 57 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB058)
			ElseIf File(Looper) = 58 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB059)
			ElseIf File(Looper) = 59 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB060)
			ElseIf File(Looper) = 60 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB061)
			ElseIf File(Looper) = 61 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB062)
			ElseIf File(Looper) = 62 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB063)
			ElseIf File(Looper) = 63 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB064)
			ElseIf File(Looper) = 64 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB065)
			ElseIf File(Looper) = 65 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB066)
			ElseIf File(Looper) = 66 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB067)
			ElseIf File(Looper) = 67 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB068)
			ElseIf File(Looper) = 68 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB069)
			ElseIf File(Looper) = 69 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB070)
			ElseIf File(Looper) = 70 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB071)
			ElseIf File(Looper) = 71 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB072)
			ElseIf File(Looper) = 72 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB073)
			ElseIf File(Looper) = 73 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB074)
			ElseIf File(Looper) = 74 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB075)
			ElseIf File(Looper) = 75 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB076)
			ElseIf File(Looper) = 76 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB077)
			ElseIf File(Looper) = 77 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB078)
			ElseIf File(Looper) = 78 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB079)
			ElseIf File(Looper) = 79 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB080)
			ElseIf File(Looper) = 80 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB081)
			ElseIf File(Looper) = 81 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB082)
			ElseIf File(Looper) = 82 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB083)
			ElseIf File(Looper) = 83 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB084)
			ElseIf File(Looper) = 84 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB085)
			ElseIf File(Looper) = 85 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB086)
			ElseIf File(Looper) = 86 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB087)
			ElseIf File(Looper) = 87 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB088)
			ElseIf File(Looper) = 88 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB089)
			ElseIf File(Looper) = 89 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB090)
			ElseIf File(Looper) = 90 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB091)
			ElseIf File(Looper) = 91 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB092)
			ElseIf File(Looper) = 92 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB093)
			ElseIf File(Looper) = 93 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB094)
			ElseIf File(Looper) = 94 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB095)
			ElseIf File(Looper) = 95 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB096)
			ElseIf File(Looper) = 96 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB097)
			ElseIf File(Looper) = 97 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB098)
			ElseIf File(Looper) = 98 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB099)
			ElseIf File(Looper) = 99 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB100)
			ElseIf File(Looper) = 100 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB101)
			ElseIf File(Looper) = 101 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB102)
			ElseIf File(Looper) = 102 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB103)
			ElseIf File(Looper) = 103 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB104)
			ElseIf File(Looper) = 104 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB105)
			ElseIf File(Looper) = 105 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB106)
			ElseIf File(Looper) = 106 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB107)
			ElseIf File(Looper) = 107 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB108)
			ElseIf File(Looper) = 108 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB109)
			ElseIf File(Looper) = 109 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB110)
			ElseIf File(Looper) = 110 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB111)
			ElseIf File(Looper) = 111 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB112)
			ElseIf File(Looper) = 112 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB113)
			ElseIf File(Looper) = 113 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB114)
			ElseIf File(Looper) = 114 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB115)
			ElseIf File(Looper) = 115 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB116)
			ElseIf File(Looper) = 116 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB117)
			ElseIf File(Looper) = 117 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB118)
			ElseIf File(Looper) = 118 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB119)
			ElseIf File(Looper) = 119 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB120)
			ElseIf File(Looper) = 120 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB121)
			ElseIf File(Looper) = 121 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB122)
			ElseIf File(Looper) = 122 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB123)
			ElseIf File(Looper) = 123 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB124)
			ElseIf File(Looper) = 124 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB125)
			ElseIf File(Looper) = 125 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB126)
			ElseIf File(Looper) = 126 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB127)
			ElseIf File(Looper) = 127 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB128)
			ElseIf File(Looper) = 128 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB129)
			ElseIf File(Looper) = 129 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB130)
			ElseIf File(Looper) = 130 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB131)
			ElseIf File(Looper) = 131 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB132)
			ElseIf File(Looper) = 132 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB133)
			ElseIf File(Looper) = 133 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB134)
			ElseIf File(Looper) = 134 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB135)
			ElseIf File(Looper) = 135 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB136)
			ElseIf File(Looper) = 136 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB137)
			ElseIf File(Looper) = 137 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB138)
			ElseIf File(Looper) = 138 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB139)
			ElseIf File(Looper) = 139 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB140)
			ElseIf File(Looper) = 140 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB141)
			ElseIf File(Looper) = 141 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB142)
			ElseIf File(Looper) = 142 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB143)
			ElseIf File(Looper) = 143 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB144)
			ElseIf File(Looper) = 144 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB145)
			ElseIf File(Looper) = 145 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB146)
			ElseIf File(Looper) = 146 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB147)
			ElseIf File(Looper) = 147 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB148)
			ElseIf File(Looper) = 148 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB149)
			ElseIf File(Looper) = 149 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB150)
			ElseIf File(Looper) = 150 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB151)
			ElseIf File(Looper) = 151 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB152)
			ElseIf File(Looper) = 152 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB153)
			ElseIf File(Looper) = 153 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB154)
			ElseIf File(Looper) = 154 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB155)
			ElseIf File(Looper) = 155 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB156)
			ElseIf File(Looper) = 156 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB157)
			ElseIf File(Looper) = 157 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB158)
			ElseIf File(Looper) = 158 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB159)
			ElseIf File(Looper) = 159 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB160)
			ElseIf File(Looper) = 160 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB161)
			ElseIf File(Looper) = 161 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB162)
			ElseIf File(Looper) = 162 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB163)
			ElseIf File(Looper) = 163 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB164)
			ElseIf File(Looper) = 164 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB165)
			ElseIf File(Looper) = 165 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB166)
			ElseIf File(Looper) = 166 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB167)
			ElseIf File(Looper) = 167 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB168)
			ElseIf File(Looper) = 168 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB169)
			ElseIf File(Looper) = 169 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB170)
			ElseIf File(Looper) = 170 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB171)
			ElseIf File(Looper) = 171 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB172)
			ElseIf File(Looper) = 172 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB173)
			ElseIf File(Looper) = 173 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB174)
			ElseIf File(Looper) = 174 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB175)
			ElseIf File(Looper) = 175 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB176)
			ElseIf File(Looper) = 176 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB177)
			ElseIf File(Looper) = 177 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB178)
			ElseIf File(Looper) = 178 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB179)
			ElseIf File(Looper) = 179 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB180)
			ElseIf File(Looper) = 180 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB181)
			ElseIf File(Looper) = 181 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB182)
			ElseIf File(Looper) = 182 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB183)
			ElseIf File(Looper) = 183 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB184)
			ElseIf File(Looper) = 184 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB185)
			ElseIf File(Looper) = 185 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB186)
			ElseIf File(Looper) = 186 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB187)
			ElseIf File(Looper) = 187 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB188)
			ElseIf File(Looper) = 188 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB189)
			ElseIf File(Looper) = 189 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB190)
			ElseIf File(Looper) = 190 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB191)
			ElseIf File(Looper) = 191 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB192)
			ElseIf File(Looper) = 192 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB193)
			ElseIf File(Looper) = 193 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB194)
			ElseIf File(Looper) = 194 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB195)
			ElseIf File(Looper) = 195 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB196)
			ElseIf File(Looper) = 196 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB197)
			ElseIf File(Looper) = 197 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB198)
			ElseIf File(Looper) = 198 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB199)
			ElseIf File(Looper) = 199 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB200)
			ElseIf File(Looper) = 200 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB201)
			ElseIf File(Looper) = 201 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB202)
			ElseIf File(Looper) = 202 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB203)
			ElseIf File(Looper) = 203 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB204)
			ElseIf File(Looper) = 204 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB205)
			ElseIf File(Looper) = 205 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB206)
			ElseIf File(Looper) = 206 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB207)
			ElseIf File(Looper) = 207 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB208)
			ElseIf File(Looper) = 208 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB209)
			ElseIf File(Looper) = 209 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB210)
			ElseIf File(Looper) = 210 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB211)
			ElseIf File(Looper) = 211 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB212)
			ElseIf File(Looper) = 212 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB213)
			ElseIf File(Looper) = 213 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB214)
			ElseIf File(Looper) = 214 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB215)
			ElseIf File(Looper) = 215 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB216)
			ElseIf File(Looper) = 216 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB217)
			ElseIf File(Looper) = 217 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB218)
			ElseIf File(Looper) = 218 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB219)
			ElseIf File(Looper) = 219 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB220)
			ElseIf File(Looper) = 220 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB221)
			ElseIf File(Looper) = 221 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB222)
			ElseIf File(Looper) = 222 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB223)
			ElseIf File(Looper) = 223 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB224)
			ElseIf File(Looper) = 224 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB225)
			ElseIf File(Looper) = 225 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB226)
			ElseIf File(Looper) = 226 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB227)
			ElseIf File(Looper) = 227 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB228)
			ElseIf File(Looper) = 228 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB229)
			ElseIf File(Looper) = 229 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB230)
			ElseIf File(Looper) = 230 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB231)
			ElseIf File(Looper) = 231 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB232)
			ElseIf File(Looper) = 232 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB233)
			ElseIf File(Looper) = 233 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB234)
			ElseIf File(Looper) = 234 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB235)
			ElseIf File(Looper) = 235 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB236)
			ElseIf File(Looper) = 236 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB237)
			ElseIf File(Looper) = 237 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB238)
			ElseIf File(Looper) = 238 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB239)
			ElseIf File(Looper) = 239 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB240)
			ElseIf File(Looper) = 240 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB241)
			ElseIf File(Looper) = 241 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB242)
			ElseIf File(Looper) = 242 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB243)
			ElseIf File(Looper) = 243 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB244)
			ElseIf File(Looper) = 244 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB245)
			ElseIf File(Looper) = 245 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB246)
			ElseIf File(Looper) = 246 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB247)
			ElseIf File(Looper) = 247 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB248)
			ElseIf File(Looper) = 248 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB249)
			ElseIf File(Looper) = 249 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB250)
			ElseIf File(Looper) = 250 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB251)
			ElseIf File(Looper) = 251 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB252)
			ElseIf File(Looper) = 252 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB253)
			ElseIf File(Looper) = 253 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB254)
			ElseIf File(Looper) = 254 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB255)
			ElseIf File(Looper) = 255 Then 
				'UPGRADE_ISSUE: PictureBox property picOpenedTile.hDC was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
				SetPixel(picOpenedTile.hDC, j, i, RGB256)
			End If
			j = j + 1
			
			If j = 64 Then
				j = 0
				i = i + 1
			End If
			If i = 64 Then
				Picture1.Refresh()
				MsgBox("DONE")
				Exit Sub
			End If
		Next 
	End Sub
	
	Private Sub cmdBitmapSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBitmapSave.Click
		On Error Resume Next
		'UPGRADE_WARNING: CommonDialog variable was not upgraded Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
		With cdgDialog
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			.CancelError = True
			'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			.Filter = "Bitmap (*.bmp)"
			.FileName = "*.bmp"
			.ShowDialog()
			If Err.Number = 0 Then
				If .FileName <> vbNullString Then
				End If
			End If
			
		End With
		
		'UPGRADE_WARNING: SavePicture was upgraded to System.Drawing.Image.Save and has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		picOpenedTile.Image.Save(cdgDialogOpen.FileName)
	End Sub
End Class