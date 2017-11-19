<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Story
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Story))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblStory = New System.Windows.Forms.Label()
        Me.btnCloseStory = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitle.Font = New System.Drawing.Font("High Tower Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTitle.Location = New System.Drawing.Point(59, 40)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(585, 53)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblStory
        '
        Me.lblStory.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblStory.Font = New System.Drawing.Font("High Tower Text", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStory.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblStory.Location = New System.Drawing.Point(59, 133)
        Me.lblStory.Name = "lblStory"
        Me.lblStory.Size = New System.Drawing.Size(585, 196)
        Me.lblStory.TabIndex = 1
        Me.lblStory.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCloseStory
        '
        Me.btnCloseStory.Font = New System.Drawing.Font("High Tower Text", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseStory.Location = New System.Drawing.Point(303, 332)
        Me.btnCloseStory.Name = "btnCloseStory"
        Me.btnCloseStory.Size = New System.Drawing.Size(100, 53)
        Me.btnCloseStory.TabIndex = 2
        Me.btnCloseStory.Text = "Close Story"
        Me.btnCloseStory.UseVisualStyleBackColor = True
        '
        'Story
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(708, 405)
        Me.Controls.Add(Me.btnCloseStory)
        Me.Controls.Add(Me.lblStory)
        Me.Controls.Add(Me.lblTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Story"
        Me.Text = "Your Holiday Story"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblStory As Label
    Friend WithEvents btnCloseStory As Button
End Class
