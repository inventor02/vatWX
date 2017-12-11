<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.RouteTabPage = New System.Windows.Forms.TabPage()
        Me.RouteDownloadButton = New System.Windows.Forms.Button()
        Me.RouteResultGroupBox = New System.Windows.Forms.GroupBox()
        Me.RouteAlternateCopyButton = New System.Windows.Forms.Button()
        Me.RouteDestinationCopyButton = New System.Windows.Forms.Button()
        Me.RouteDepartureCopyButton = New System.Windows.Forms.Button()
        Me.RouteResultAlternateTextBox = New System.Windows.Forms.TextBox()
        Me.RouteResultDestinationTextBox = New System.Windows.Forms.TextBox()
        Me.RouteResultDepartureTextBox = New System.Windows.Forms.TextBox()
        Me.RouteResultAlternateLabel = New System.Windows.Forms.Label()
        Me.RouteResultDestinationLabel = New System.Windows.Forms.Label()
        Me.RouteResultDepartureLabel = New System.Windows.Forms.Label()
        Me.RouteSetupGroupBox = New System.Windows.Forms.GroupBox()
        Me.RouteAlternateTextBox = New System.Windows.Forms.TextBox()
        Me.RouteAlternateLabel = New System.Windows.Forms.Label()
        Me.RouteDestinationTextBox = New System.Windows.Forms.TextBox()
        Me.RouteDestinationLabel = New System.Windows.Forms.Label()
        Me.RouteDepartureTextBox = New System.Windows.Forms.TextBox()
        Me.RouteDepartureLabel = New System.Windows.Forms.Label()
        Me.StationTabPage = New System.Windows.Forms.TabPage()
        Me.CustomDownloadButton = New System.Windows.Forms.Button()
        Me.CustomResultGroupBox = New System.Windows.Forms.GroupBox()
        Me.CustomResultCopyButton = New System.Windows.Forms.Button()
        Me.CustomResultTextBox = New System.Windows.Forms.TextBox()
        Me.CustomSetupGroupBox = New System.Windows.Forms.GroupBox()
        Me.CustomStationTextBox = New System.Windows.Forms.TextBox()
        Me.CustomStationLabel = New System.Windows.Forms.Label()
        Me.AttributionLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.MainFormToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainTabControl.SuspendLayout()
        Me.RouteTabPage.SuspendLayout()
        Me.RouteResultGroupBox.SuspendLayout()
        Me.RouteSetupGroupBox.SuspendLayout()
        Me.StationTabPage.SuspendLayout()
        Me.CustomResultGroupBox.SuspendLayout()
        Me.CustomSetupGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.vatWX.My.Resources.Resources.Text
        Me.LogoPictureBox.Location = New System.Drawing.Point(194, 12)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(210, 50)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Location = New System.Drawing.Point(371, 51)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(31, 13)
        Me.VersionLabel.TabIndex = 1
        Me.VersionLabel.Text = "0.0.0"
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.RouteTabPage)
        Me.MainTabControl.Controls.Add(Me.StationTabPage)
        Me.MainTabControl.Location = New System.Drawing.Point(12, 68)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(575, 181)
        Me.MainTabControl.TabIndex = 2
        '
        'RouteTabPage
        '
        Me.RouteTabPage.Controls.Add(Me.RouteDownloadButton)
        Me.RouteTabPage.Controls.Add(Me.RouteResultGroupBox)
        Me.RouteTabPage.Controls.Add(Me.RouteSetupGroupBox)
        Me.RouteTabPage.Location = New System.Drawing.Point(4, 22)
        Me.RouteTabPage.Name = "RouteTabPage"
        Me.RouteTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.RouteTabPage.Size = New System.Drawing.Size(567, 155)
        Me.RouteTabPage.TabIndex = 0
        Me.RouteTabPage.Text = "Route"
        Me.RouteTabPage.UseVisualStyleBackColor = True
        '
        'RouteDownloadButton
        '
        Me.RouteDownloadButton.Enabled = False
        Me.RouteDownloadButton.Image = Global.vatWX.My.Resources.Resources.Download
        Me.RouteDownloadButton.Location = New System.Drawing.Point(443, 18)
        Me.RouteDownloadButton.Name = "RouteDownloadButton"
        Me.RouteDownloadButton.Size = New System.Drawing.Size(112, 25)
        Me.RouteDownloadButton.TabIndex = 2
        Me.RouteDownloadButton.Text = "Download"
        Me.RouteDownloadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RouteDownloadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RouteDownloadButton.UseVisualStyleBackColor = True
        '
        'RouteResultGroupBox
        '
        Me.RouteResultGroupBox.Controls.Add(Me.RouteAlternateCopyButton)
        Me.RouteResultGroupBox.Controls.Add(Me.RouteDestinationCopyButton)
        Me.RouteResultGroupBox.Controls.Add(Me.RouteDepartureCopyButton)
        Me.RouteResultGroupBox.Controls.Add(Me.RouteResultAlternateTextBox)
        Me.RouteResultGroupBox.Controls.Add(Me.RouteResultDestinationTextBox)
        Me.RouteResultGroupBox.Controls.Add(Me.RouteResultDepartureTextBox)
        Me.RouteResultGroupBox.Controls.Add(Me.RouteResultAlternateLabel)
        Me.RouteResultGroupBox.Controls.Add(Me.RouteResultDestinationLabel)
        Me.RouteResultGroupBox.Controls.Add(Me.RouteResultDepartureLabel)
        Me.RouteResultGroupBox.Location = New System.Drawing.Point(7, 58)
        Me.RouteResultGroupBox.Name = "RouteResultGroupBox"
        Me.RouteResultGroupBox.Size = New System.Drawing.Size(554, 91)
        Me.RouteResultGroupBox.TabIndex = 1
        Me.RouteResultGroupBox.TabStop = False
        Me.RouteResultGroupBox.Text = "Result"
        '
        'RouteAlternateCopyButton
        '
        Me.RouteAlternateCopyButton.Enabled = False
        Me.RouteAlternateCopyButton.Image = Global.vatWX.My.Resources.Resources.Copy
        Me.RouteAlternateCopyButton.Location = New System.Drawing.Point(76, 61)
        Me.RouteAlternateCopyButton.Name = "RouteAlternateCopyButton"
        Me.RouteAlternateCopyButton.Size = New System.Drawing.Size(23, 23)
        Me.RouteAlternateCopyButton.TabIndex = 8
        Me.RouteAlternateCopyButton.UseVisualStyleBackColor = True
        '
        'RouteDestinationCopyButton
        '
        Me.RouteDestinationCopyButton.Enabled = False
        Me.RouteDestinationCopyButton.Image = Global.vatWX.My.Resources.Resources.Copy
        Me.RouteDestinationCopyButton.Location = New System.Drawing.Point(76, 38)
        Me.RouteDestinationCopyButton.Name = "RouteDestinationCopyButton"
        Me.RouteDestinationCopyButton.Size = New System.Drawing.Size(23, 23)
        Me.RouteDestinationCopyButton.TabIndex = 7
        Me.RouteDestinationCopyButton.UseVisualStyleBackColor = True
        '
        'RouteDepartureCopyButton
        '
        Me.RouteDepartureCopyButton.Enabled = False
        Me.RouteDepartureCopyButton.Image = Global.vatWX.My.Resources.Resources.Copy
        Me.RouteDepartureCopyButton.Location = New System.Drawing.Point(76, 15)
        Me.RouteDepartureCopyButton.Name = "RouteDepartureCopyButton"
        Me.RouteDepartureCopyButton.Size = New System.Drawing.Size(23, 23)
        Me.RouteDepartureCopyButton.TabIndex = 6
        Me.RouteDepartureCopyButton.UseVisualStyleBackColor = True
        '
        'RouteResultAlternateTextBox
        '
        Me.RouteResultAlternateTextBox.Location = New System.Drawing.Point(105, 62)
        Me.RouteResultAlternateTextBox.Name = "RouteResultAlternateTextBox"
        Me.RouteResultAlternateTextBox.ReadOnly = True
        Me.RouteResultAlternateTextBox.Size = New System.Drawing.Size(443, 20)
        Me.RouteResultAlternateTextBox.TabIndex = 5
        '
        'RouteResultDestinationTextBox
        '
        Me.RouteResultDestinationTextBox.Location = New System.Drawing.Point(105, 40)
        Me.RouteResultDestinationTextBox.Name = "RouteResultDestinationTextBox"
        Me.RouteResultDestinationTextBox.ReadOnly = True
        Me.RouteResultDestinationTextBox.Size = New System.Drawing.Size(443, 20)
        Me.RouteResultDestinationTextBox.TabIndex = 4
        '
        'RouteResultDepartureTextBox
        '
        Me.RouteResultDepartureTextBox.Location = New System.Drawing.Point(105, 18)
        Me.RouteResultDepartureTextBox.Name = "RouteResultDepartureTextBox"
        Me.RouteResultDepartureTextBox.ReadOnly = True
        Me.RouteResultDepartureTextBox.Size = New System.Drawing.Size(443, 20)
        Me.RouteResultDepartureTextBox.TabIndex = 3
        '
        'RouteResultAlternateLabel
        '
        Me.RouteResultAlternateLabel.AutoSize = True
        Me.RouteResultAlternateLabel.Location = New System.Drawing.Point(9, 66)
        Me.RouteResultAlternateLabel.Name = "RouteResultAlternateLabel"
        Me.RouteResultAlternateLabel.Size = New System.Drawing.Size(49, 13)
        Me.RouteResultAlternateLabel.TabIndex = 2
        Me.RouteResultAlternateLabel.Text = "Alternate"
        '
        'RouteResultDestinationLabel
        '
        Me.RouteResultDestinationLabel.AutoSize = True
        Me.RouteResultDestinationLabel.Location = New System.Drawing.Point(9, 43)
        Me.RouteResultDestinationLabel.Name = "RouteResultDestinationLabel"
        Me.RouteResultDestinationLabel.Size = New System.Drawing.Size(60, 13)
        Me.RouteResultDestinationLabel.TabIndex = 1
        Me.RouteResultDestinationLabel.Text = "Destination"
        '
        'RouteResultDepartureLabel
        '
        Me.RouteResultDepartureLabel.AutoSize = True
        Me.RouteResultDepartureLabel.Location = New System.Drawing.Point(9, 20)
        Me.RouteResultDepartureLabel.Name = "RouteResultDepartureLabel"
        Me.RouteResultDepartureLabel.Size = New System.Drawing.Size(54, 13)
        Me.RouteResultDepartureLabel.TabIndex = 0
        Me.RouteResultDepartureLabel.Text = "Departure"
        '
        'RouteSetupGroupBox
        '
        Me.RouteSetupGroupBox.Controls.Add(Me.RouteAlternateTextBox)
        Me.RouteSetupGroupBox.Controls.Add(Me.RouteAlternateLabel)
        Me.RouteSetupGroupBox.Controls.Add(Me.RouteDestinationTextBox)
        Me.RouteSetupGroupBox.Controls.Add(Me.RouteDestinationLabel)
        Me.RouteSetupGroupBox.Controls.Add(Me.RouteDepartureTextBox)
        Me.RouteSetupGroupBox.Controls.Add(Me.RouteDepartureLabel)
        Me.RouteSetupGroupBox.Location = New System.Drawing.Point(6, 6)
        Me.RouteSetupGroupBox.Name = "RouteSetupGroupBox"
        Me.RouteSetupGroupBox.Size = New System.Drawing.Size(422, 45)
        Me.RouteSetupGroupBox.TabIndex = 0
        Me.RouteSetupGroupBox.TabStop = False
        Me.RouteSetupGroupBox.Text = "Setup"
        '
        'RouteAlternateTextBox
        '
        Me.RouteAlternateTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RouteAlternateTextBox.Location = New System.Drawing.Point(373, 16)
        Me.RouteAlternateTextBox.MaxLength = 4
        Me.RouteAlternateTextBox.Name = "RouteAlternateTextBox"
        Me.RouteAlternateTextBox.Size = New System.Drawing.Size(42, 20)
        Me.RouteAlternateTextBox.TabIndex = 5
        '
        'RouteAlternateLabel
        '
        Me.RouteAlternateLabel.AutoSize = True
        Me.RouteAlternateLabel.Location = New System.Drawing.Point(289, 20)
        Me.RouteAlternateLabel.Name = "RouteAlternateLabel"
        Me.RouteAlternateLabel.Size = New System.Drawing.Size(77, 13)
        Me.RouteAlternateLabel.TabIndex = 4
        Me.RouteAlternateLabel.Text = "Alternate ICAO"
        '
        'RouteDestinationTextBox
        '
        Me.RouteDestinationTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RouteDestinationTextBox.Location = New System.Drawing.Point(240, 17)
        Me.RouteDestinationTextBox.MaxLength = 4
        Me.RouteDestinationTextBox.Name = "RouteDestinationTextBox"
        Me.RouteDestinationTextBox.Size = New System.Drawing.Size(42, 20)
        Me.RouteDestinationTextBox.TabIndex = 3
        '
        'RouteDestinationLabel
        '
        Me.RouteDestinationLabel.AutoSize = True
        Me.RouteDestinationLabel.Location = New System.Drawing.Point(145, 20)
        Me.RouteDestinationLabel.Name = "RouteDestinationLabel"
        Me.RouteDestinationLabel.Size = New System.Drawing.Size(88, 13)
        Me.RouteDestinationLabel.TabIndex = 2
        Me.RouteDestinationLabel.Text = "Destination ICAO"
        '
        'RouteDepartureTextBox
        '
        Me.RouteDepartureTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RouteDepartureTextBox.Location = New System.Drawing.Point(96, 17)
        Me.RouteDepartureTextBox.MaxLength = 4
        Me.RouteDepartureTextBox.Name = "RouteDepartureTextBox"
        Me.RouteDepartureTextBox.Size = New System.Drawing.Size(42, 20)
        Me.RouteDepartureTextBox.TabIndex = 1
        '
        'RouteDepartureLabel
        '
        Me.RouteDepartureLabel.AutoSize = True
        Me.RouteDepartureLabel.Location = New System.Drawing.Point(7, 20)
        Me.RouteDepartureLabel.Name = "RouteDepartureLabel"
        Me.RouteDepartureLabel.Size = New System.Drawing.Size(82, 13)
        Me.RouteDepartureLabel.TabIndex = 0
        Me.RouteDepartureLabel.Text = "Departure ICAO"
        '
        'StationTabPage
        '
        Me.StationTabPage.Controls.Add(Me.CustomDownloadButton)
        Me.StationTabPage.Controls.Add(Me.CustomResultGroupBox)
        Me.StationTabPage.Controls.Add(Me.CustomSetupGroupBox)
        Me.StationTabPage.Location = New System.Drawing.Point(4, 22)
        Me.StationTabPage.Name = "StationTabPage"
        Me.StationTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.StationTabPage.Size = New System.Drawing.Size(567, 155)
        Me.StationTabPage.TabIndex = 1
        Me.StationTabPage.Text = "Custom Station"
        Me.StationTabPage.UseVisualStyleBackColor = True
        '
        'CustomDownloadButton
        '
        Me.CustomDownloadButton.Enabled = False
        Me.CustomDownloadButton.Image = Global.vatWX.My.Resources.Resources.Download
        Me.CustomDownloadButton.Location = New System.Drawing.Point(312, 7)
        Me.CustomDownloadButton.Name = "CustomDownloadButton"
        Me.CustomDownloadButton.Size = New System.Drawing.Size(249, 64)
        Me.CustomDownloadButton.TabIndex = 2
        Me.CustomDownloadButton.Text = "Download"
        Me.CustomDownloadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CustomDownloadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CustomDownloadButton.UseVisualStyleBackColor = True
        '
        'CustomResultGroupBox
        '
        Me.CustomResultGroupBox.Controls.Add(Me.CustomResultCopyButton)
        Me.CustomResultGroupBox.Controls.Add(Me.CustomResultTextBox)
        Me.CustomResultGroupBox.Location = New System.Drawing.Point(7, 77)
        Me.CustomResultGroupBox.Name = "CustomResultGroupBox"
        Me.CustomResultGroupBox.Size = New System.Drawing.Size(554, 64)
        Me.CustomResultGroupBox.TabIndex = 1
        Me.CustomResultGroupBox.TabStop = False
        Me.CustomResultGroupBox.Text = "Result"
        '
        'CustomResultCopyButton
        '
        Me.CustomResultCopyButton.Enabled = False
        Me.CustomResultCopyButton.Image = Global.vatWX.My.Resources.Resources.Copy
        Me.CustomResultCopyButton.Location = New System.Drawing.Point(525, 24)
        Me.CustomResultCopyButton.Name = "CustomResultCopyButton"
        Me.CustomResultCopyButton.Size = New System.Drawing.Size(23, 23)
        Me.CustomResultCopyButton.TabIndex = 7
        Me.CustomResultCopyButton.UseVisualStyleBackColor = True
        '
        'CustomResultTextBox
        '
        Me.CustomResultTextBox.Location = New System.Drawing.Point(6, 26)
        Me.CustomResultTextBox.Name = "CustomResultTextBox"
        Me.CustomResultTextBox.ReadOnly = True
        Me.CustomResultTextBox.Size = New System.Drawing.Size(513, 20)
        Me.CustomResultTextBox.TabIndex = 4
        '
        'CustomSetupGroupBox
        '
        Me.CustomSetupGroupBox.Controls.Add(Me.CustomStationTextBox)
        Me.CustomSetupGroupBox.Controls.Add(Me.CustomStationLabel)
        Me.CustomSetupGroupBox.Location = New System.Drawing.Point(7, 7)
        Me.CustomSetupGroupBox.Name = "CustomSetupGroupBox"
        Me.CustomSetupGroupBox.Size = New System.Drawing.Size(292, 64)
        Me.CustomSetupGroupBox.TabIndex = 0
        Me.CustomSetupGroupBox.TabStop = False
        Me.CustomSetupGroupBox.Text = "Setup"
        '
        'CustomStationTextBox
        '
        Me.CustomStationTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CustomStationTextBox.Location = New System.Drawing.Point(158, 24)
        Me.CustomStationTextBox.MaxLength = 4
        Me.CustomStationTextBox.Name = "CustomStationTextBox"
        Me.CustomStationTextBox.Size = New System.Drawing.Size(42, 20)
        Me.CustomStationTextBox.TabIndex = 2
        '
        'CustomStationLabel
        '
        Me.CustomStationLabel.AutoSize = True
        Me.CustomStationLabel.Location = New System.Drawing.Point(84, 27)
        Me.CustomStationLabel.Name = "CustomStationLabel"
        Me.CustomStationLabel.Size = New System.Drawing.Size(68, 13)
        Me.CustomStationLabel.TabIndex = 0
        Me.CustomStationLabel.Text = "Station ICAO"
        '
        'AttributionLinkLabel
        '
        Me.AttributionLinkLabel.ActiveLinkColor = System.Drawing.Color.Black
        Me.AttributionLinkLabel.AutoSize = True
        Me.AttributionLinkLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AttributionLinkLabel.Location = New System.Drawing.Point(488, 9)
        Me.AttributionLinkLabel.Name = "AttributionLinkLabel"
        Me.AttributionLinkLabel.Size = New System.Drawing.Size(99, 13)
        Me.AttributionLinkLabel.TabIndex = 3
        Me.AttributionLinkLabel.TabStop = True
        Me.AttributionLinkLabel.Text = "by George Peppard"
        Me.AttributionLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'MainForm
        '
        Me.AcceptButton = Me.RouteDownloadButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 261)
        Me.Controls.Add(Me.AttributionLinkLabel)
        Me.Controls.Add(Me.MainTabControl)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "vatWX"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainTabControl.ResumeLayout(False)
        Me.RouteTabPage.ResumeLayout(False)
        Me.RouteResultGroupBox.ResumeLayout(False)
        Me.RouteResultGroupBox.PerformLayout()
        Me.RouteSetupGroupBox.ResumeLayout(False)
        Me.RouteSetupGroupBox.PerformLayout()
        Me.StationTabPage.ResumeLayout(False)
        Me.CustomResultGroupBox.ResumeLayout(False)
        Me.CustomResultGroupBox.PerformLayout()
        Me.CustomSetupGroupBox.ResumeLayout(False)
        Me.CustomSetupGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents VersionLabel As Label
    Friend WithEvents MainTabControl As TabControl
    Friend WithEvents RouteTabPage As TabPage
    Friend WithEvents RouteSetupGroupBox As GroupBox
    Friend WithEvents RouteAlternateTextBox As TextBox
    Friend WithEvents RouteAlternateLabel As Label
    Friend WithEvents RouteDestinationTextBox As TextBox
    Friend WithEvents RouteDestinationLabel As Label
    Friend WithEvents RouteDepartureTextBox As TextBox
    Friend WithEvents RouteDepartureLabel As Label
    Friend WithEvents StationTabPage As TabPage
    Friend WithEvents RouteResultGroupBox As GroupBox
    Friend WithEvents RouteResultAlternateTextBox As TextBox
    Friend WithEvents RouteResultDestinationTextBox As TextBox
    Friend WithEvents RouteResultDepartureTextBox As TextBox
    Friend WithEvents RouteResultAlternateLabel As Label
    Friend WithEvents RouteResultDestinationLabel As Label
    Friend WithEvents RouteResultDepartureLabel As Label
    Friend WithEvents RouteDownloadButton As Button
    Friend WithEvents RouteAlternateCopyButton As Button
    Friend WithEvents RouteDestinationCopyButton As Button
    Friend WithEvents RouteDepartureCopyButton As Button
    Friend WithEvents CustomDownloadButton As Button
    Friend WithEvents CustomResultGroupBox As GroupBox
    Friend WithEvents CustomSetupGroupBox As GroupBox
    Friend WithEvents CustomStationTextBox As TextBox
    Friend WithEvents CustomStationLabel As Label
    Friend WithEvents CustomResultCopyButton As Button
    Friend WithEvents CustomResultTextBox As TextBox
    Friend WithEvents AttributionLinkLabel As LinkLabel
    Friend WithEvents MainFormToolTip As ToolTip
End Class
