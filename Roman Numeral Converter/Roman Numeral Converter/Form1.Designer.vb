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
        Me.txtDecimal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNumerals = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDecimal
        '
        Me.txtDecimal.Location = New System.Drawing.Point(158, 28)
        Me.txtDecimal.Name = "txtDecimal"
        Me.txtDecimal.Size = New System.Drawing.Size(206, 20)
        Me.txtDecimal.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(15, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter a decimal integer in the range 1-10"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Equivalent Roman Numeral"
        '
        'lblNumerals
        '
        Me.lblNumerals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumerals.Location = New System.Drawing.Point(158, 68)
        Me.lblNumerals.Name = "lblNumerals"
        Me.lblNumerals.Size = New System.Drawing.Size(206, 20)
        Me.lblNumerals.TabIndex = 3
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(59, 121)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(254, 121)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 171)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblNumerals)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDecimal)
        Me.Name = "Form1"
        Me.Text = "Roman Numeral Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDecimal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNumerals As System.Windows.Forms.Label
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button

End Class
