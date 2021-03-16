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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Start = New System.Windows.Forms.Button()
        Me.HowTo = New System.Windows.Forms.Button()
        Me.Quit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGreen
        Me.Label1.Location = New System.Drawing.Point(167, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(803, 140)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bunny Adventure!"
        '
        'Start
        '
        Me.Start.Font = New System.Drawing.Font("MV Boli", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start.Location = New System.Drawing.Point(448, 196)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(268, 85)
        Me.Start.TabIndex = 1
        Me.Start.Text = "Start!"
        Me.Start.UseVisualStyleBackColor = True
        '
        'HowTo
        '
        Me.HowTo.Font = New System.Drawing.Font("MV Boli", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HowTo.Location = New System.Drawing.Point(191, 319)
        Me.HowTo.Name = "HowTo"
        Me.HowTo.Size = New System.Drawing.Size(268, 85)
        Me.HowTo.TabIndex = 2
        Me.HowTo.Text = "How To!"
        Me.HowTo.UseVisualStyleBackColor = True
        '
        'Quit
        '
        Me.Quit.Font = New System.Drawing.Font("MV Boli", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quit.Location = New System.Drawing.Point(702, 319)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(268, 85)
        Me.Quit.TabIndex = 3
        Me.Quit.Text = "Quit!"
        Me.Quit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 464)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Game Created By:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 481)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jacob Pickett"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 498)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Alfredo Alamdar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 515)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Celestine Dew"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1139, 541)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.HowTo)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Start"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Start As Button
    Friend WithEvents HowTo As Button
    Friend WithEvents Quit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
