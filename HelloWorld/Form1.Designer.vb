<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.cbCompany = New System.Windows.Forms.ComboBox()
        Me.lblService = New System.Windows.Forms.Label()
        Me.cbService = New System.Windows.Forms.ComboBox()
        Me.lblActivity = New System.Windows.Forms.Label()
        Me.cbActivity = New System.Windows.Forms.ComboBox()
        Me.lblForStartDate = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.lblForStartTime = New System.Windows.Forms.Label()
        Me.lblForDuration = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cbUser = New System.Windows.Forms.ComboBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.lblBody = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 403)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 35)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(118, 410)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 20)
        Me.lblMessage.TabIndex = 1
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Location = New System.Drawing.Point(12, 71)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(76, 20)
        Me.lblCompany.TabIndex = 2
        Me.lblCompany.Text = "Company"
        '
        'cbCompany
        '
        Me.cbCompany.FormattingEnabled = True
        Me.cbCompany.Location = New System.Drawing.Point(94, 68)
        Me.cbCompany.Name = "cbCompany"
        Me.cbCompany.Size = New System.Drawing.Size(121, 28)
        Me.cbCompany.TabIndex = 3
        '
        'lblService
        '
        Me.lblService.AutoSize = True
        Me.lblService.Location = New System.Drawing.Point(27, 139)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(61, 20)
        Me.lblService.TabIndex = 4
        Me.lblService.Text = "Service"
        '
        'cbService
        '
        Me.cbService.FormattingEnabled = True
        Me.cbService.Location = New System.Drawing.Point(94, 136)
        Me.cbService.Name = "cbService"
        Me.cbService.Size = New System.Drawing.Size(121, 28)
        Me.cbService.TabIndex = 5
        '
        'lblActivity
        '
        Me.lblActivity.AutoSize = True
        Me.lblActivity.Location = New System.Drawing.Point(30, 173)
        Me.lblActivity.Name = "lblActivity"
        Me.lblActivity.Size = New System.Drawing.Size(58, 20)
        Me.lblActivity.TabIndex = 6
        Me.lblActivity.Text = "Activity"
        '
        'cbActivity
        '
        Me.cbActivity.FormattingEnabled = True
        Me.cbActivity.Location = New System.Drawing.Point(94, 170)
        Me.cbActivity.Name = "cbActivity"
        Me.cbActivity.Size = New System.Drawing.Size(121, 28)
        Me.cbActivity.TabIndex = 7
        '
        'lblForStartDate
        '
        Me.lblForStartDate.AutoSize = True
        Me.lblForStartDate.Location = New System.Drawing.Point(90, 5)
        Me.lblForStartDate.Name = "lblForStartDate"
        Me.lblForStartDate.Size = New System.Drawing.Size(119, 20)
        Me.lblForStartDate.TabIndex = 8
        Me.lblForStartDate.Text = "Fecha de inicio:"
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Location = New System.Drawing.Point(90, 25)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(91, 20)
        Me.lblStartDate.TabIndex = 9
        Me.lblStartDate.Text = "mm-dd-yyyy"
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Location = New System.Drawing.Point(278, 25)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(77, 20)
        Me.lblStartTime.TabIndex = 11
        Me.lblStartTime.Text = "hh:mm:ss"
        '
        'lblForStartTime
        '
        Me.lblForStartTime.AutoSize = True
        Me.lblForStartTime.Location = New System.Drawing.Point(278, 5)
        Me.lblForStartTime.Name = "lblForStartTime"
        Me.lblForStartTime.Size = New System.Drawing.Size(109, 20)
        Me.lblForStartTime.TabIndex = 10
        Me.lblForStartTime.Text = "Hora de inicio:"
        '
        'lblForDuration
        '
        Me.lblForDuration.AutoSize = True
        Me.lblForDuration.Location = New System.Drawing.Point(278, 116)
        Me.lblForDuration.Name = "lblForDuration"
        Me.lblForDuration.Size = New System.Drawing.Size(77, 20)
        Me.lblForDuration.TabIndex = 12
        Me.lblForDuration.Text = "Duración:"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(278, 136)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(71, 20)
        Me.lblDuration.TabIndex = 13
        Me.lblDuration.Text = "00:00:00"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'cbUser
        '
        Me.cbUser.FormattingEnabled = True
        Me.cbUser.Location = New System.Drawing.Point(94, 102)
        Me.cbUser.Name = "cbUser"
        Me.cbUser.Size = New System.Drawing.Size(121, 28)
        Me.cbUser.TabIndex = 15
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(45, 105)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(43, 20)
        Me.lblUser.TabIndex = 14
        Me.lblUser.Text = "User"
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(16, 230)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(200, 104)
        Me.txtMessage.TabIndex = 16
        '
        'lblBody
        '
        Me.lblBody.AutoSize = True
        Me.lblBody.Location = New System.Drawing.Point(14, 207)
        Me.lblBody.Name = "lblBody"
        Me.lblBody.Size = New System.Drawing.Size(74, 20)
        Me.lblBody.TabIndex = 17
        Me.lblBody.Text = "Message"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblBody)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.cbUser)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.lblForDuration)
        Me.Controls.Add(Me.lblStartTime)
        Me.Controls.Add(Me.lblForStartTime)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.lblForStartDate)
        Me.Controls.Add(Me.cbActivity)
        Me.Controls.Add(Me.lblActivity)
        Me.Controls.Add(Me.cbService)
        Me.Controls.Add(Me.lblService)
        Me.Controls.Add(Me.cbCompany)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents cbCompany As ComboBox
    Friend WithEvents lblService As Label
    Friend WithEvents cbService As ComboBox
    Friend WithEvents lblActivity As Label
    Friend WithEvents cbActivity As ComboBox
    Friend WithEvents lblForStartDate As Label
    Friend WithEvents lblStartDate As Label
    Friend WithEvents lblStartTime As Label
    Friend WithEvents lblForStartTime As Label
    Friend WithEvents lblForDuration As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cbUser As ComboBox
    Friend WithEvents lblUser As Label
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents lblBody As Label
End Class
