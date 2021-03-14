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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1139, 541)
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
End Class
