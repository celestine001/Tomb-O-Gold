<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HowTo = New System.Windows.Forms.Button()
        Me.Quit = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.btnS = New System.Windows.Forms.Button()
        Me.btnW = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Carrot1 = New System.Windows.Forms.PictureBox()
        Me.Snake2 = New System.Windows.Forms.PictureBox()
        Me.Snake1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Carrot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Snake2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Snake1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Carrot1)
        Me.Panel1.Controls.Add(Me.Snake2)
        Me.Panel1.Controls.Add(Me.Snake1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(25, 50)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1275, 404)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Score: 0"
        '
        'HowTo
        '
        Me.HowTo.Font = New System.Drawing.Font("MV Boli", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HowTo.Location = New System.Drawing.Point(35, 500)
        Me.HowTo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HowTo.Name = "HowTo"
        Me.HowTo.Size = New System.Drawing.Size(268, 85)
        Me.HowTo.TabIndex = 3
        Me.HowTo.Text = "How To!"
        Me.HowTo.UseVisualStyleBackColor = True
        '
        'Quit
        '
        Me.Quit.Font = New System.Drawing.Font("MV Boli", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quit.Location = New System.Drawing.Point(1032, 500)
        Me.Quit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(268, 85)
        Me.Quit.TabIndex = 4
        Me.Quit.Text = "Quit!"
        Me.Quit.UseVisualStyleBackColor = True
        '
        'btnA
        '
        Me.btnA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnA.Location = New System.Drawing.Point(517, 556)
        Me.btnA.Margin = New System.Windows.Forms.Padding(4)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(100, 28)
        Me.btnA.TabIndex = 5
        Me.btnA.Text = "&A"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnD
        '
        Me.btnD.Location = New System.Drawing.Point(733, 556)
        Me.btnD.Margin = New System.Windows.Forms.Padding(4)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(100, 28)
        Me.btnD.TabIndex = 6
        Me.btnD.Text = "&D"
        Me.btnD.UseVisualStyleBackColor = True
        '
        'btnS
        '
        Me.btnS.Location = New System.Drawing.Point(625, 556)
        Me.btnS.Margin = New System.Windows.Forms.Padding(4)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(100, 28)
        Me.btnS.TabIndex = 7
        Me.btnS.Text = "&S"
        Me.btnS.UseVisualStyleBackColor = True
        '
        'btnW
        '
        Me.btnW.Location = New System.Drawing.Point(625, 521)
        Me.btnW.Margin = New System.Windows.Forms.Padding(4)
        Me.btnW.Name = "btnW"
        Me.btnW.Size = New System.Drawing.Size(100, 28)
        Me.btnW.TabIndex = 8
        Me.btnW.Text = "&W"
        Me.btnW.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1
        '
        'Carrot1
        '
        Me.Carrot1.Image = Global.BunnyAdventure.My.Resources.Resources.carrot
        Me.Carrot1.Location = New System.Drawing.Point(1074, 127)
        Me.Carrot1.Margin = New System.Windows.Forms.Padding(4)
        Me.Carrot1.Name = "Carrot1"
        Me.Carrot1.Size = New System.Drawing.Size(96, 96)
        Me.Carrot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Carrot1.TabIndex = 30
        Me.Carrot1.TabStop = False
        '
        'Snake2
        '
        Me.Snake2.Image = CType(resources.GetObject("Snake2.Image"), System.Drawing.Image)
        Me.Snake2.Location = New System.Drawing.Point(1104, 274)
        Me.Snake2.Margin = New System.Windows.Forms.Padding(4)
        Me.Snake2.Name = "Snake2"
        Me.Snake2.Size = New System.Drawing.Size(96, 96)
        Me.Snake2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Snake2.TabIndex = 29
        Me.Snake2.TabStop = False
        '
        'Snake1
        '
        Me.Snake1.Image = CType(resources.GetObject("Snake1.Image"), System.Drawing.Image)
        Me.Snake1.Location = New System.Drawing.Point(951, 192)
        Me.Snake1.Margin = New System.Windows.Forms.Padding(4)
        Me.Snake1.Name = "Snake1"
        Me.Snake1.Size = New System.Drawing.Size(96, 96)
        Me.Snake1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Snake1.TabIndex = 28
        Me.Snake1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BunnyAdventure.My.Resources.Resources.bunny__1_
        Me.PictureBox1.Location = New System.Drawing.Point(50, 170)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.BunnyAdventure.My.Resources.Resources.forest
        Me.PictureBox2.Location = New System.Drawing.Point(-629, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1267, 400)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.BunnyAdventure.My.Resources.Resources.forest
        Me.PictureBox3.Location = New System.Drawing.Point(635, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1267, 400)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 629)
        Me.Controls.Add(Me.btnW)
        Me.Controls.Add(Me.btnS)
        Me.Controls.Add(Me.btnD)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.HowTo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form2"
        Me.Text = "Game Screen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Carrot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Snake2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Snake1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents HowTo As Button
    Friend WithEvents Quit As Button
    Friend WithEvents btnA As Button
    Friend WithEvents btnD As Button
    Friend WithEvents btnS As Button
    Friend WithEvents btnW As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Snake1 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Carrot1 As PictureBox
    Friend WithEvents Snake2 As PictureBox
End Class
