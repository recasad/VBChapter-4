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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.lblThird = New System.Windows.Forms.Label()
        Me.txtName1 = New System.Windows.Forms.TextBox()
        Me.txtName2 = New System.Windows.Forms.TextBox()
        Me.txtName3 = New System.Windows.Forms.TextBox()
        Me.txtTime3 = New System.Windows.Forms.TextBox()
        Me.txtTime2 = New System.Windows.Forms.TextBox()
        Me.txtTime1 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the three runners' names and finishing times."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Runner 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Runner 2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Runner 3:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(230, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Finishing Time (in seconds)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "1st Place:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "2nd Place:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "3rd Place:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(130, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Name"
        '
        'lblFirst
        '
        Me.lblFirst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFirst.Location = New System.Drawing.Point(98, 24)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(148, 20)
        Me.lblFirst.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSecond)
        Me.GroupBox1.Controls.Add(Me.lblThird)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblFirst)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(92, 153)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 100)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Race Results"
        '
        'lblSecond
        '
        Me.lblSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSecond.Location = New System.Drawing.Point(98, 48)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(148, 20)
        Me.lblSecond.TabIndex = 13
        '
        'lblThird
        '
        Me.lblThird.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblThird.Location = New System.Drawing.Point(98, 75)
        Me.lblThird.Name = "lblThird"
        Me.lblThird.Size = New System.Drawing.Size(148, 20)
        Me.lblThird.TabIndex = 12
        '
        'txtName1
        '
        Me.txtName1.Location = New System.Drawing.Point(92, 66)
        Me.txtName1.Name = "txtName1"
        Me.txtName1.Size = New System.Drawing.Size(114, 20)
        Me.txtName1.TabIndex = 13
        '
        'txtName2
        '
        Me.txtName2.Location = New System.Drawing.Point(92, 94)
        Me.txtName2.Name = "txtName2"
        Me.txtName2.Size = New System.Drawing.Size(114, 20)
        Me.txtName2.TabIndex = 14
        '
        'txtName3
        '
        Me.txtName3.Location = New System.Drawing.Point(92, 116)
        Me.txtName3.Name = "txtName3"
        Me.txtName3.Size = New System.Drawing.Size(114, 20)
        Me.txtName3.TabIndex = 15
        '
        'txtTime3
        '
        Me.txtTime3.Location = New System.Drawing.Point(233, 116)
        Me.txtTime3.Name = "txtTime3"
        Me.txtTime3.Size = New System.Drawing.Size(131, 20)
        Me.txtTime3.TabIndex = 16
        '
        'txtTime2
        '
        Me.txtTime2.Location = New System.Drawing.Point(233, 94)
        Me.txtTime2.Name = "txtTime2"
        Me.txtTime2.Size = New System.Drawing.Size(131, 20)
        Me.txtTime2.TabIndex = 17
        '
        'txtTime1
        '
        Me.txtTime1.Location = New System.Drawing.Point(233, 66)
        Me.txtTime1.Name = "txtTime1"
        Me.txtTime1.Size = New System.Drawing.Size(131, 20)
        Me.txtTime1.TabIndex = 18
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(68, 271)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 38)
        Me.btnCalculate.TabIndex = 19
        Me.btnCalculate.Text = "Calculate Results"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(166, 271)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 38)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(263, 271)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 38)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 351)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTime1)
        Me.Controls.Add(Me.txtTime2)
        Me.Controls.Add(Me.txtTime3)
        Me.Controls.Add(Me.txtName3)
        Me.Controls.Add(Me.txtName2)
        Me.Controls.Add(Me.txtName1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Running Times"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblSecond As System.Windows.Forms.Label
    Friend WithEvents lblThird As System.Windows.Forms.Label
    Friend WithEvents txtName1 As System.Windows.Forms.TextBox
    Friend WithEvents txtName2 As System.Windows.Forms.TextBox
    Friend WithEvents txtName3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTime3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTime2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTime1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
