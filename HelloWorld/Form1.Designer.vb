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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.cbCompany = New System.Windows.Forms.ComboBox()
        Me.lblService = New System.Windows.Forms.Label()
        Me.cbService = New System.Windows.Forms.ComboBox()
        Me.lblActivity = New System.Windows.Forms.Label()
        Me.cbActivity = New System.Windows.Forms.ComboBox()
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
        Me.lblCompany.Location = New System.Drawing.Point(12, 9)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(76, 20)
        Me.lblCompany.TabIndex = 2
        Me.lblCompany.Text = "Company"
        '
        'cbCompany
        '
        Me.cbCompany.FormattingEnabled = True
        Me.cbCompany.Location = New System.Drawing.Point(94, 6)
        Me.cbCompany.Name = "cbCompany"
        Me.cbCompany.Size = New System.Drawing.Size(121, 28)
        Me.cbCompany.TabIndex = 3
        '
        'lblService
        '
        Me.lblService.AutoSize = True
        Me.lblService.Location = New System.Drawing.Point(27, 43)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(61, 20)
        Me.lblService.TabIndex = 4
        Me.lblService.Text = "Service"
        '
        'cbService
        '
        Me.cbService.FormattingEnabled = True
        Me.cbService.Location = New System.Drawing.Point(94, 40)
        Me.cbService.Name = "cbService"
        Me.cbService.Size = New System.Drawing.Size(121, 28)
        Me.cbService.TabIndex = 5
        '
        'lblActivity
        '
        Me.lblActivity.AutoSize = True
        Me.lblActivity.Location = New System.Drawing.Point(30, 77)
        Me.lblActivity.Name = "lblActivity"
        Me.lblActivity.Size = New System.Drawing.Size(58, 20)
        Me.lblActivity.TabIndex = 6
        Me.lblActivity.Text = "Activity"
        '
        'cbActivity
        '
        Me.cbActivity.FormattingEnabled = True
        Me.cbActivity.Location = New System.Drawing.Point(94, 74)
        Me.cbActivity.Name = "cbActivity"
        Me.cbActivity.Size = New System.Drawing.Size(121, 28)
        Me.cbActivity.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
