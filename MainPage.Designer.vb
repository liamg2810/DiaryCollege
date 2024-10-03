<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Me.lblSub = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubTop = New System.Windows.Forms.Label()
        Me.lblTitleTop = New System.Windows.Forms.Label()
        Me.btnDiary = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSub
        '
        Me.lblSub.AutoSize = True
        Me.lblSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSub.ForeColor = System.Drawing.Color.Snow
        Me.lblSub.Location = New System.Drawing.Point(333, 411)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(162, 26)
        Me.lblSub.TabIndex = 3
        Me.lblSub.Text = "Stay Organised"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Snow
        Me.lblTitle.Location = New System.Drawing.Point(275, 360)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(291, 51)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Diary System"
        '
        'lblSubTop
        '
        Me.lblSubTop.AutoSize = True
        Me.lblSubTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTop.ForeColor = System.Drawing.Color.Snow
        Me.lblSubTop.Location = New System.Drawing.Point(258, 60)
        Me.lblSubTop.Name = "lblSubTop"
        Me.lblSubTop.Size = New System.Drawing.Size(344, 26)
        Me.lblSubTop.TabIndex = 5
        Me.lblSubTop.Text = "Select One Of The Options Below:"
        '
        'lblTitleTop
        '
        Me.lblTitleTop.AutoSize = True
        Me.lblTitleTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleTop.ForeColor = System.Drawing.Color.Snow
        Me.lblTitleTop.Location = New System.Drawing.Point(298, 9)
        Me.lblTitleTop.Name = "lblTitleTop"
        Me.lblTitleTop.Size = New System.Drawing.Size(237, 51)
        Me.lblTitleTop.TabIndex = 4
        Me.lblTitleTop.Text = "Main Page"
        '
        'btnDiary
        '
        Me.btnDiary.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnDiary.FlatAppearance.BorderSize = 0
        Me.btnDiary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiary.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnDiary.Location = New System.Drawing.Point(263, 121)
        Me.btnDiary.Name = "btnDiary"
        Me.btnDiary.Size = New System.Drawing.Size(339, 38)
        Me.btnDiary.TabIndex = 6
        Me.btnDiary.Text = "Diary Events"
        Me.btnDiary.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.Location = New System.Drawing.Point(647, 407)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(128, 30)
        Me.btnBack.TabIndex = 27
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDiary)
        Me.Controls.Add(Me.lblSubTop)
        Me.Controls.Add(Me.lblTitleTop)
        Me.Controls.Add(Me.lblSub)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "MainPage"
        Me.Text = "MainPage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSub As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubTop As Label
    Friend WithEvents lblTitleTop As Label
    Friend WithEvents btnDiary As Button
    Friend WithEvents btnBack As Button
End Class
