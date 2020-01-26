<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Start = New System.Windows.Forms.Button()
        Me.Stp = New System.Windows.Forms.Button()
        Me.Speed = New System.Windows.Forms.Button()
        Me.Angle = New System.Windows.Forms.Button()
        Me.SpeedBox = New System.Windows.Forms.TextBox()
        Me.AngleBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(42, 50)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(75, 23)
        Me.Start.TabIndex = 0
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Stp
        '
        Me.Stp.Location = New System.Drawing.Point(42, 79)
        Me.Stp.Name = "Stp"
        Me.Stp.Size = New System.Drawing.Size(75, 23)
        Me.Stp.TabIndex = 1
        Me.Stp.Text = "Stop"
        Me.Stp.UseVisualStyleBackColor = True
        '
        'Speed
        '
        Me.Speed.Location = New System.Drawing.Point(42, 108)
        Me.Speed.Name = "Speed"
        Me.Speed.Size = New System.Drawing.Size(75, 23)
        Me.Speed.TabIndex = 2
        Me.Speed.Text = "Speed"
        Me.Speed.UseVisualStyleBackColor = True
        '
        'Angle
        '
        Me.Angle.Location = New System.Drawing.Point(42, 137)
        Me.Angle.Name = "Angle"
        Me.Angle.Size = New System.Drawing.Size(75, 23)
        Me.Angle.TabIndex = 3
        Me.Angle.Text = "Angle"
        Me.Angle.UseVisualStyleBackColor = True
        '
        'SpeedBox
        '
        Me.SpeedBox.Location = New System.Drawing.Point(123, 109)
        Me.SpeedBox.Name = "SpeedBox"
        Me.SpeedBox.Size = New System.Drawing.Size(100, 22)
        Me.SpeedBox.TabIndex = 4
        '
        'AngleBox
        '
        Me.AngleBox.Location = New System.Drawing.Point(123, 138)
        Me.AngleBox.Name = "AngleBox"
        Me.AngleBox.Size = New System.Drawing.Size(100, 22)
        Me.AngleBox.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 565)
        Me.Controls.Add(Me.AngleBox)
        Me.Controls.Add(Me.SpeedBox)
        Me.Controls.Add(Me.Angle)
        Me.Controls.Add(Me.Speed)
        Me.Controls.Add(Me.Stp)
        Me.Controls.Add(Me.Start)
        Me.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Stp As Button
    Friend WithEvents Speed As Button
    Friend WithEvents Angle As Button
    Protected Friend WithEvents Start As Button
    Friend WithEvents SpeedBox As TextBox
    Friend WithEvents AngleBox As TextBox
End Class
