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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radCoffee = New System.Windows.Forms.RadioButton()
        Me.radTea = New System.Windows.Forms.RadioButton()
        Me.radSoftDrink = New System.Windows.Forms.RadioButton()
        Me.chkWhippedCream = New System.Windows.Forms.CheckBox()
        Me.chkMoca = New System.Windows.Forms.CheckBox()
        Me.chkAmaretto = New System.Windows.Forms.CheckBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSoftDrink)
        Me.GroupBox1.Controls.Add(Me.radTea)
        Me.GroupBox1.Controls.Add(Me.radCoffee)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(161, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Drink"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkAmaretto)
        Me.GroupBox2.Controls.Add(Me.chkMoca)
        Me.GroupBox2.Controls.Add(Me.chkWhippedCream)
        Me.GroupBox2.Location = New System.Drawing.Point(190, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(157, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Extras"
        '
        'radCoffee
        '
        Me.radCoffee.AutoSize = True
        Me.radCoffee.Location = New System.Drawing.Point(55, 19)
        Me.radCoffee.Name = "radCoffee"
        Me.radCoffee.Size = New System.Drawing.Size(56, 17)
        Me.radCoffee.TabIndex = 0
        Me.radCoffee.TabStop = True
        Me.radCoffee.Text = "Coffee"
        Me.radCoffee.UseVisualStyleBackColor = True
        '
        'radTea
        '
        Me.radTea.AutoSize = True
        Me.radTea.Location = New System.Drawing.Point(55, 42)
        Me.radTea.Name = "radTea"
        Me.radTea.Size = New System.Drawing.Size(44, 17)
        Me.radTea.TabIndex = 1
        Me.radTea.TabStop = True
        Me.radTea.Text = "Tea"
        Me.radTea.UseVisualStyleBackColor = True
        '
        'radSoftDrink
        '
        Me.radSoftDrink.AutoSize = True
        Me.radSoftDrink.Location = New System.Drawing.Point(55, 65)
        Me.radSoftDrink.Name = "radSoftDrink"
        Me.radSoftDrink.Size = New System.Drawing.Size(72, 17)
        Me.radSoftDrink.TabIndex = 2
        Me.radSoftDrink.TabStop = True
        Me.radSoftDrink.Text = "Soft Drink"
        Me.radSoftDrink.UseVisualStyleBackColor = True
        '
        'chkWhippedCream
        '
        Me.chkWhippedCream.AutoSize = True
        Me.chkWhippedCream.Location = New System.Drawing.Point(47, 19)
        Me.chkWhippedCream.Name = "chkWhippedCream"
        Me.chkWhippedCream.Size = New System.Drawing.Size(102, 17)
        Me.chkWhippedCream.TabIndex = 0
        Me.chkWhippedCream.Text = "Whipped Cream"
        Me.chkWhippedCream.UseVisualStyleBackColor = True
        '
        'chkMoca
        '
        Me.chkMoca.AutoSize = True
        Me.chkMoca.Location = New System.Drawing.Point(47, 42)
        Me.chkMoca.Name = "chkMoca"
        Me.chkMoca.Size = New System.Drawing.Size(53, 17)
        Me.chkMoca.TabIndex = 1
        Me.chkMoca.Text = "Moca"
        Me.chkMoca.UseVisualStyleBackColor = True
        '
        'chkAmaretto
        '
        Me.chkAmaretto.AutoSize = True
        Me.chkAmaretto.Location = New System.Drawing.Point(47, 65)
        Me.chkAmaretto.Name = "chkAmaretto"
        Me.chkAmaretto.Size = New System.Drawing.Size(68, 17)
        Me.chkAmaretto.TabIndex = 2
        Me.chkAmaretto.Text = "Amaretto"
        Me.chkAmaretto.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(128, 180)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(56, 35)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(190, 180)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(56, 35)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.Location = New System.Drawing.Point(23, 131)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(324, 46)
        Me.lblResult.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 227)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radSoftDrink As System.Windows.Forms.RadioButton
    Friend WithEvents radTea As System.Windows.Forms.RadioButton
    Friend WithEvents radCoffee As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAmaretto As System.Windows.Forms.CheckBox
    Friend WithEvents chkMoca As System.Windows.Forms.CheckBox
    Friend WithEvents chkWhippedCream As System.Windows.Forms.CheckBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label

End Class
