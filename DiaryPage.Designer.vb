<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiaryPage
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
        Dim lblTitleTop As System.Windows.Forms.Label
        Me.lblSubTop = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tbTitle = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.tbEntry = New System.Windows.Forms.TextBox()
        Me.lblEntry = New System.Windows.Forms.Label()
        Me.tbTarget = New System.Windows.Forms.TextBox()
        Me.lblTarget = New System.Windows.Forms.Label()
        Me.tbMood = New System.Windows.Forms.TextBox()
        Me.lblMood = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.dtpSearch = New System.Windows.Forms.DateTimePicker()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        lblTitleTop = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitleTop
        '
        lblTitleTop.AutoSize = True
        lblTitleTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitleTop.ForeColor = System.Drawing.Color.Snow
        lblTitleTop.Location = New System.Drawing.Point(343, 9)
        lblTitleTop.Name = "lblTitleTop"
        lblTitleTop.Size = New System.Drawing.Size(128, 51)
        lblTitleTop.TabIndex = 6
        lblTitleTop.Text = "Diary"
        '
        'lblSubTop
        '
        Me.lblSubTop.AutoSize = True
        Me.lblSubTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTop.ForeColor = System.Drawing.Color.Snow
        Me.lblSubTop.Location = New System.Drawing.Point(235, 60)
        Me.lblSubTop.Name = "lblSubTop"
        Me.lblSubTop.Size = New System.Drawing.Size(344, 26)
        Me.lblSubTop.TabIndex = 7
        Me.lblSubTop.Text = "Select One Of The Options Below:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Snow
        Me.lblTitle.Location = New System.Drawing.Point(74, 103)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(67, 26)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "Title*:"
        '
        'tbTitle
        '
        Me.tbTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.tbTitle.Location = New System.Drawing.Point(170, 100)
        Me.tbTitle.Name = "tbTitle"
        Me.tbTitle.Size = New System.Drawing.Size(339, 30)
        Me.tbTitle.TabIndex = 9
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Snow
        Me.lblDate.Location = New System.Drawing.Point(74, 148)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(64, 26)
        Me.lblDate.TabIndex = 10
        Me.lblDate.Text = "Date:"
        '
        'tbEntry
        '
        Me.tbEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.tbEntry.Location = New System.Drawing.Point(170, 186)
        Me.tbEntry.Multiline = True
        Me.tbEntry.Name = "tbEntry"
        Me.tbEntry.Size = New System.Drawing.Size(339, 129)
        Me.tbEntry.TabIndex = 13
        '
        'lblEntry
        '
        Me.lblEntry.AutoSize = True
        Me.lblEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntry.ForeColor = System.Drawing.Color.Snow
        Me.lblEntry.Location = New System.Drawing.Point(74, 189)
        Me.lblEntry.Name = "lblEntry"
        Me.lblEntry.Size = New System.Drawing.Size(78, 26)
        Me.lblEntry.TabIndex = 12
        Me.lblEntry.Text = "Entry*:"
        '
        'tbTarget
        '
        Me.tbTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.tbTarget.Location = New System.Drawing.Point(170, 357)
        Me.tbTarget.Name = "tbTarget"
        Me.tbTarget.Size = New System.Drawing.Size(339, 30)
        Me.tbTarget.TabIndex = 17
        '
        'lblTarget
        '
        Me.lblTarget.AutoSize = True
        Me.lblTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTarget.ForeColor = System.Drawing.Color.Snow
        Me.lblTarget.Location = New System.Drawing.Point(74, 360)
        Me.lblTarget.Name = "lblTarget"
        Me.lblTarget.Size = New System.Drawing.Size(90, 26)
        Me.lblTarget.TabIndex = 16
        Me.lblTarget.Text = "Targets:"
        '
        'tbMood
        '
        Me.tbMood.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.tbMood.Location = New System.Drawing.Point(170, 321)
        Me.tbMood.Name = "tbMood"
        Me.tbMood.Size = New System.Drawing.Size(339, 30)
        Me.tbMood.TabIndex = 15
        '
        'lblMood
        '
        Me.lblMood.AutoSize = True
        Me.lblMood.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMood.ForeColor = System.Drawing.Color.Snow
        Me.lblMood.Location = New System.Drawing.Point(74, 324)
        Me.lblMood.Name = "lblMood"
        Me.lblMood.Size = New System.Drawing.Size(72, 26)
        Me.lblMood.TabIndex = 14
        Me.lblMood.Text = "Mood:"
        '
        'dtpDate
        '
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.dtpDate.Location = New System.Drawing.Point(170, 145)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(339, 32)
        Me.dtpDate.TabIndex = 18
        Me.dtpDate.Value = New Date(2024, 10, 3, 0, 0, 0, 0)
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.Snow
        Me.lblSearch.Location = New System.Drawing.Point(546, 100)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(133, 26)
        Me.lblSearch.TabIndex = 19
        Me.lblSearch.Text = "Search Date"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.Location = New System.Drawing.Point(551, 166)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(213, 30)
        Me.btnSearch.TabIndex = 21
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubmit.Location = New System.Drawing.Point(170, 408)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(339, 30)
        Me.btnSubmit.TabIndex = 22
        Me.btnSubmit.Text = "Add Diary Entry"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnNext.Location = New System.Drawing.Point(551, 285)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(128, 30)
        Me.btnNext.TabIndex = 23
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'dtpSearch
        '
        Me.dtpSearch.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dtpSearch.CustomFormat = "dd/mm/yyyy"
        Me.dtpSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.dtpSearch.Location = New System.Drawing.Point(551, 129)
        Me.dtpSearch.Name = "dtpSearch"
        Me.dtpSearch.Size = New System.Drawing.Size(213, 32)
        Me.dtpSearch.TabIndex = 24
        Me.dtpSearch.Value = New Date(2024, 10, 3, 0, 0, 0, 0)
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnPrevious.FlatAppearance.BorderSize = 0
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrevious.Location = New System.Drawing.Point(551, 323)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(128, 30)
        Me.btnPrevious.TabIndex = 25
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.Location = New System.Drawing.Point(636, 408)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(128, 30)
        Me.btnBack.TabIndex = 26
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'DiaryPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.dtpSearch)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.tbTarget)
        Me.Controls.Add(Me.lblTarget)
        Me.Controls.Add(Me.tbMood)
        Me.Controls.Add(Me.lblMood)
        Me.Controls.Add(Me.tbEntry)
        Me.Controls.Add(Me.lblEntry)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.tbTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblSubTop)
        Me.Controls.Add(lblTitleTop)
        Me.Name = "DiaryPage"
        Me.Text = "DiaryPage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSubTop As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents tbTitle As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents tbEntry As TextBox
    Friend WithEvents lblEntry As Label
    Friend WithEvents tbTarget As TextBox
    Friend WithEvents lblTarget As Label
    Friend WithEvents tbMood As TextBox
    Friend WithEvents lblMood As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblSearch As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents dtpSearch As DateTimePicker
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnBack As Button
End Class
