<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentInfo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cboSem = New System.Windows.Forms.ComboBox()
        Me.lblSem = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        Me.Label1.UseWaitCursor = True
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.BackColor = System.Drawing.Color.Transparent
        Me.lblMajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMajor.Location = New System.Drawing.Point(19, 137)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(74, 29)
        Me.lblMajor.TabIndex = 1
        Me.lblMajor.Text = "Major"
        Me.lblMajor.UseWaitCursor = True
        '
        'txtName
        '
        Me.txtName.AutoCompleteCustomSource.AddRange(New String() {"Patty Bagwell", "Jarrin Bartolome", "Jevonn Cobin", "Brandon Crowley", "Dr. Timothy Darr", "Brian Frable", "Jacob Fuller", "Christopher Hawkins", "Abbigail Hite", "Jacob Landsteiner", "Austin Marquis", "Tanner Pearson "})
        Me.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtName.BackColor = System.Drawing.Color.DarkGreen
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(20, 86)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(504, 35)
        Me.txtName.TabIndex = 6
        Me.txtName.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 29)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Course "
        Me.Label3.UseWaitCursor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Location = New System.Drawing.Point(508, 839)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 36)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        Me.btnExit.UseWaitCursor = True
        '
        'cboSem
        '
        Me.cboSem.BackColor = System.Drawing.Color.DarkGreen
        Me.cboSem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSem.ForeColor = System.Drawing.Color.Black
        Me.cboSem.FormattingEnabled = True
        Me.cboSem.Items.AddRange(New Object() {"Fall", "J-Term", "Spring", "Summer"})
        Me.cboSem.Location = New System.Drawing.Point(20, 410)
        Me.cboSem.Name = "cboSem"
        Me.cboSem.Size = New System.Drawing.Size(169, 37)
        Me.cboSem.TabIndex = 11
        Me.cboSem.Text = "Select"
        Me.cboSem.UseWaitCursor = True
        '
        'lblSem
        '
        Me.lblSem.AutoSize = True
        Me.lblSem.BackColor = System.Drawing.Color.Transparent
        Me.lblSem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSem.Location = New System.Drawing.Point(19, 363)
        Me.lblSem.Name = "lblSem"
        Me.lblSem.Size = New System.Drawing.Size(71, 29)
        Me.lblSem.TabIndex = 13
        Me.lblSem.Text = "Term"
        Me.lblSem.UseWaitCursor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.DarkGreen
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Computer Science", "Computer Information Systems", "Minor in Computer Science", "Computer Engineering", "Undecided "})
        Me.ComboBox1.Location = New System.Drawing.Point(20, 169)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(503, 37)
        Me.ComboBox1.TabIndex = 14
        Me.ComboBox1.Text = "Select"
        Me.ComboBox1.UseWaitCursor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.BackColor = System.Drawing.Color.DarkGreen
        Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"CIS 2703 - Computer Science I", "CIS 2723 - Computer Science II", "CIS 2803 - Systems Analysis", "CIS 3303 - Programming Languages", "CIS 3503 - Visual Programming", "CIS 3633 - Advanced Data", "CIS 3623 - Introduction to Web Development", "CIS 4023 - Operating Systems", "CIS 4043 - Data Structures", "CIS 4203 - Software Development Project", "CIS 5203 - Information Technology"})
        Me.ComboBox3.Location = New System.Drawing.Point(19, 292)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(504, 37)
        Me.ComboBox3.TabIndex = 16
        Me.ComboBox3.Text = "Select"
        Me.ComboBox3.UseWaitCursor = True
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.Location = New System.Drawing.Point(19, 839)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(92, 36)
        Me.btnOK.TabIndex = 17
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        Me.btnOK.UseWaitCursor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(117, 839)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 36)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "About"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.UseWaitCursor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Type Name"
        '
        'StudentInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(612, 887)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblSem)
        Me.Controls.Add(Me.cboSem)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblMajor)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StudentInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OBU "
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblMajor As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents cboSem As ComboBox
    Friend WithEvents lblSem As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents btnOK As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
