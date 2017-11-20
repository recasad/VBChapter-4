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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.radBLT = New System.Windows.Forms.RadioButton()
        Me.radHam = New System.Windows.Forms.RadioButton()
        Me.radTurkey = New System.Windows.Forms.RadioButton()
        Me.radVeggie = New System.Windows.Forms.RadioButton()
        Me.radCookies = New System.Windows.Forms.RadioButton()
        Me.radPickle = New System.Windows.Forms.RadioButton()
        Me.radOnionRings = New System.Windows.Forms.RadioButton()
        Me.radChips = New System.Windows.Forms.RadioButton()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.chkMayo = New System.Windows.Forms.CheckBox()
        Me.chkBacon = New System.Windows.Forms.CheckBox()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.picCookie = New System.Windows.Forms.PictureBox()
        Me.picOnionRing = New System.Windows.Forms.PictureBox()
        Me.picPickles = New System.Windows.Forms.PictureBox()
        Me.picChips = New System.Windows.Forms.PictureBox()
        Me.picSandwich = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.picCookie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOnionRing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPickles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChips, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSandwich, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.radVeggie)
        Me.GroupBox1.Controls.Add(Me.radTurkey)
        Me.GroupBox1.Controls.Add(Me.radHam)
        Me.GroupBox1.Controls.Add(Me.radBLT)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(194, 132)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Your Meal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkBacon)
        Me.GroupBox2.Controls.Add(Me.chkMayo)
        Me.GroupBox2.Controls.Add(Me.chkLettuce)
        Me.GroupBox2.Controls.Add(Me.chkTomato)
        Me.GroupBox2.Location = New System.Drawing.Point(242, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(194, 132)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Toppings"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radCookies)
        Me.GroupBox3.Controls.Add(Me.radPickle)
        Me.GroupBox3.Controls.Add(Me.radOnionRings)
        Me.GroupBox3.Controls.Add(Me.radChips)
        Me.GroupBox3.Location = New System.Drawing.Point(242, 195)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(194, 125)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Side Order"
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(42, 195)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(194, 24)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'radBLT
        '
        Me.radBLT.AutoSize = True
        Me.radBLT.Location = New System.Drawing.Point(27, 28)
        Me.radBLT.Name = "radBLT"
        Me.radBLT.Size = New System.Drawing.Size(45, 17)
        Me.radBLT.TabIndex = 0
        Me.radBLT.TabStop = True
        Me.radBLT.Text = "BLT"
        Me.radBLT.UseVisualStyleBackColor = True
        '
        'radHam
        '
        Me.radHam.AutoSize = True
        Me.radHam.Location = New System.Drawing.Point(27, 51)
        Me.radHam.Name = "radHam"
        Me.radHam.Size = New System.Drawing.Size(115, 17)
        Me.radHam.TabIndex = 1
        Me.radHam.TabStop = True
        Me.radHam.Text = "Ham and American"
        Me.radHam.UseVisualStyleBackColor = True
        '
        'radTurkey
        '
        Me.radTurkey.AutoSize = True
        Me.radTurkey.Location = New System.Drawing.Point(27, 74)
        Me.radTurkey.Name = "radTurkey"
        Me.radTurkey.Size = New System.Drawing.Size(127, 17)
        Me.radTurkey.TabIndex = 2
        Me.radTurkey.TabStop = True
        Me.radTurkey.Text = "Turkey and Cranberry"
        Me.radTurkey.UseVisualStyleBackColor = True
        '
        'radVeggie
        '
        Me.radVeggie.AutoSize = True
        Me.radVeggie.Location = New System.Drawing.Point(27, 97)
        Me.radVeggie.Name = "radVeggie"
        Me.radVeggie.Size = New System.Drawing.Size(58, 17)
        Me.radVeggie.TabIndex = 3
        Me.radVeggie.TabStop = True
        Me.radVeggie.Text = "Veggie"
        Me.radVeggie.UseVisualStyleBackColor = True
        '
        'radCookies
        '
        Me.radCookies.AutoSize = True
        Me.radCookies.Location = New System.Drawing.Point(22, 88)
        Me.radCookies.Name = "radCookies"
        Me.radCookies.Size = New System.Drawing.Size(63, 17)
        Me.radCookies.TabIndex = 3
        Me.radCookies.TabStop = True
        Me.radCookies.Text = "Cookies"
        Me.radCookies.UseVisualStyleBackColor = True
        '
        'radPickle
        '
        Me.radPickle.AutoSize = True
        Me.radPickle.Location = New System.Drawing.Point(22, 65)
        Me.radPickle.Name = "radPickle"
        Me.radPickle.Size = New System.Drawing.Size(71, 17)
        Me.radPickle.TabIndex = 4
        Me.radPickle.TabStop = True
        Me.radPickle.Text = "Dill Pickle"
        Me.radPickle.UseVisualStyleBackColor = True
        '
        'radOnionRings
        '
        Me.radOnionRings.AutoSize = True
        Me.radOnionRings.Location = New System.Drawing.Point(22, 42)
        Me.radOnionRings.Name = "radOnionRings"
        Me.radOnionRings.Size = New System.Drawing.Size(83, 17)
        Me.radOnionRings.TabIndex = 5
        Me.radOnionRings.TabStop = True
        Me.radOnionRings.Text = "Onion Rings"
        Me.radOnionRings.UseVisualStyleBackColor = True
        '
        'radChips
        '
        Me.radChips.AutoSize = True
        Me.radChips.Location = New System.Drawing.Point(22, 19)
        Me.radChips.Name = "radChips"
        Me.radChips.Size = New System.Drawing.Size(87, 17)
        Me.radChips.TabIndex = 6
        Me.radChips.TabStop = True
        Me.radChips.Text = "Classic Chips"
        Me.radChips.UseVisualStyleBackColor = True
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(31, 29)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(62, 17)
        Me.chkTomato.TabIndex = 0
        Me.chkTomato.Text = "Tomato"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(31, 52)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(62, 17)
        Me.chkLettuce.TabIndex = 1
        Me.chkLettuce.Text = "Lettuce"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'chkMayo
        '
        Me.chkMayo.AutoSize = True
        Me.chkMayo.Location = New System.Drawing.Point(31, 75)
        Me.chkMayo.Name = "chkMayo"
        Me.chkMayo.Size = New System.Drawing.Size(52, 17)
        Me.chkMayo.TabIndex = 2
        Me.chkMayo.Text = "Mayo"
        Me.chkMayo.UseVisualStyleBackColor = True
        '
        'chkBacon
        '
        Me.chkBacon.AutoSize = True
        Me.chkBacon.Location = New System.Drawing.Point(31, 98)
        Me.chkBacon.Name = "chkBacon"
        Me.chkBacon.Size = New System.Drawing.Size(57, 17)
        Me.chkBacon.TabIndex = 3
        Me.chkBacon.Text = "Bacon"
        Me.chkBacon.UseVisualStyleBackColor = True
        '
        'lblOrder
        '
        Me.lblOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOrder.Location = New System.Drawing.Point(42, 227)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(190, 92)
        Me.lblOrder.TabIndex = 3
        '
        'picCookie
        '
        Me.picCookie.Image = Global.Class_Selection.My.Resources.Resources.smart_20cookie_20pic_20copy_original
        Me.picCookie.Location = New System.Drawing.Point(148, 323)
        Me.picCookie.Name = "picCookie"
        Me.picCookie.Size = New System.Drawing.Size(70, 51)
        Me.picCookie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCookie.TabIndex = 8
        Me.picCookie.TabStop = False
        Me.picCookie.Visible = False
        '
        'picOnionRing
        '
        Me.picOnionRing.Image = Global.Class_Selection.My.Resources.Resources.Jack_Box_Panko_Onion_Rings
        Me.picOnionRing.Location = New System.Drawing.Point(148, 323)
        Me.picOnionRing.Name = "picOnionRing"
        Me.picOnionRing.Size = New System.Drawing.Size(84, 51)
        Me.picOnionRing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOnionRing.TabIndex = 7
        Me.picOnionRing.TabStop = False
        Me.picOnionRing.Visible = False
        '
        'picPickles
        '
        Me.picPickles.Image = Global.Class_Selection.My.Resources.Resources.unnamed1
        Me.picPickles.Location = New System.Drawing.Point(148, 323)
        Me.picPickles.Name = "picPickles"
        Me.picPickles.Size = New System.Drawing.Size(84, 51)
        Me.picPickles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPickles.TabIndex = 6
        Me.picPickles.TabStop = False
        Me.picPickles.Visible = False
        '
        'picChips
        '
        Me.picChips.Image = Global.Class_Selection.My.Resources.Resources.download
        Me.picChips.Location = New System.Drawing.Point(148, 322)
        Me.picChips.Name = "picChips"
        Me.picChips.Size = New System.Drawing.Size(84, 51)
        Me.picChips.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChips.TabIndex = 5
        Me.picChips.TabStop = False
        Me.picChips.Visible = False
        '
        'picSandwich
        '
        Me.picSandwich.Image = Global.Class_Selection.My.Resources.Resources.phot_PartySub_920px
        Me.picSandwich.Location = New System.Drawing.Point(42, 323)
        Me.picSandwich.Name = "picSandwich"
        Me.picSandwich.Size = New System.Drawing.Size(100, 50)
        Me.picSandwich.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSandwich.TabIndex = 4
        Me.picSandwich.TabStop = False
        Me.picSandwich.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Class_Selection.My.Resources.Resources.phot_PartySub_920px
        Me.PictureBox1.Location = New System.Drawing.Point(171, 157)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(666, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(336, 340)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(239, 340)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Total:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 22)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Billy's Sandwich Shop Order Form"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 384)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.picCookie)
        Me.Controls.Add(Me.picOnionRing)
        Me.Controls.Add(Me.picPickles)
        Me.Controls.Add(Me.picChips)
        Me.Controls.Add(Me.picSandwich)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Billy's Sandwich Shop"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.picCookie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOnionRing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPickles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChips, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSandwich, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents radVeggie As System.Windows.Forms.RadioButton
    Friend WithEvents radTurkey As System.Windows.Forms.RadioButton
    Friend WithEvents radHam As System.Windows.Forms.RadioButton
    Friend WithEvents radBLT As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkBacon As System.Windows.Forms.CheckBox
    Friend WithEvents chkMayo As System.Windows.Forms.CheckBox
    Friend WithEvents chkLettuce As System.Windows.Forms.CheckBox
    Friend WithEvents chkTomato As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radCookies As System.Windows.Forms.RadioButton
    Friend WithEvents radPickle As System.Windows.Forms.RadioButton
    Friend WithEvents radOnionRings As System.Windows.Forms.RadioButton
    Friend WithEvents radChips As System.Windows.Forms.RadioButton
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents lblOrder As System.Windows.Forms.Label
    Friend WithEvents picSandwich As System.Windows.Forms.PictureBox
    Friend WithEvents picChips As System.Windows.Forms.PictureBox
    Friend WithEvents picPickles As System.Windows.Forms.PictureBox
    Friend WithEvents picOnionRing As System.Windows.Forms.PictureBox
    Friend WithEvents picCookie As System.Windows.Forms.PictureBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
